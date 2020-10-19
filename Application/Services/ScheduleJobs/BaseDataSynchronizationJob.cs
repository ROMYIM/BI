using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ScheduleJobs
{
    public class BaseDataSynchronizationJob : IJob
    {
        private readonly ILogger _logger;

        public BaseDataSynchronizationJob(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger(GetType());
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogDebug("定时任务运行中");
            return Task.CompletedTask;
        }
    }
}
