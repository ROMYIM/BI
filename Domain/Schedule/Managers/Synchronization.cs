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
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Schedule.Managers
{
    public class Synchronization<TMongo, TPgSQL> where TMongo : class, new() where TPgSQL : class, new()
    {
        private readonly ILogger _logger;

        private readonly IMapper _dtpMapper;

        private readonly MongoDbContext _mongoDbContext;

        private readonly FlytBIDbContext _flytBIDbContext;

        private readonly IOptionsMonitor<DataSynchronizationOptions> _synchronizationOpions;

        public Synchronization(
            MongoDbContext mongoDbContext,
            FlytBIDbContext flytBIDbContext,
            IMapper mapper,
            IOptionsMonitor<DataSynchronizationOptions> synchronizationOptions,
            ILoggerFactory loggerFactory)
        {
            _mongoDbContext = mongoDbContext;
            _flytBIDbContext = flytBIDbContext;
            _dtpMapper = mapper;
            _logger = loggerFactory.CreateLogger(GetType());
            _synchronizationOpions = synchronizationOptions;
        }

        public virtual void SynchronizeData(int synchronizeCountPerTime, CancellationToken token)
        {
            var mongoDatabase = _mongoDbContext.Database;
            var options = _synchronizationOpions.CurrentValue;

            try
            {
                foreach (var tableMapping in options.TableMappings)
                {
                    ///获取mongo对应的表集合
                    var mongoTable = tableMapping.Mongo;
                    var collection = _mongoDbContext.GetQueryable<TMongo>();

                    ///获取pg对应表实体类型
                    var pgTable = tableMapping.PgSql;
                    var pgEntityType = typeof(TPgSQL);

                    ///计算一个表数据要同步的次数
                    var startIndex = 0;
                    var totalCount = 1000;//  _mongoDbContext.Database.GetCollection(mongoTable).Count();
                    if (synchronizeCountPerTime > totalCount) synchronizeCountPerTime = (int)totalCount;
                    var synchronizationTimes = totalCount % synchronizeCountPerTime == 0
                        ? totalCount / synchronizeCountPerTime : totalCount / synchronizeCountPerTime + 1;

                    ///同步数据
                    for (int i = 0; i < synchronizationTimes; i++, startIndex += synchronizeCountPerTime)
                    {
                        var documents =

                            collection.Skip(startIndex).Take(synchronizeCountPerTime).ToList();
                        var errors = new List<(BsonValue, string)>(documents.Count);
                        var insertData = new List<TPgSQL>(documents.Count);
                   

                        /// 查询并转换为pg实体
                        foreach (var document in documents)
                        {
                            BsonValue id = null;
                            try
                            {
                                var pgData = _dtpMapper.Map<TMongo, TPgSQL>(document);
                                insertData.Add(pgData);

                                
                            }
                            catch (Exception ex)
                            {
                                _logger.LogError(ex.Message);
                                throw ex;
                            }

                        }

                        _flytBIDbContext.BatchInsert(insertData);

                        ///提交事务，打印同步失败的数据
                        //await _flytBIDbContext.SaveChangesAsync();
                        foreach (var error in errors)
                        {
                            _logger.LogError("id：{}\n异常：{}", error.Item1, error.Item2);
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                _logger.LogError(ex.StackTrace);
                throw;
            }

        }


        public virtual async Task SynchronizeDataAsync(int synchronizeCountPerTime, CancellationToken token)
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
                    var insertData = new List<TPgSQL>(documents.Count);
                    var pgErrors = default((string, string, string, string));

                    /// 查询并转换为pg实体
                    foreach (var document in documents)
                    {
                        BsonValue id = null;
                        try
                        {
                            var pgEntity = new TPgSQL();
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

                    _flytBIDbContext.BatchInsert(insertData);

                    foreach (var error in mongoErrors)
                    {
                        _logger.LogError("id：{}\n异常：{}", error.Item1, error.Item2);
                    }
                    _logger.LogError("table:{}  key:{}  field:{}  value:{}   message:{}", pgErrors.Item1, pgErrors.Item2, pgErrors.Item3, pgErrors.Item4);

                }

            }

        }

    }
}
