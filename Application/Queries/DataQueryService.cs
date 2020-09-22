using Core.DataBase.Mongo;
using Infrastructure.Schedule.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using SharpCompress.Common.Tar;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class DataQueryService
    {
        private readonly ILogger _logger;

        private readonly Stopwatch _stopwatch;

        private readonly MongoDbContext _mongoDbContext;

        public DataQueryService(
            ILoggerFactory loggerFactory, 
            MongoDbContext mongoDbContext)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _mongoDbContext = mongoDbContext;
            _stopwatch = new Stopwatch();
        }

        public virtual async Task<IReadOnlyCollection<BsonDocument>> GetMongoDocumentsAsync<TMongo>(Expression<Func<BsonDocument, bool>> query, int batchSize = 1000, int? skip = null, int? limit = null)
        {
            if (query == null) throw new ArgumentNullException(nameof(query));

            var collection = _mongoDbContext.Collection(typeof(TMongo));
            var findOptions = new FindOptions<BsonDocument>
            {
                Skip = skip,
                Limit = limit,
            };

            var totalCount = await collection.CountDocumentsAsync(query);
            if (totalCount > batchSize)
                findOptions.BatchSize = batchSize;
            else
                findOptions.BatchSize = (int) totalCount;

            _stopwatch.Restart();
            var asyncCursor = await collection.FindAsync(filter: query, options: findOptions);
            var documents = asyncCursor.ToList();
            _stopwatch.Stop();
            _logger.LogInformation("mongo库查询。数量{}。耗时{}", documents.Count, _stopwatch.Elapsed.TotalSeconds);
            return documents;
        }
    }
}
