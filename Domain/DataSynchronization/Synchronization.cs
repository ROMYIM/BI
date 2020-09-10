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
        private const int MoreThreadsToInsertDataCount = 1_000_000;

        protected readonly ILogger _logger;

        protected readonly MongoDbContext _mongoDbContext;

        protected FlytBIDbContext _flytBIDbContext;

        protected readonly IServiceProvider _serviceProvider;

        protected IServiceScope _serviceScope;

        protected static readonly string TableName;

        public CancellationTokenSource TokenSource { get; }

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
            TokenSource = new CancellationTokenSource();
        }

        public virtual Task SynchronizeDataAsync(int startIndex, int synchronizeCountPerTime)
        {
            Initialize();

            var token = TokenSource.Token;
            return Task.Factory.StartNew(async () =>
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

                    _logger.LogInformation("总数量：{}", totalCount);
                    _logger.LogInformation("导入中");

                    ///如果数据量大于阈值（暂定一千万）就开启多线程同步
                    if (totalCount >= MoreThreadsToInsertDataCount)
                    {
                        
                        var synchronizeCountPerTask = MoreThreadsToInsertDataCount;
                        var taskCount = totalCount / synchronizeCountPerTask;

                        for (int i = 0; i < taskCount; i++)
                        {
                            if (CheckCancellRequested(startIndex)) return;

                            await Task.Factory.StartNew(() =>
                            {
                                _logger.LogInformation("线程id：{}", Thread.CurrentThread.ManagedThreadId);

                                for (int j = 0; j < synchronizeCountPerTask; j += synchronizeCountPerTime, startIndex += synchronizeCountPerTime)
                                {
                                    if (CheckCancellRequested(startIndex)) return;

                                    _logger.LogInformation("更新索引：{}", startIndex);
                                    DoSynchronize(collection, startIndex, synchronizeCountPerTime);
                                }
                            }, token, TaskCreationOptions.LongRunning, TaskScheduler.Default);

                            await Task.Delay(TimeSpan.FromSeconds(5));
                        }
                    }
                    else
                    {

                        for (int j = 0; j < totalCount; j += synchronizeCountPerTime, startIndex += synchronizeCountPerTime)
                        {
                            if (CheckCancellRequested(startIndex)) return;

                            _logger.LogInformation("更新索引：{}", startIndex);
                            DoSynchronize(collection, startIndex, synchronizeCountPerTime);
                        }
                    }
                   

                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                    _logger.LogError(ex.StackTrace);
                }
                finally { Dispose(); }
            }, token, TaskCreationOptions.LongRunning, TaskScheduler.Default);

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

        protected virtual bool CheckCancellRequested(int currentIndex)
        {
            if (TokenSource.Token.IsCancellationRequested)
            {
                _logger.LogInformation("任务被手动终止");
                _logger.LogInformation("当前索引：{}", currentIndex);
                return true;
            }

            return false;
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
