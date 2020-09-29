using Application.Services.DataSynchorization;
using Domain.Schedule.Entities;
using Infrastructure.Schedule.Service;
using Microsoft.Extensions.Logging;
using Quartz;
using Quartz.Spi;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Services.DataSynchonization
{
    public class DataSynchronizationService : IDataSynchorizationService
    {
        private const string SchedeName = "数据同步";

        private readonly ILogger _logger;

        private readonly ISchedulerFactory _schedulerFactory;

        private readonly IJobFactory _jobFactory;

        private readonly ScheduleJob _job;

        public IScheduler Scheduler { get; private set; }

        public DataSynchronizationService(
            ILoggerFactory loggerFactory, 
            ISchedulerFactory schedulerFactory,
            IJobFactory jobFactory,
            ScheduleJob job)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _schedulerFactory = schedulerFactory;
            _jobFactory = jobFactory;
            _job = job;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("服务启动");
            _logger.LogInformation(DateTime.Now.ToString("G"));

            var jobDetail = _job.GetJob();
            var trigger = _job.GetTrigger();

            Scheduler = await _schedulerFactory.GetScheduler(cancellationToken);
            Scheduler.JobFactory = _jobFactory;
            await Scheduler.ScheduleJob(jobDetail, trigger, cancellationToken);
            await Scheduler.Start(cancellationToken);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("服务关闭");
            if (Scheduler.IsStarted)
            {
                await Scheduler?.Shutdown(cancellationToken);
            }
        }

        async Task IScheduleService.RestartAsync(TimeSpan delaySpan, CancellationToken cancellationToken)
        {
            await StopAsync(cancellationToken);
            await Task.Delay(delaySpan);
            _ = StartAsync(cancellationToken);
        }

        Task IDataSynchorizationService.SynchronizeData(CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
