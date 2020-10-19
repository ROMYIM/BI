using Core.DataBase.Mongo;
using Core.MessageQueues;
using Domain.DataSynchronization.Abstract;
using Domain.Schedule.Entities;
using Domain.Schedule.Repositories;
using Infrastructure.Schedule.Job;
using Microsoft.Extensions.Logging;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataSynchronization.Managers
{
    public class BaseDataSynchronizationManager<TPg> : IDetailJob<BaseDataSynchronizationManager<TPg>>, IObservable<ScheduleJob>
    {
        private readonly ILogger _logger;

        private readonly MongoDbContext _mongoContext;

        private readonly IScheduleJobRepository _jobRepository;

        private readonly IIndexSynchronization<TPg> _synchronization;

        private readonly ConcurrentDictionary<JobKey, ScheduleJob> _msgQueue;

        private readonly ICollection<IObserver<ScheduleJob>> _jobObservers;

        public BaseDataSynchronizationManager(
            ILoggerFactory loggerFactory,
            MongoDbContext mongoContext,
            IScheduleJobRepository jobRepository,
            ConcurrentDictionary<JobKey, ScheduleJob> msgQueue,
            IIndexSynchronization<TPg> synchronization)
        {
            _mongoContext = mongoContext;
            _jobRepository = jobRepository;
            _synchronization = synchronization;
            _msgQueue = msgQueue;
            _jobObservers = new List<IObserver<ScheduleJob>>();
            _logger = loggerFactory.CreateLogger(GetType());
        }

        public IJobDetail DetailInformation => new JobDetailImpl("BaseData", "Synchronization", ((IScheduleJob)this).GetJobType());

        public void Dispose()
        {
            _jobObservers.Clear();
        }

        public async Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("基础数据同步任务");

            var jobKey = DetailInformation.Key;
            var job = await _jobRepository.FirstOrDefaultAsync(jobKey);
            _synchronization.MongoTable = job.Table;

            job.Run();
            var updateCount = await _synchronization.SynchronizeDataAsync(0, 1000);
            job.Scheduling();

            if (_msgQueue.TryRemove(jobKey, out job))
            {
                foreach (var observer in _jobObservers)
                {
                    try
                    {
                        observer.OnNext(job);
                    }
                    catch (Exception ex)
                    {
                        observer.OnError(ex);

                    }
                    observer.OnCompleted();
                    
                }
            }
            
        }

        public IDisposable Subscribe(IObserver<ScheduleJob> observer)
        {
            _jobObservers.Add(observer);
            return this;
        }
    }
}
