using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Extensions.Database.Query
{
    public static class MongoExtension
    {

        public static async Task<IReadOnlyCollection<BsonDocument>> FindDocumentsAsync(this IMongoCollection<BsonDocument> collection, Expression<Func<BsonDocument, bool>> query, int batchSize = 1000, int? skip = null, int? limit = null)
        {
            var documents = (await FindDocumentsCursorAsync(collection, query, batchSize, skip, limit)).ToList();
            return documents;
        }

        public static Task<IAsyncCursor<BsonDocument>> FindDocumentsCursorAsync(this IMongoCollection<BsonDocument> collection, Expression<Func<BsonDocument, bool>> query, int batchSize = 1000, int? skip = null, int? limit = null)
        {

            var findOptions = new FindOptions<BsonDocument>
            {
                Skip = skip,
                Limit = limit,
                BatchSize = batchSize
            };

            return FindDocumentsCursorAsync(collection, query, findOptions);
        }

        /// <summary>
        /// 通过查询选项和查询条件查询mongo库。返回一个查询迭代器。
        /// 可以通过迭代器分批量迭代，避免一次性返回造成占用内存过高。
        /// </summary>
        /// <param name="collection">表集合</param>
        /// <param name="query">查询条件表达式</param>
        /// <param name="options">查询选项<see cref="FindOptions{TDocument}"/></param>
        /// <returns>查询迭代器</returns>
        public static async Task<IAsyncCursor<BsonDocument>> FindDocumentsCursorAsync(this IMongoCollection<BsonDocument> collection, Expression<Func<BsonDocument, bool>> query, FindOptions<BsonDocument> options = default)
        {

            if (options == default)
                options = new FindOptions<BsonDocument>
                {
                    BatchSize = 1000
                };

            IAsyncCursor<BsonDocument> asyncCursor;
            if (query == null)
                asyncCursor = await collection.FindAsync(filter: new FilterDefinitionBuilder<BsonDocument>().Empty, options: options);
            else
                asyncCursor = await collection.FindAsync(filter: query, options: options);

            return asyncCursor;
        }
    }
}

