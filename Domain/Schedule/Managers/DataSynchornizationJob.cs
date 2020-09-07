using Core.DataBase.Mongo;
using Infrastructure.Caches;
using Infrastructure.Db.Contexts;
using Infrastructure.Db.Dtoes.Mongo.Bill;
using Infrastructure.Helpers;
using Infrastructure.Schedule.Job;
using Infrastructure.Schedule.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using Quartz;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Schedule.Managers
{
    public class DataSynchornizationJob : IDetailJob
    {
        private readonly ILogger _logger;

        private readonly PgDtoTypeCaches _pgDtoTypeCaches;

        private readonly MongoDbContext _mongoDbContext;

        private readonly FlytBIDbContext _flytBIDbContext;

        private readonly IOptionsMonitor<DataSynchronizationOptions> _synchronizationOpions;

        public DataSynchornizationJob(
            MongoDbContext mongoDbContext,
            FlytBIDbContext flytBIDbContext, 
            PgDtoTypeCaches pgDtoTypeCaches,
            IOptionsMonitor<DataSynchronizationOptions> synchronizationOptions,
            ILoggerFactory loggerFactory)
        {
            _mongoDbContext = mongoDbContext;
            _flytBIDbContext = flytBIDbContext;
            _logger = loggerFactory.CreateLogger(GetType());
            _synchronizationOpions = synchronizationOptions;
            _pgDtoTypeCaches = pgDtoTypeCaches;
        }

        IJobDetail IDetailJob.DetailInformation { get; set; }

        public async Task SynchronizeData(int synchronizeCountPerTime, CancellationToken token)
        {
            var mongoDatabase = _mongoDbContext.Database;
            var options = _synchronizationOpions.CurrentValue;

            foreach (var tableMapping in options.TableMappings)
            {
                ///获取mongo对应的表集合
                var mongoTable = tableMapping.Mongo;
                var collection = mongoDatabase.GetCollection(mongoTable);

                ///获取pg对应表实体类型
                var pgTable = tableMapping.PgSql;
                var pgEntityType = pgTable.GetDbEntityType();

                ///计算一个表数据要同步的次数
                var startIndex = 0;
                var totalCount = collection.Count();
                if (synchronizeCountPerTime > totalCount) synchronizeCountPerTime = (int)totalCount;
                var synchronizationTimes = totalCount % synchronizeCountPerTime == 0
                    ? totalCount / synchronizeCountPerTime : totalCount / synchronizeCountPerTime + 1;

                ///同步数据
                for (int i = 0; i < synchronizationTimes; i++, startIndex += synchronizeCountPerTime)
                {
                    var documents = collection.FindAll().SetSkip(startIndex).SetLimit(synchronizeCountPerTime).ToList();
                    var mongoErrors = new List<(BsonValue, string)>(documents.Count);
                    var insertData = new List<object>(documents.Count);
                    var pgErrors = default((string, string, string, string));

                    /// 查询并转换为pg实体
                    foreach (var document in documents)
                    {
                        BsonValue id = null;
                        try
                        {
                            var pgEntity = pgEntityType.GetConstructors()[0].Invoke(default);
                            var properties = pgEntityType.GetProperties();
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

                    if (_pgDtoTypeCaches.TryGetValue(pgEntityType, out var typeCache))
                        _flytBIDbContext.BatchInsert(insertData, typeCache);
                    else
                    {
                        _logger.LogError("没有读取到配置");
                        throw new ArgumentNullException("数据同步，无法读取配置到缓存中");
                    }

                    //foreach (var error in mongoErrors)
                    //{
                    //    _logger.LogError("id：{}\n异常：{}", error.Item1, error.Item2);
                    //}

                    //foreach (var error in pgErrors)
                    //{
                    //    _logger.LogError("table:{}  key:{}  field:{}  value:{}   message:{}", error.Item1, error.Item2, error.Item3, error.Item4, error.Item5);
                    //}

                }

            }

        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("定时任务调度");
            return Task.CompletedTask;
        }

        void IDisposable.Dispose()
        {
            _logger.LogInformation("定时任务释放资源");

            _flytBIDbContext?.Dispose();
        }
    }
}
