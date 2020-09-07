using Core.DataBase.Mongo;
using Domain.DataSynchronization.Managers;
using Infrastructure.Db.Dtoes.Pg;
using Infrastructure.Exceptions;
using Infrastructure.Helpers;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using MongoOrder = Infrastructure.Db.Dotes.Mongo.OrderEntity.OrderParent;
using PgOrder = Infrastructure.Db.Dtoes.Pg.OrderParent;

namespace Domain.DataSynchronization
{
    public class OrderParentSynchronization : Synchronization<MongoOrder, PgOrder>
    {
        public OrderParentSynchronization(MongoDbContext mongoDbContext, ILoggerFactory loggerFactory, IServiceProvider serviceProvider) 
            : base(mongoDbContext, loggerFactory, serviceProvider)
        {
        }

        protected override void DoSynchronize(MongoCollection<BsonDocument> collection, int startIndex, int synchronizeCount)
        {
            var documents = collection.FindAll().SetSkip(startIndex).SetLimit(synchronizeCount).ToList();

            var orderInsertData = new List<PgOrder>(documents.Count);
            var apiOrderIdInsertData = new LinkedList<OrderApiOrderId>();
            var remarkInsertData = new LinkedList<OrderRemark>();
            var salesPlatformTranscationIdInsertData = new LinkedList<SalesPlatformTransactionId>();
            var salesRecordNumberInsetData = new LinkedList<SalesRecordNumber>();
            var orderDetailInsertData = new LinkedList<OrderDetail>();
            var haikwanDetailInsertData = new LinkedList<HaikwanDetail>();
            var multiPackageIdInsertData = new LinkedList<OrderMultiPackageId>();

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

                foreach (var element in document.Elements)
                {

                    if (element.Name == "_id") continue;
                    else if (element.Name == "ApiOrderIds")
                    {
                        if (element.Value.BsonType != BsonType.Array) continue;

                        var apiOrderIds = element.Value.AsBsonArray;
                        foreach (var apiOrderId in apiOrderIds)
                        {
                            if (apiOrderId.BsonType == BsonType.Null) continue;
                            var apiOrderIdEntity = new OrderApiOrderId()
                            {
                                Id = GuidHelper.GenerateComb().ToString(),
                                ApiOrderId = apiOrderId.AsString,
                                OrderId = orderId
                            };
                            apiOrderIdInsertData.AddLast(apiOrderIdEntity);
                        }
                    }
                    else if (element.Name == "Remarks")
                    {
                        if (element.Value.BsonType != BsonType.Array) continue;

                        var remarks = element.Value.AsBsonArray;
                        foreach (var remark in remarks)
                        {
                            if (remark.BsonType == BsonType.Null) continue;
                            var remarkEntity = new OrderRemark()
                            {
                                Id = GuidHelper.GenerateComb().ToString(),
                                Remark = remark.AsString,
                                OrderId = orderId,
                            };
                            remarkInsertData.AddLast(remarkEntity);
                        }
                    }
                    else if (element.Name == "SalesPlatformTransactionIds")
                    {
                        if (element.Value.BsonType != BsonType.Array) continue;

                        var salesPlatformTransactionIds = element.Value.AsBsonArray;
                        foreach (var salesPlatformTransactionId in salesPlatformTransactionIds)
                        {
                            if (salesPlatformTransactionId.BsonType == BsonType.Null) continue;
                            var salesPlatformTransactionIdEntity = new SalesPlatformTransactionId()
                            {
                                Id = GuidHelper.GenerateComb().ToString(),
                                TransactionId = salesPlatformTransactionId.AsString,
                                OrderId = orderId
                            };
                            salesPlatformTranscationIdInsertData.AddLast(salesPlatformTransactionIdEntity);
                        }
                    }
                    else if (element.Name == "SalesRecordNumbers")
                    {
                        if (element.Value.BsonType != BsonType.Array) continue;

                        var salesRecordNumbers = element.Value.AsBsonArray;
                        foreach (var salesRecordNumber in salesRecordNumbers)
                        {
                            if (salesRecordNumber.BsonType == BsonType.Null) continue;
                            var salesRecordNumberEntity = new SalesRecordNumber()
                            {
                                Id = GuidHelper.GenerateComb().ToString(),
                                RecordNumber = salesRecordNumber.AsInt32,
                                OrderId = orderId
                            };
                            salesRecordNumberInsetData.AddLast(salesRecordNumberEntity);
                        }
                    }
                    else if (element.Name == "OrderDetailList")
                    {
                        if (element.Value.BsonType != BsonType.Array) continue;

                        var orderDetailList = element.Value.AsBsonArray;
                        foreach (var orderDetail in orderDetailList)
                        {
                            if (orderDetail.BsonType == BsonType.Null) continue;
                            var orderDetailEntity = new OrderDetail()
                            {
                                Id = GuidHelper.GenerateComb().ToString(),
                                OrderId = orderId
                            };

                            var detailDocument = orderDetail.AsBsonDocument;
                            var detailType = orderDetailEntity.GetType();
                            foreach (var detailElement in detailDocument.Elements)
                            {
                                var property = detailType.GetProperty(detailElement.Name);
                                property?.SetValue(orderDetailEntity, detailElement.GetValue(property.PropertyType));
                            }

                            orderDetailInsertData.AddLast(orderDetailEntity);
                        }
                    }
                    else if (element.Name == "HaikwanDetialList")
                    {
                        if (element.Value.BsonType != BsonType.Array) continue;

                        var haikwanDetailList = element.Value.AsBsonArray;
                        foreach (var haikwanDetail in haikwanDetailList)
                        {
                            if (haikwanDetail.BsonType == BsonType.Null) continue;
                            var haikwanDetailEntity = new HaikwanDetail()
                            {
                                Id = GuidHelper.GenerateComb().ToString(),
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
                        if (element.Value.BsonType != BsonType.Array) continue;

                        var multiPackageIds = element.Value.AsBsonArray;
                        foreach (var multiPackageId in multiPackageIds)
                        {
                            if (multiPackageId.BsonType == BsonType.Null) continue;
                            var multiPackageIdEntity = new OrderMultiPackageId()
                            {
                                Id = GuidHelper.GenerateComb().ToString(),
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

                orderInsertData.Add(pgOrder);
            }

            _flytBIDbContext.BatchInsert(orderInsertData);
            _flytBIDbContext.BatchInsert(remarkInsertData);
            _flytBIDbContext.BatchInsert(orderDetailInsertData);
            _flytBIDbContext.BatchInsert(apiOrderIdInsertData);
            _flytBIDbContext.BatchInsert(salesPlatformTranscationIdInsertData);
            _flytBIDbContext.BatchInsert(salesRecordNumberInsetData);
            _flytBIDbContext.BatchInsert(multiPackageIdInsertData);
            _flytBIDbContext.BatchInsert(haikwanDetailInsertData);
        }
    }
}
