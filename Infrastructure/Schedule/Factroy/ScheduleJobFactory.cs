using Infrastructure.Schedule.Job;
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

        private readonly ConcurrentDictionary<JobKey, IServiceScope> _jobScopes;

        public ScheduleJobFactory(IServiceProvider serviceProvider, ILoggerFactory loggerFactory)
        {
            _container = serviceProvider;
            _jobScopes = new ConcurrentDictionary<JobKey, IServiceScope>();
            _logger = loggerFactory.CreateLogger(GetType());
        }

        public IJob NewJob(TriggerFiredBundle bundle, IScheduler scheduler)
        {
            //var jobKey = bundle.JobDetail.Key;
            //if (!_jobScopes.TryGetValue(jobKey, out var scope))
            //{
            //    scope = _container.CreateScope();
            //    _jobScopes.TryAdd(jobKey, scope);
            //}

            //var job = scope.ServiceProvider.GetRequiredService(bundle.JobDetail.JobType) as IDetailJob;
            //job.DetailInformation = bundle.JobDetail;


            _logger.LogDebug("任务开始。{}", DateTime.Now.ToString("G"));
            return _container.GetRequiredService(bundle.JobDetail.JobType) as IJob;
        }

        public void ReturnJob(IJob job)
        {
            //if (job is IDetailJob scopedJob && _jobScopes.TryRemove(scopedJob.DetailInformation.Key, out var scope))
            //{
            //    scope.Dispose();
            //}
            _logger.LogDebug("任务结束。{}", DateTime.Now.ToString("G"));
        }

    }
}
