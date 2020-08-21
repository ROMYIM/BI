using Core.DataBase.Mongo;
using Infrastructure.Db.Contexts;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Schedule.Managers
{
    public class DataSynchornizationJob : IJob
    {
        private readonly MongoDbContext _mongoDbContext;

        private readonly FlytBIDbContext _flytBIDbContext;

        private readonly ILogger _logger;

        public DataSynchornizationJob(
            MongoDbContext mongoDbContext, 
            FlytBIDbContext flytBIDbContext, 
            ILoggerFactory loggerFactory)
        {
            _mongoDbContext = mongoDbContext;
            _flytBIDbContext = flytBIDbContext;
            _logger = loggerFactory.CreateLogger(GetType());
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("定时任务调度");
            return Task.CompletedTask;
        }
    }
}
