using Core.DataBase.Mongo;
using Infrastructure.Helpers;
using Microsoft.Extensions.Logging;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.TimingSynchronization
{
    public class DataTimingSynchronization<TMongo, TPgSQL> where TMongo : class, new() where TPgSQL : class, new()
    {
        protected static readonly string TableName = typeof(TPgSQL).GetTableName();

        protected readonly ILogger _logger;

        protected readonly MongoDbContext _mongoDbContext;

        public DataTimingSynchronization(
            ILoggerFactory loggerFactory,
            MongoDbContext mongoDbContext)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _mongoDbContext = mongoDbContext;
        }

        public virtual Task TimingSynchronizeDataAsnyc(CancellationToken token, TimeSpan timeInterval)
        {

            return Task.Run(() =>
            {
                var now = DateTime.Now;
                var beforeNow = now - timeInterval;

                _logger.LogInformation("开始同步{}数据", TableName);
                _logger.LogInformation("时间段{}~{}", beforeNow.ToString("G"), now.ToString("G"));

                var query = Query.And(Query.GTE("UtcCreateTime", beforeNow), Query.LTE("UtcCreateTime", now));
                var documents = _mongoDbContext.Collection(typeof(TMongo)).Find(query).SetBatchSize(1000).ToList();

                

            }, token);
        }

        protected virtual void DoNewDataSynchronization(DateTime startTime, DateTime endTime)
        {
            int synchronizeCountPerTime = 1000;

            var query = Query.And(Query.GTE("UtcCreateTime", startTime), Query.LTE("UtcCreateTime", endTime));
            var synchronizationCollection = _mongoDbContext.Collection(typeof(TMongo)).Find(query);

            var totalCount = synchronizationCollection.Count();
            if (synchronizeCountPerTime > totalCount) synchronizeCountPerTime = (int)totalCount;
        }
    }
}
