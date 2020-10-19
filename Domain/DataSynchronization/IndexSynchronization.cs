using Core.DataBase.Mongo;
using Core.Extensions.Database.Query;
using Domain.DataSynchronization.Abstract;
using Infrastructure.Db.Contexts;
using Infrastructure.Exceptions;
using Infrastructure.Helpers;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.DataSynchronization
{
    public class IndexSynchronization<TPg> : IIndexSynchronization<TPg> where TPg : new()
    {
        private string _mongoTable;

        protected readonly ILogger _logger;

        protected readonly Stopwatch _stopwatch;

        protected readonly MongoDbContext _mongoDbContext;

        protected readonly CancellationTokenSource _tokenSource;

        protected readonly FlytBIDbContext _flytBIDbContext;

        string ISynchronization.MongoTable
        {
            get => _mongoTable;
            set
            {
                if (string.IsNullOrWhiteSpace(_mongoTable))
                    _mongoTable = value;
                else throw new InvalidOperationException("表名已经赋值，不能再赋值");
            }
        }

        CancellationTokenSource ISynchronization.TokenSource => _tokenSource;

        public IndexSynchronization(
            ILoggerFactory loggerFactory,
            MongoDbContext mongoDbContext,
            FlytBIDbContext flytBIDbContext)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _mongoDbContext = mongoDbContext;
            _flytBIDbContext = flytBIDbContext;
            _stopwatch = new Stopwatch();
            _tokenSource = new CancellationTokenSource();
        }

        public async Task<(ulong deleteCount, ulong insertCount)> SynchronizeDataAsync(int startIndex, int synchronizeCountPerTime, int? synchornizationCount = null)
        {
            var clearTask = _flytBIDbContext.BatchDeleteAsync<TPg>();

            var collection = _mongoDbContext.Collection(_mongoTable);
            var totalCount = await collection.EstimatedDocumentCountAsync();

            var insertCount = default(ulong);
            var deleteCount = default(ulong);

            var asyncCursor = await collection.FindDocumentsCursorAsync(default, batchSize: 2000);
            while (await asyncCursor.MoveNextAsync())
            {
                var documents = asyncCursor.Current;
                var mongoErrors = new List<(BsonValue, string)>(documents.Count());
                var insertData = new List<TPg>(documents.Count());

                BsonValue id = null;
                try
                {
                    /// 查询并转换为pg实体
                    foreach (var document in documents)
                    {

                        var pgEntity = new TPg();
                        var properties = pgEntity.GetType().GetProperties();

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
                    throw new DataSynchronizationException(id, _mongoTable, ex);
                }

                deleteCount += await clearTask;
                insertCount += await _flytBIDbContext.BatchInsertAsync(insertData);
            }

            return (deleteCount, insertCount);
        }
    }
}
