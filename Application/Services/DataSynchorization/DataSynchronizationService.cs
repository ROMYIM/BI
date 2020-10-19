using Application.Services.DataSynchorization;
using Domain.Schedule.Entities;
using Domain.Schedule.Repositories;
using Infrastructure.Schedule.Job;
using Infrastructure.Schedule.Service;
using Microsoft.Extensions.Logging;
using Quartz;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Services.DataSynchonization
{
    public class DataSynchronizationService : IScheduleService
    {
        private readonly IEnumerable<IDetailJob> _jobs;

        private readonly IScheduleJobRepository _jobRepository;

        private readonly IExecutionStrategyRepository _strategyRepository;

        private readonly ILogger _logger;

        private readonly ISchedulerFactory _schedulerFactory;

        private readonly IJobFactory _jobFactory;

        public IScheduler Scheduler { get; private set; }

        public DataSynchronizationService(
            IEnumerable<IDetailJob> jobs,
            ILoggerFactory loggerFactory,
            IJobFactory jobFactory,
            ISchedulerFactory schedulerFactory,
            IScheduleJobRepository jobRepository,
            IExecutionStrategyRepository strategyRepository)
        {
            _logger = loggerFactory.CreateLogger(GetType());
            _schedulerFactory = schedulerFactory;
            _jobFactory = jobFactory;
            _jobs = jobs;
            _jobRepository = jobRepository;
            _strategyRepository = strategyRepository;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("服务启动");
            _logger.LogInformation(DateTime.Now.ToString("G"));

            Scheduler = await _schedulerFactory.GetScheduler(cancellationToken);
            Scheduler.JobFactory = _jobFactory;

            foreach (var job in _jobs)
            {
                var jobInfo = job.DetailInformation;
                var scheduleJob = await _jobRepository.FirstOrDefaultAsync(jobInfo.Key).ConfigureAwait(false);
                if (scheduleJob.GetReady())
                {
                    var strategy = await _strategyRepository.FirstOrDefaultAsync(scheduleJob.ExecutionStragtegyId).ConfigureAwait(false);
                    var trigger = strategy.GetTrigger();
                    await Scheduler.ScheduleJob(jobInfo, trigger, cancellationToken).ConfigureAwait(false);
                }
            }

            await Scheduler.Start(cancellationToken);

        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("服务关闭");
            if (Scheduler.IsStarted)
            {
                await Scheduler?.Shutdown(true, cancellationToken);
            }
        }

        async Task IScheduleService.RestartAsync(TimeSpan delaySpan, CancellationToken cancellationToken)
        {
            await StopAsync(cancellationToken);
            await Task.Delay(delaySpan);
            _ = StartAsync(cancellationToken);
        }
    }
}
