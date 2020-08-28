using AutoMapper;
using Core.DataBase.Mongo;
using Infrastructure.Db.Contexts;
using Infrastructure.Helpers;
using Infrastructure.Schedule.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.DataSynchronization.Managers
{
    public abstract class Synchronization<TMongo, TPgSQL> where TMongo : class, new() where TPgSQL : class, new()
    {
        protected readonly ILogger _logger;

        protected readonly MongoDbContext _mongoDbContext;

        protected readonly FlytBIDbContext _flytBIDbContext;

        public Synchronization(
            MongoDbContext mongoDbContext,
            FlytBIDbContext flytBIDbContext,
            ILoggerFactory loggerFactory)
        {
            _mongoDbContext = mongoDbContext;
            _flytBIDbContext = flytBIDbContext;
            _logger = loggerFactory.CreateLogger(GetType());
        }


        protected virtual async Task DoSynchronizeAsync(MongoCollection<BsonDocument> collection, int startIndex, int synchronizeCount)
        {
            var documents = collection.FindAll().SetSkip(startIndex).SetLimit(synchronizeCount).ToList();
            var mongoErrors = new List<(BsonValue, string)>(documents.Count);
            var insertData = new List<TPgSQL>(documents.Count);
            ICollection<(string, string, string, object, string)> pgErrors = new List<(string, string, string, object, string)>(insertData.Count);

            /// 查询并转换为pg实体
            foreach (var document in documents)
            {
                BsonValue id = null;
                try
                {
                    var pgEntity = new TPgSQL();
                    var properties = typeof(TPgSQL).GetProperties();
                    foreach (var element in document.Elements)
                    {
                        if (element.Name == "_id")
                        {
                            id = element.Value;
                            var idProperty = properties.Where(p => p.Name == "Id").First();
                            idProperty.SetValue(pgEntity, element.GetValue(idProperty.PropertyType));
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
                    mongoErrors.Add((id, ex.Message));
                    continue;
                }

            }

            _flytBIDbContext.BatchInsert(insertData, ref pgErrors);

            foreach (var error in mongoErrors)
            {
                _logger.LogError("id：{}\n异常：{}", error.Item1, error.Item2);
            }

            foreach (var error in pgErrors)
            {
                _logger.LogError("table:{}  key:{}  field:{}  value:{}   message:{}", error.Item1, error.Item2, error.Item3, error.Item4, error.Item5);
            }
        }

        public virtual async Task SynchronizeDataAsync(int startIndex, int synchronizeCountPerTime, CancellationToken token)
        {
            var mongoDatabase = _mongoDbContext.Database;

            ///获取mongo对应的表集合
            var mongtoEntityType = typeof(TMongo);
            var mongoTable = mongtoEntityType.GetTableName();
            var collection = mongoDatabase.GetCollection(mongoTable);

            ///获取pg对应表实体类型
            var pgEntityType = typeof(TPgSQL);
            var pgTable = pgEntityType.GetTableName();

            ///计算一个表数据要同步的次数
            var totalCount = collection.Count();
            if (synchronizeCountPerTime > totalCount) synchronizeCountPerTime = (int)totalCount;
            var synchronizationTimes = totalCount % synchronizeCountPerTime == 0
                ? totalCount / synchronizeCountPerTime : totalCount / synchronizeCountPerTime + 1;

            ///同步数据
            for (int i = 0; i < synchronizationTimes; i++, startIndex += synchronizeCountPerTime)
            {
                #region 注释测试代码

                //var documents = collection.FindAll().SetSkip(startIndex).SetLimit(synchronizeCountPerTime).ToList();
                //var mongoErrors = new List<(BsonValue, string)>(documents.Count);
                //var insertData = new List<TPgSQL>(documents.Count);
                //var pgErrors = new List<(string, string, string, object, string)>(insertData.Count);

                ///// 查询并转换为pg实体
                //foreach (var document in documents)
                //{
                //    BsonValue id = null;
                //    try
                //    {
                //        var pgEntity = new TPgSQL();
                //        var properties = pgEntityType.GetProperties();
                //        foreach (var element in document.Elements)
                //        {
                //            if (element.Name == "_id")
                //            {
                //                id = element.Value;
                //                var idProperty = properties.Where(p => p.Name == "Id").First();
                //                idProperty.SetValue(pgEntity, element.GetValue(idProperty.PropertyType));
                //            }
                //            else
                //            {
                //                var property = properties.Where(p => p.Name.ToLower() == element.Name.ToLower()).FirstOrDefault();
                //                property?.SetValue(pgEntity, element.GetValue(property.PropertyType));
                //            }
                //        }
                //        insertData.Add(pgEntity);
                //        //await _flytBIDbContext.AddAsync(pgEntity);
                //    }
                //    catch (Exception ex)
                //    {
                //        mongoErrors.Add((id, ex.Message));
                //        continue;
                //    }

                //}

                //_flytBIDbContext.BatchInsert(insertData, ref pgErrors);

                //foreach (var error in mongoErrors)
                //{
                //    _logger.LogError("id：{}\n异常：{}", error.Item1, error.Item2);
                //}

                //foreach (var error in pgErrors)
                //{
                //    _logger.LogError("table:{}  key:{}  field:{}  value:{}   message:{}", error.Item1, error.Item2, error.Item3, error.Item4, error.Item5);
                //}

                #endregion

                await DoSynchronizeAsync(collection, startIndex, synchronizeCountPerTime);
            }

        }

    }
}
