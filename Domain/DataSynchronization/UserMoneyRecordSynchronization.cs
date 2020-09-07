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
using PgPeriodMoney = Infrastructure.Db.Dtoes.Pg.PeriodMoney;
using PgUserMoneyRecord = Infrastructure.Db.Dtoes.Pg.UserMoneyRecord;
using MongoUserMoneyRecord = Infrastructure.Db.Dtoes.Mongo.Bill.UserMoneyRecord;
using Npgsql;
using Infrastructure.Exceptions;

namespace Domain.DataSynchronization.Managers
{
    public class UserMoneyRecordSynchronization : Synchronization<MongoUserMoneyRecord, PgUserMoneyRecord>
    {
        public UserMoneyRecordSynchronization(MongoDbContext mongoDbContext, ILoggerFactory loggerFactory, IServiceProvider serviceProvider) 
            : base(mongoDbContext, loggerFactory, serviceProvider)
        {
        }

        protected override void DoSynchronize(MongoDB.Driver.MongoCollection<BsonDocument> collection, int startIndex, int synchronizeCount)
        {
            var documents = collection.FindAll().SetSkip(startIndex).SetLimit(synchronizeCount).ToList();
            var insertData = new List<PgUserMoneyRecord>(documents.Count);
            var feesClassItems = new LinkedList<Infrastructure.Db.Dtoes.Pg.UserFeesClassItem>();
            var costClassItems = new LinkedList<CostPostTypeFeesClassItem>();
            var sopIds = new LinkedList<SopId>();
            var periodMoneyInsertData = new LinkedList<PgPeriodMoney>();
                
            string entityId = null;

            /// 查询并转换为pg实体
            foreach (var document in documents)
            {

                var pgEntity = new PgUserMoneyRecord();
                var recordType = pgEntity.GetType();
                var properties = pgEntity.GetType().GetProperties();

                // 优先构建主键
                var idElement = document.GetElement("_id");
                entityId = idElement.GetValue(typeof(string)).ToString();
                var idProperty = recordType.GetProperty("Id");
                idProperty?.SetValue(pgEntity, entityId);

                foreach (var element in document.Elements)
                {
                    if (element.Name == "SopIds" && element.Value.BsonType == BsonType.Array)
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

                            var feeItemEntity = new Infrastructure.Db.Dtoes.Pg.UserFeesClassItem();
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
                    else if (element.Name == "PeriodMoenys" && element.Value.BsonType == BsonType.Array)
                    {
                        var periodMoneys = element.Value.AsBsonArray;
                        foreach (var periodMoney in periodMoneys)
                        {
                            if (periodMoney.BsonType == BsonType.Null) continue;

                            var periodMoneyDocument = periodMoney as BsonDocument;
                            var periodMoneyEntity = new PgPeriodMoney()
                            {
                                Id = GuidHelper.GenerateComb().ToString(),
                                UserMoneyRecordId = entityId,
                                PeriodKey = periodMoneyDocument.GetElement("PeriodKey").GetValue(typeof(string)).ToString(),
                                Money = periodMoneyDocument.GetElement("Moeny").Value.AsDouble
                            };
                            periodMoneyInsertData.AddLast(periodMoneyEntity);
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

            _flytBIDbContext.BatchInsert(insertData);
            _flytBIDbContext.BatchInsert(feesClassItems);
            _flytBIDbContext.BatchInsert(costClassItems);
            _flytBIDbContext.BatchInsert(sopIds);
            _flytBIDbContext.BatchInsert(periodMoneyInsertData);
        }

    }
}
