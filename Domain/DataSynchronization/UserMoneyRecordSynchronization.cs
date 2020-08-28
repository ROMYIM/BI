using Core.DataBase.Mongo;
using Domain.DataSynchronization.Managers;
using Infrastructure.Db.Contexts;
using Infrastructure.Db.Dtoes.Mongo.Bill;
using Infrastructure.Db.Dtoes.Pg;
using Infrastructure.Helpers;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.DataSynchronization.Managers
{
    public class UserMoneyRecordSynchronization : Synchronization<UserMoneyRecord, Usermoneyrecord>
    {
        public UserMoneyRecordSynchronization(MongoDbContext mongoDbContext, FlytBIDbContext flytBIDbContext, ILoggerFactory loggerFactory) 
            : base(mongoDbContext, flytBIDbContext, loggerFactory)
        {
        }

        protected override Task DoSynchronizeAsync(MongoDB.Driver.MongoCollection<BsonDocument> collection, int startIndex, int synchronizeCount)
        {
            var documents = collection.FindAll().SetSkip(startIndex).SetLimit(synchronizeCount).ToList();
            var mongoErrors = new List<(BsonValue, string)>(documents.Count);
            var insertData = new List<Usermoneyrecord>(documents.Count);
            var feesClassItems = new LinkedList<UserFessClassItem>();
            var costClassItems = new LinkedList<CostPostTypeFeesClassItem>();
            var sopIds = new LinkedList<SopId>();
            ICollection< (string, string, string, object, string)> pgErrors = 
                new LinkedList<(string, string, string, object, string)>();

            /// 查询并转换为pg实体
            foreach (var document in documents)
            {
                string entityId = null;
                try
                {
                    var pgEntity = new Usermoneyrecord();
                    var properties = pgEntity.GetType().GetProperties();
                    foreach (var element in document.Elements)
                    {
                        if (element.Name == "_id")
                        {
                            entityId = element.GetValue(typeof(string)).ToString();
                            var idProperty = properties.Where(p => p.Name == "Id").First();
                            idProperty.SetValue(pgEntity, entityId);
                        }
                        else if (element.Name == "SopIds" && element.Value.BsonType == BsonType.Array)
                        {
                            var sopIdValues = element.Value.AsBsonArray;
                            foreach (var sopIdValue in sopIdValues)
                            {
                                if (sopIdValue.BsonType == BsonType.Null) continue;
                                var sopIdEntity = new SopId()
                                {
                                    Id = GuidHelper.GenerateComb().ToString(),
                                    OpId = sopIdValue.AsString,
                                    UserMoneyRecordId = entityId
                                };
                                sopIds.AddLast(sopIdEntity);
                            }
                        }
                        else if (element.Name == "UserFeesClassItemsList" && element.Value.BsonType == BsonType.Array)
                        {
                            var feesItems = element.Value.AsBsonArray;

                            foreach (var feeItem in feesItems)
                            {
                                if (feeItem.BsonType == BsonType.Null) continue;

                                var feeItemEntity = new UserFessClassItem();
                                var feeItemProperties = feeItemEntity.GetType().GetProperties();
                                foreach (var itemElement in feeItem.AsBsonDocument.Elements)
                                {
                                    var property = feeItemProperties.Where(p => p.Name.ToLower() == itemElement.Name.ToLower()).FirstOrDefault();
                                    property.SetValue(feeItemEntity, itemElement.GetValue(property.PropertyType));
                                }
                                feeItemEntity.Id = GuidHelper.GenerateComb().ToString();
                                feeItemEntity.UserMoneyRecordId = entityId;
                                feesClassItems.AddLast(feeItemEntity);
                            }
                        }
                        else if (element.Name == "CostPostTypeFeesClassItemsList" && element.Value.BsonType == BsonType.Array)
                        {
                            var costFeesItems = element.Value.AsBsonArray;

                            foreach (var feeItem in costFeesItems)
                            {
                                if (feeItem.BsonType == BsonType.Null) continue;

                                var costFeeItemEntity = new CostPostTypeFeesClassItem();
                                var costFeeItemProperties = costFeeItemEntity.GetType().GetProperties();
                                foreach (var itemElement in feeItem.AsBsonDocument.Elements)
                                {
                                    var property = properties.Where(p => p.Name.ToLower() == itemElement.Name.ToLower()).FirstOrDefault();
                                    property.SetValue(costFeeItemEntity, itemElement.GetValue(property.PropertyType));
                                }
                                costFeeItemEntity.Id = GuidHelper.GenerateComb().ToString();
                                costFeeItemEntity.UserMoneyRecordId = entityId;
                                costClassItems.AddLast(costFeeItemEntity);
                            }
                        }
                        else
                        {
                            var property = properties.Where(p => p.Name.ToLower() == element.Name.ToLower()).FirstOrDefault();
                            property?.SetValue(pgEntity, element.GetValue(property.PropertyType));
                        }
                    }
                    insertData.Add(pgEntity);
                    //await _flytBIDbContext.AddAsync(pgEntity);
                }
                catch (Exception ex)
                {
                    mongoErrors.Add((entityId, ex.Message));
                    continue;
                }

            }

            _flytBIDbContext.BatchInsert(insertData, ref pgErrors);
            _flytBIDbContext.BatchInsert(feesClassItems, ref pgErrors);
            _flytBIDbContext.BatchInsert(costClassItems, ref pgErrors);
            _flytBIDbContext.BatchInsert(sopIds, ref pgErrors);
            insertData.Clear();

            foreach (var error in mongoErrors)
            {
                _logger.LogError("id：{}\n异常：{}", error.Item1, error.Item2);
            }

            foreach (var error in pgErrors)
            {
                _logger.LogError("table:{}  key:{}  field:{}  value:{}   message:{}", error.Item1, error.Item2, error.Item3, error.Item4, error.Item5);
            }

            return Task.CompletedTask;
        }

    }
}
