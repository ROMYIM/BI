using Core.DataBase.Mongo;
using Core.Extensions.Database.Query;
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
using System.Text;
using System.Threading.Tasks;
using MongoTranferRoute = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferRoute;
using PgTransferRoute = Infrastructure.Db.Dtoes.Pg.TransferRoute;

namespace Domain.DataSynchronization
{
    public class TransferRouteSynchronization : Synchronization<MongoTranferRoute, PgTransferRoute>
    {
        public TransferRouteSynchronization(
            MongoDbContext mongoDbContext, 
            ILoggerFactory loggerFactory, 
            IServiceProvider serviceProvider) 
            : base(mongoDbContext, loggerFactory, serviceProvider)
        {
        }

        protected override string UtcModifyTime => "UpdateTime";

        protected override async Task<ulong> DoSynchronizeAsync(IMongoCollection<BsonDocument> collection, int startIndex, int synchronizeCount)
        {
            _findOptions.BatchSize = synchronizeCount;
            _findOptions.Skip = startIndex;

            var syncCount = default(ulong);

            var transferRouteInsertData = new LinkedList<PgTransferRoute>();
            var postTypeIdInsertData = new LinkedList<TransferRoutePostTypeId>();
            var customerIdInsertData = new LinkedList<TransferRouteCustomerId>();

            using var asyncCursor = await collection.FindDocumentsCursorAsync(default, _findOptions);
            while (await asyncCursor.MoveNextAsync())
            {
                var documents = asyncCursor.Current;
                if (!documents.Any()) continue;

                _stopwatch.Restart();
                foreach (var document in documents)
                {

                    var transferRoute = new PgTransferRoute();
                    var orderType = transferRoute.GetType();
                    var properties = orderType.GetProperties();

                    ///优先构建主键的属性
                    var idElement = document.GetElement("_id");
                    string routeId = idElement.GetValue(typeof(string)).ToString();
                    var idProperty = orderType.GetProperty("Id");
                    idProperty?.SetValue(transferRoute, routeId);

                    try
                    {
                        foreach (var element in document.Elements)
                        {

                            if (element.Name == "_id") continue;
                            else if (element.Name == "PostTypeId")
                            {
                                if (!element.Value.IsBsonArray) continue;

                                var postTypeIds = element.Value.AsBsonArray;
                                foreach (var postTypeId in postTypeIds)
                                {
                                    if (postTypeId.IsBsonNull) continue;
                                    var postTypeIdEntity = new TransferRoutePostTypeId()
                                    {

                                        PostTypeId = postTypeId.AsString,
                                        TransferRouteId = routeId
                                    };
                                    postTypeIdInsertData.AddLast(postTypeIdEntity);
                                }
                            }
                            else if (element.Name == "CustomerId")
                            {
                                if (!element.Value.IsBsonArray) continue;

                                var customerIds = element.Value.AsBsonArray;
                                foreach (var customerId in customerIds)
                                {
                                    if (customerId.BsonType == BsonType.Null) continue;
                                    var customerIdEntity = new TransferRouteCustomerId()
                                    {

                                        CustomerId = customerId.AsString,
                                        TransferRouteId = routeId
                                    };
                                    customerIdInsertData.AddLast(customerIdEntity);
                                }
                            }
                            else
                            {
                                var property = orderType.GetProperty(element.Name);
                                property?.SetValue(transferRoute, element.GetValue(property.PropertyType));
                            }
                        }
                    }
                    catch (Exception ex) when (!(ex is DataSynchronizationException))
                    {
                        throw new DataSynchronizationException(routeId, TableName, ex);
                    }

                    transferRouteInsertData.AddLast(transferRoute);
                }
                _stopwatch.Stop();
                _logger.LogInformation("数据转换。耗时{}", _stopwatch.Elapsed.TotalSeconds);

                _stopwatch.Restart();
                var commitCount = await _flytBIDbContext.BatchInsertAsync(transferRouteInsertData);
                await _flytBIDbContext.BatchInsertAsync(postTypeIdInsertData);
                await _flytBIDbContext.BatchInsertAsync(customerIdInsertData);

                _stopwatch.Stop();
                _logger.LogInformation("数据插入。耗时{}", _stopwatch.Elapsed.TotalSeconds);

                #region 释放中间缓存数据

                transferRouteInsertData.Clear();
                postTypeIdInsertData.Clear();
                customerIdInsertData.Clear();

                #endregion

                syncCount += commitCount;
            }

            _logger.LogInformation("更新数据{}", syncCount);
            return syncCount;
        }
    }
}
