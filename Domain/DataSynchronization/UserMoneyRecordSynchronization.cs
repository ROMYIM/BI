using Core.DataBase.Mongo;
using Core.Extensions.Database.Query;
using Infrastructure.Db.Dtoes.Pg;
using Infrastructure.Helpers;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoUserMoneyRecord = Infrastructure.Db.Dtoes.Mongo.Bill.UserMoneyRecord;
using PgPeriodMoney = Infrastructure.Db.Dtoes.Pg.PeriodMoney;
using PgUserMoneyRecord = Infrastructure.Db.Dtoes.Pg.UserMoneyRecord;

namespace Domain.DataSynchronization.Managers
{
    public class UserMoneyRecordSynchronization : Synchronization<MongoUserMoneyRecord, PgUserMoneyRecord>
    {
        public UserMoneyRecordSynchronization(MongoDbContext mongoDbContext, ILoggerFactory loggerFactory, IServiceProvider serviceProvider) 
            : base(mongoDbContext, loggerFactory, serviceProvider)
        {
        }

        protected override async Task<ulong> DoSynchronizeAsync(IMongoCollection<BsonDocument> collection, DateTime startTime, TimeSpan synchronizeDuration)
        {
            var syncCount = default(ulong);

            var insertData = new LinkedList<PgUserMoneyRecord>();
            var feesClassItems = new LinkedList<UserFeesClassItem>();
            var costClassItems = new LinkedList<CostPostTypeFeesClassItem>();
            var sopIds = new LinkedList<SopId>();
            var periodMoneyInsertData = new LinkedList<PgPeriodMoney>();

            using var asyncCursor = await collection.FindDocumentsCursorAsync(
                d => d[UtcModifyTime] >= startTime && d[UtcModifyTime] < startTime + synchronizeDuration, _findOptions);
            while (await asyncCursor.MoveNextAsync())
            {

                var documents = asyncCursor.Current;
                if (!documents.Any()) continue ;

                string entityId = null;

                _stopwatch.Restart();
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

                                var feeItemEntity = new UserFeesClassItem();
                                var feeItemProperties = feeItemEntity.GetType().GetProperties();
                                foreach (var itemElement in feeItem.AsBsonDocument.Elements)
                                {
                                    var property = feeItemProperties.Where(p => p.Name.ToLower() == itemElement.Name.ToLower()).FirstOrDefault();
                                    property.SetValue(feeItemEntity, itemElement.GetValue(property.PropertyType));
                                }
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
                    insertData.AddLast(pgEntity);
                    //await _flytBIDbContext.AddAsync(pgEntity);

                }
                _stopwatch.Stop();
                _logger.LogInformation("转换数据。耗时{}", _stopwatch.Elapsed.TotalSeconds);

                _stopwatch.Restart();
                var commitCount = await _flytBIDbContext.BatchInsertAsync(insertData, GetTableSuffix(startTime));
                await _flytBIDbContext.BatchInsertAsync(feesClassItems, GetTableSuffix(startTime));
                await _flytBIDbContext.BatchInsertAsync(costClassItems, GetTableSuffix(startTime));
                await _flytBIDbContext.BatchInsertAsync(sopIds, GetTableSuffix(startTime));
                await _flytBIDbContext.BatchInsertAsync(periodMoneyInsertData, GetTableSuffix(startTime));
                _stopwatch.Stop();
                _logger.LogInformation("数据插入。耗时{}", _stopwatch.Elapsed.TotalSeconds);

                #region 中间缓存数据释放

                insertData.Clear();
                feesClassItems.Clear();
                costClassItems.Clear();
                sopIds.Clear();
                periodMoneyInsertData.Clear();

                #endregion

                syncCount += commitCount;
            }

            _logger.LogInformation("更新数量{}", syncCount);
            return syncCount;
        }

    }
}
