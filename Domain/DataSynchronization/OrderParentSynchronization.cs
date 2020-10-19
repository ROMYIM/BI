using Core.DataBase.Mongo;
using Core.Extensions.Database.Query;
using Core.Extensions.Text;
using Domain.DataSynchronization.Managers;
using Infrastructure.Db.Dtoes.Pg;
using Infrastructure.Exceptions;
using Infrastructure.Helpers;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoOrder = Infrastructure.Db.Dotes.Mongo.OrderEntity.OrderParent;
using PgOrder = Infrastructure.Db.Dtoes.Pg.OrderParent;

namespace Domain.DataSynchronization
{
    public class OrderParentSynchronization : Synchronization<MongoOrder, PgOrder>
    {

        public OrderParentSynchronization(MongoDbContext mongoDbContext, ILoggerFactory loggerFactory, IServiceProvider serviceProvider) 
            : base(mongoDbContext, loggerFactory, serviceProvider)
        {
            _findOptions.BatchSize = 1000;
        }

        protected override async Task<ulong> DoSynchronizeAsync(IMongoCollection<BsonDocument> collection, DateTime startTime, TimeSpan synchronizeDuration)
        {
            var syncCount = default(ulong);

            var orderInsertData = new LinkedList<PgOrder>();
            var apiOrderIdInsertData = new LinkedList<OrderApiOrderId>();
            var remarkInsertData = new LinkedList<OrderRemark>();
            var salesPlatformTranscationIdInsertData = new LinkedList<SalesPlatformTransactionId>();
            var salesRecordNumberInsetData = new LinkedList<SalesRecordNumber>();
            var orderDetailInsertData = new LinkedList<OrderDetail>();
            var haikwanDetailInsertData = new LinkedList<HaikwanDetail>();
            var multiPackageIdInsertData = new LinkedList<OrderMultiPackageId>();

            using var asyncCursor = await collection.FindDocumentsCursorAsync(
                d => d[UtcModifyTime] >= startTime && d[UtcModifyTime] < startTime + synchronizeDuration, _findOptions);
            while (await asyncCursor.MoveNextAsync())
            {
                var documents = asyncCursor.Current;
                if (!documents.Any()) continue;

                _stopwatch.Restart();
                foreach (var document in documents)
                {

                    var pgOrder = new PgOrder();
                    var orderType = pgOrder.GetType();
                    var properties = orderType.GetProperties();

                    ///优先构建主键的属性
                    var idElement = document.GetElement("_id");
                    string orderId = idElement.GetValue(typeof(string)).ToString();
                    var idProperty = orderType.GetProperty("Id");
                    idProperty?.SetValue(pgOrder, orderId);

                    try
                    {
                        foreach (var element in document.Elements)
                        {

                            if (element.Name == "_id") continue;
                            else if (element.Name == "ApiOrderIds")
                            {
                                if (!element.Value.IsBsonArray) continue;

                                var apiOrderIds = element.Value.AsBsonArray;
                                foreach (var apiOrderId in apiOrderIds)
                                {
                                    if (apiOrderId.IsBsonNull) continue;
                                    var apiOrderIdEntity = new OrderApiOrderId()
                                    {

                                        ApiOrderId = apiOrderId.AsString,
                                        OrderId = orderId
                                    };
                                    apiOrderIdInsertData.AddLast(apiOrderIdEntity);
                                }
                            }
                            else if (element.Name == "Remarks")
                            {
                                if (!element.Value.IsBsonArray) continue;

                                var remarks = element.Value.AsBsonArray;
                                foreach (var remark in remarks)
                                {
                                    if (remark.BsonType == BsonType.Null) continue;
                                    var remarkEntity = new OrderRemark()
                                    {

                                        Remark = remark.AsString.ToUTF8(),
                                        OrderId = orderId,
                                    };
                                    remarkInsertData.AddLast(remarkEntity);
                                }
                            }
                            else if (element.Name == "SalesPlatformTransactionIds")
                            {
                                if (!element.Value.IsBsonArray) continue;

                                var salesPlatformTransactionIds = element.Value.AsBsonArray;
                                foreach (var salesPlatformTransactionId in salesPlatformTransactionIds)
                                {
                                    if (salesPlatformTransactionId.BsonType == BsonType.Null) continue;
                                    var salesPlatformTransactionIdEntity = new SalesPlatformTransactionId()
                                    {

                                        TransactionId = salesPlatformTransactionId.AsString,
                                        OrderId = orderId
                                    };
                                    salesPlatformTranscationIdInsertData.AddLast(salesPlatformTransactionIdEntity);
                                }
                            }
                            else if (element.Name == "SalesRecordNumbers")
                            {
                                if (!element.Value.IsBsonArray) continue;

                                var salesRecordNumbers = element.Value.AsBsonArray;
                                foreach (var salesRecordNumber in salesRecordNumbers)
                                {
                                    if (salesRecordNumber.IsBsonNull) continue;
                                    var salesRecordNumberEntity = new SalesRecordNumber()
                                    {

                                        RecordNumber = salesRecordNumber.As<int>(),
                                        OrderId = orderId
                                    };
                                    salesRecordNumberInsetData.AddLast(salesRecordNumberEntity);
                                }
                            }
                            //else if (element.Name == "OrderDetailList")
                            //{
                            //    if (!element.Value.IsBsonArray) continue;

                            //    var orderDetailList = element.Value.AsBsonArray;
                            //    foreach (var orderDetail in orderDetailList)
                            //    {
                            //        if (orderDetail.IsBsonNull) continue;
                            //        var orderDetailEntity = new OrderDetail()
                            //        {

                            //            OrderId = orderId
                            //        };

                            //        var detailDocument = orderDetail.AsBsonDocument;
                            //        var detailType = orderDetailEntity.GetType();
                            //        foreach (var detailElement in detailDocument.Elements)
                            //        {
                            //            var property = detailType.GetProperty(detailElement.Name);
                            //            property?.SetValue(orderDetailEntity, detailElement.GetValue(property.PropertyType));
                            //        }

                            //        orderDetailInsertData.AddLast(orderDetailEntity);
                            //    }
                            //}
                            else if (element.Name == "HaikwanDetialList")
                            {
                                if (!element.Value.IsBsonArray) continue;

                                var haikwanDetailList = element.Value.AsBsonArray;
                                foreach (var haikwanDetail in haikwanDetailList)
                                {
                                    if (haikwanDetail.IsBsonNull) continue;
                                    var haikwanDetailEntity = new HaikwanDetail()
                                    {

                                        OrderId = orderId
                                    };

                                    var detailDocument = haikwanDetail.AsBsonDocument;
                                    var detailType = haikwanDetailEntity.GetType();
                                    foreach (var detailElement in detailDocument.Elements)
                                    {
                                        var property = detailType.GetProperty(detailElement.Name);
                                        property?.SetValue(haikwanDetailEntity, detailElement.GetValue(property.PropertyType));
                                    }

                                    haikwanDetailInsertData.AddLast(haikwanDetailEntity);
                                }
                            }
                            else if (element.Name == "MultiPackageIds")
                            {
                                if (!element.Value.IsBsonArray) continue;

                                var multiPackageIds = element.Value.AsBsonArray;
                                foreach (var multiPackageId in multiPackageIds)
                                {
                                    if (multiPackageId.IsBsonNull) continue;
                                    var multiPackageIdEntity = new OrderMultiPackageId()
                                    {

                                        MultiPackageId = multiPackageId.AsString,
                                        OrderId = orderId
                                    };
                                    multiPackageIdInsertData.AddLast(multiPackageIdEntity);
                                }
                            }
                            else
                            {
                                var property = orderType.GetProperty(element.Name);
                                property?.SetValue(pgOrder, element.GetValue(property.PropertyType));
                            }
                        }
                    }
                    catch (Exception ex) when (!(ex is DataSynchronizationException))
                    {
                        throw new DataSynchronizationException(orderId, TableName + "_" + GetTableSuffix(startTime), ex);
                    }

                    orderInsertData.AddLast(pgOrder);
                }
                _stopwatch.Stop();
                _logger.LogInformation("数据转换。耗时{}", _stopwatch.Elapsed.TotalSeconds);

                _stopwatch.Restart();
                var commitCount = await _flytBIDbContext.BatchInsertAsync(orderInsertData, GetTableSuffix(startTime));
                await _flytBIDbContext.BatchInsertAsync(remarkInsertData, GetTableSuffix(startTime));
                await _flytBIDbContext.BatchInsertAsync(orderDetailInsertData, GetTableSuffix(startTime));
                await _flytBIDbContext.BatchInsertAsync(apiOrderIdInsertData, GetTableSuffix(startTime));
                await _flytBIDbContext.BatchInsertAsync(salesPlatformTranscationIdInsertData, GetTableSuffix(startTime));
                await _flytBIDbContext.BatchInsertAsync(salesRecordNumberInsetData, GetTableSuffix(startTime));
                await _flytBIDbContext.BatchInsertAsync(multiPackageIdInsertData, GetTableSuffix(startTime));
                await _flytBIDbContext.BatchInsertAsync(haikwanDetailInsertData, GetTableSuffix(startTime));

                _stopwatch.Stop();
                _logger.LogInformation("数据插入。耗时{}", _stopwatch.Elapsed.TotalSeconds);

                #region 释放中间缓存数据

                orderInsertData.Clear();
                remarkInsertData.Clear();
                apiOrderIdInsertData.Clear();
                salesPlatformTranscationIdInsertData.Clear();
                salesPlatformTranscationIdInsertData.Clear();
                multiPackageIdInsertData.Clear();
                haikwanDetailInsertData.Clear();

                #endregion

                syncCount += commitCount;
            }

            _logger.LogInformation("更新数据{}", syncCount);
            return syncCount;

        }

#if DEBUG
        protected override string GetTableSuffix(DateTime time = default)
        {
            return base.GetTableSuffix(default);
        }
#endif
    }
}
