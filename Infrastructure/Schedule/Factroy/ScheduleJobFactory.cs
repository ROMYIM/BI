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

        private readonly ConcurrentDictionary<JobKey, IJob> _jobs;

        public ScheduleJobFactory(IServiceProvider serviceProvider, ILoggerFactory loggerFactory)
        {
            _container = serviceProvider;
            _jobs = new ConcurrentDictionary<JobKey, IJob>();
            _logger = loggerFactory.CreateLogger(GetType());
        }

        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            if (_jobs.TryGetValue(bundle.JobDetail.Key, out var job)) return job;
            else
            {
                job =  _container.GetRequiredService(bundle.JobDetail.JobType) as IJob;
                if (job != null) return job;
                else throw new NullReferenceException("任务没有注册");
            }
        }

        public void ReturnJob(IJob job)
        {
            _logger.LogInformation("任务返回工厂。不知道有什么实际意义");
        }
    }
}
