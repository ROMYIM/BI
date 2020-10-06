using Core.DataBase.Mongo;
using Core.Extensions.Database.Query;
using Domain.DataSynchronization.Abstract;
using Infrastructure.Db.Contexts;
using Infrastructure.Exceptions;
using Infrastructure.Helpers;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.DataSynchronization.Managers
{
    public class Synchronization<TMongo, TPgSQL> 
        : ITimeSynchronization<TMongo, TPgSQL>, IIndexSynchronization<TMongo, TPgSQL> 
        where TMongo : class, new() where TPgSQL : class, new()
    {

        #region 字段
        protected readonly ILogger _logger;

        protected readonly Stopwatch _stopwatch;

        protected readonly MongoDbContext _mongoDbContext;

        protected FlytBIDbContext _flytBIDbContext;

        protected readonly IServiceProvider _serviceProvider;

        protected IServiceScope _serviceScope;

        protected FindOptions<BsonDocument> _findOptions;

        protected static readonly string TableName;

        #endregion

        public CancellationTokenSource TokenSource { get; }

        protected virtual string UtcModifyTime { get => "UtcModifyTime"; }

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
            _stopwatch = new Stopwatch();
            _findOptions = new FindOptions<BsonDocument>
            {
                BatchSize = 2000,
                Sort = new SortDefinitionBuilder<BsonDocument>().Ascending(d => d[UtcModifyTime])
            };
        }

        public virtual Task SynchronizeDataAsync(DateTime startTime, TimeSpan synchronizeDuration, DateTime endTime = default)
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

                    ///结束时间
                    if (endTime == default) endTime = DateTime.UtcNow.Date;

                    ///计算一个表数据要同步的次数
                    var totalCount = await collection.EstimatedDocumentCountAsync();

                    _logger.LogInformation("总数量：{}", totalCount);
                    _logger.LogInformation("导入中");

                    for (; startTime < endTime; startTime += synchronizeDuration)
                    {
                        //if (CheckCancellRequested(startIndex)) return;

                        _logger.LogInformation("更新索引：{}", startTime);
                        await DoSynchronizeAsync(collection, startTime, synchronizeDuration);
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

        public virtual Task SynchronizeDataAsync(int startIndex, int synchronizeCountPerTime, int? synchornizationCount = default)
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
                    var totalCount = (synchornizationCount == null ? await collection.EstimatedDocumentCountAsync() : synchornizationCount.Value) - startIndex;
                    if (synchronizeCountPerTime > totalCount) synchronizeCountPerTime = (int)totalCount;

                    _logger.LogInformation("总数量：{}", totalCount);
                    _logger.LogInformation("导入中");

                    for (int j = 0; j < totalCount; j += synchronizeCountPerTime, startIndex += synchronizeCountPerTime)
                    {
                        if (CheckCancellRequested()) return;

                        _logger.LogInformation("更新索引：{}", startIndex);
                        await DoSynchronizeAsync(collection, startIndex, synchronizeCountPerTime);
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

        /// <summary>
        /// 一般普通数据表的同步
        /// </summary>
        /// <param name="collection">文档集合</param>
        /// <param name="synchronizeTime">开始同步历史数据的时间</param>
        /// <param name="synchronizeDuration">历史数据的时长</param>
        /// <returns>同步数量</returns>
        protected virtual async Task<ulong> DoSynchronizeAsync(IMongoCollection<BsonDocument> collection, DateTime synchronizeTime, TimeSpan synchronizeDuration)
        {
            var syncCount = default(ulong);

            using var asyncCursor = await collection.FindDocumentsCursorAsync(
                document => document[UtcModifyTime] >= synchronizeTime && document[UtcModifyTime] <= synchronizeTime + synchronizeDuration, batchSize: 3000);
            while (await asyncCursor.MoveNextAsync())
            {
                var documents = asyncCursor.Current;
                var mongoErrors = new LinkedList<(BsonValue, string)>();
                var insertData = new LinkedList<TPgSQL>();

                BsonValue id = null;
                try
                {
                    /// 查询并转换为pg实体
                    foreach (var document in documents)
                    {

                        var pgEntity = new TPgSQL();
                        var properties = typeof(TPgSQL).GetProperties();

                        ///优先构建主键属性
                        var idElement = document.Elements.Where(d => d.Name == "_id").First();
                        id = idElement.Value;
                        var idProperty = properties.Where(p => p.Name == "Id").First();
                        idProperty.SetValue(pgEntity, idElement.GetValue(idProperty.PropertyType));

                        ///构建其他属性
                        foreach (var element in document.Elements)
                        {
                            var property = properties.Where(p => p.Name.ToLower() == element.Name.ToLower()).FirstOrDefault();
                            property?.SetValue(pgEntity, element.GetValue(property.PropertyType));
                        }
                        insertData.AddLast(pgEntity);

                    }

                    var commitCount = await _flytBIDbContext.BatchInsertAsync(insertData);
                    syncCount += commitCount;
                }
                catch (Exception ex)
                {
                    throw new DataSynchronizationException(id, TableName, ex);
                }

            }

            _logger.LogInformation("更新数量{}", syncCount);
            return syncCount;
        }

        protected virtual async Task<ulong> DoSynchronizeAsync(IMongoCollection<BsonDocument> collection, int startIndex, int synchronizeCount)
        {
            _findOptions.BatchSize = synchronizeCount;
            _findOptions.Skip = startIndex;
            _findOptions.Limit = synchronizeCount;
            _findOptions.Sort = default;

            var syncCount = default(ulong);

            var asyncCursor = await collection.FindDocumentsCursorAsync(default, _findOptions);
            while (await asyncCursor.MoveNextAsync())
            {
                var documents = asyncCursor.Current;
                var mongoErrors = new List<(BsonValue, string)>(documents.Count());
                var insertData = new List<TPgSQL>(documents.Count());

                BsonValue id = null;
                try
                {
                    /// 查询并转换为pg实体
                    foreach (var document in documents)
                    {

                        var pgEntity = new TPgSQL();
                        var properties = typeof(TPgSQL).GetProperties();

                        ///优先构建主键属性
                        var idElement = document.Elements.Where(d => d.Name == "_id").First();
                        id = idElement.Value;
                        var idProperty = properties.Where(p => p.Name == "Id").First();
                        idProperty.SetValue(pgEntity, idElement.GetValue(idProperty.PropertyType));

                        foreach (var element in document.Elements)
                        {
                            var property = properties.Where(p => p.Name.ToLower() == element.Name.ToLower()).FirstOrDefault();
                            property?.SetValue(pgEntity, element.GetValue(property.PropertyType));
                        }
                        insertData.Add(pgEntity);

                    }
                }
                catch (Exception ex)
                {
                    throw new DataSynchronizationException(id, TableName, ex);
                }
            

                syncCount += await _flytBIDbContext.BatchInsertAsync(insertData);
            }

            return syncCount;
        }

        /// <summary>
        /// 根据时间段返回文档型的数据。
        /// 慎用。如果返回的文档数据过多会占用极高的内存。
        /// 推荐使用<see cref="MongoExtension.FindDocumentsCursorAsync(IMongoCollection{BsonDocument}, Expression{Func{BsonDocument, bool}}, int, int?, int?)"/>
        /// </summary>
        /// <param name="collection">表集合</param>
        /// <param name="startTime">开始时间</param>
        /// <param name="duration">时长</param>
        /// <returns>只读文档集合</returns>
        [Obsolete("一次性返回文档数量会占用过多的内存", false)]
        protected async ValueTask<IReadOnlyCollection<BsonDocument>> GetMongoDocumentsByDuration(IMongoCollection<BsonDocument> collection, DateTime startTime, TimeSpan duration)
        {
            Expression<Func<BsonDocument, bool>> query = b => b[UtcModifyTime] >= startTime && b[UtcModifyTime] <= startTime + duration;

            _stopwatch.Restart();
            var documents = await collection.FindDocumentsAsync(query);
            _stopwatch.Stop();
            _logger.LogInformation("mongo库查询。数量{}。耗时{}", documents.Count, _stopwatch.Elapsed.TotalSeconds);
            return documents;
        }

        protected virtual bool CheckCancellRequested()
        {
            if (TokenSource.Token.IsCancellationRequested)
            {
                _logger.LogInformation("任务被手动终止");
                return true;
            }

            return false;
        }

        /// <summary>
        /// 根据时间给出表名的后缀
        /// 按两个月一分。1、3、5、7、9、11月
        /// 示例：<code>{表名}_202001</code><code>{表名}_202003</code>
        /// </summary>
        /// <param name="time">时间</param>
        /// <returns>表名后缀</returns>
        protected virtual string GetTableSuffix(DateTime time = default)
        {
            if (time == default) return string.Empty;

            var year = time.Year.ToString("D4");
            var month = (time.Month % 2 == 0 ? time.Month - 1 : time.Month).ToString("D2");
            return year + month;
        }

        protected void Dispose()
        {
            _logger.LogInformation("释放资源");
            _logger.LogInformation("{}", DateTime.Now);
            _serviceScope.Dispose();
        }


        private void Initialize()
        {
            _serviceScope = _serviceProvider.CreateScope();
            _flytBIDbContext = _serviceScope.ServiceProvider.GetRequiredService<FlytBIDbContext>();
        }

    }
}
