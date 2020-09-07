using AutoMapper;
using Core.DataBase.Mongo;
using Infrastructure.Db.Contexts;
using Infrastructure.Exceptions;
using Infrastructure.Helpers;
using Infrastructure.Schedule.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Npgsql;
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

        protected FlytBIDbContext _flytBIDbContext;

        protected readonly IServiceProvider _serviceProvider;

        protected IServiceScope _serviceScope;

        protected static readonly string TableName;

        static Synchronization()
        {
            TableName = typeof(TPgSQL).GetTableName();
        }

        public Synchronization(
            MongoDbContext mongoDbContext,
            ILoggerFactory loggerFactory,
            IServiceProvider serviceProvider)
        {
            _mongoDbContext = mongoDbContext;
            _serviceProvider = serviceProvider;
            _logger = loggerFactory.CreateLogger(GetType());
        }

        public virtual Task SynchronizeDataAsync(int startIndex, int synchronizeCountPerTime, CancellationToken token)
        {
            Initialize();
            return Task.Run(() =>
            {
                try
                {
                    _logger.LogInformation("开始导入{}数据", TableName);
                    _logger.LogInformation("{}", DateTime.Now);


                    ///获取mongo对应的表集合
                    var mongoDtoType = typeof(TMongo);
                    var collection = _mongoDbContext.Collection(mongoDtoType);

                    ///计算一个表数据要同步的次数
                    var totalCount = collection.Count() - startIndex;
                    if (synchronizeCountPerTime > totalCount) synchronizeCountPerTime = (int)totalCount;
                    var synchronizationTimes = totalCount % synchronizeCountPerTime == 0
                        ? totalCount / synchronizeCountPerTime : totalCount / synchronizeCountPerTime + 1;

                    _logger.LogInformation("总数量：{}", totalCount);
                    _logger.LogInformation("导入中");

                    ///同步数据
                    for (int i = 0; i < synchronizationTimes; i++, startIndex += synchronizeCountPerTime)
                    {
                        _logger.LogInformation("更新索引：{}", startIndex);
                        DoSynchronize(collection, startIndex, synchronizeCountPerTime);
                    }

                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                    _logger.LogError(ex.StackTrace);
                }
                finally { Dispose(); }
            });

        }


        protected virtual void DoSynchronize(MongoCollection<BsonDocument> collection, int startIndex, int synchronizeCount)
        {
            var documents = collection.FindAll().SetSkip(startIndex).SetLimit(synchronizeCount).ToList();
            var mongoErrors = new List<(BsonValue, string)>(documents.Count);
            var insertData = new List<TPgSQL>(documents.Count);

            BsonValue id = null;
            try
            {
                /// 查询并转换为pg实体
                foreach (var document in documents)
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

                }

                _flytBIDbContext.BatchInsert(insertData);
            }
            catch (Exception ex)
            {
                throw new DataSynchronizationException(id, TableName, ex);
            }

        }

        protected void Dispose()
        {
            _logger.LogInformation("释放资源");
            _logger.LogInformation("{}", DateTime.Now);
            _serviceScope.Dispose();
        }


        private void Initialize()
        {
            _logger.LogInformation("创建作用域前");

            _serviceScope = _serviceProvider.CreateScope();
            _flytBIDbContext = _serviceScope.ServiceProvider.GetRequiredService<FlytBIDbContext>();

            _logger.LogInformation("创建作用域后");
        }
    }
}
