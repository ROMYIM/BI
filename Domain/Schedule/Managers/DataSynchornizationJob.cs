using Core.DataBase.Mongo;
using Infrastructure.Db.Contexts;
using Infrastructure.Schedule.Job;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Schedule.Managers
{
    public class DataSynchornizationJob : IDetailJob
    {
        private readonly MongoDbContext _mongoDbContext;

        private readonly FlytBIDbContext _flytBIDbContext;

        private readonly ILogger _logger;

        public DataSynchornizationJob(
            MongoDbContext mongoDbContext,
            IDataSynchronizationDbContxt flytBIDbContext, 
            ILoggerFactory loggerFactory)
        {
            _mongoDbContext = mongoDbContext;
            _flytBIDbContext = flytBIDbContext as FlytBIDbContext;
            _logger = loggerFactory.CreateLogger(GetType());
        }

        IJobDetail IDetailJob.DetailInformation { get; set; }

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
