using Core.DataBase.Mongo;
using Infrastructure.Schedule.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SharpCompress.Common.Tar;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class DataQueryService
    {
        private readonly ILogger _logger;

        private readonly MongoDbContext _mongoDbContext;

        public DataQueryService(
            ILoggerFactory loggerFactory, 
            MongoDbContext mongoDbContext,
            IOptionsMonitor<DataSynchronizationOptions> monitor)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _mongoDbContext = mongoDbContext;
        }

        
    }
}
