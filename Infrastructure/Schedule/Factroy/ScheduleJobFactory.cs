using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Quartz;
using Quartz.Spi;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Schedule.Factroy
{
    public class ScheduleJobFactory : IJobFactory
    {
        private readonly IServiceProvider _container;

        private readonly ILogger _logger;

        private readonly ConcurrentDictionary<JobKey, IServiceScope> _scopes;

        public ScheduleJobFactory(IServiceProvider serviceProvider, ILoggerFactory loggerFactory)
        {
            _container = serviceProvider;
            _scopes = new ConcurrentDictionary<JobKey, IServiceScope>();
            _logger = loggerFactory.CreateLogger(GetType());
        }

        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            var jobKey = bundle.JobDetail.Key;
            if (!_scopes.TryGetValue(jobKey, out var scope))
            {
                scope = _container.CreateScope();
                _scopes.TryAdd(jobKey, scope);
            }
            return scope.ServiceProvider.GetRequiredService(bundle.JobDetail.JobType) as IJob;
        }

        public void ReturnJob(IJob job)
        {
            _logger.LogInformation("任务结束。");
        }

    }
}
