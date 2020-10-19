using Core.MessageQueues.Abractions;
using Domain.DataSynchronization;
using Domain.DataSynchronization.Abstract;
using Domain.DataSynchronization.Managers;
using Domain.Schedule.Entities;
using Domain.Schedule.Events;
using Infrastructure.Db.Dtoes.Pg;
using Infrastructure.Schedule.Factroy;
using Infrastructure.Schedule.Job;
using Infrastructure.Schedule.MessaageQueues;
using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScheduleJob = Domain.Schedule.Entities.ScheduleJob;

namespace FlytexpressBI.Extensions.DependencyInjection
{
    public static class ScheduleJobExtension
    {
        public static IServiceCollection AddScheduleJob(this IServiceCollection services)
        {
            services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();
            services.AddSingleton<IJobFactory, ScheduleJobFactory>();
            services.AddSingleton<IMessagQueue<JobKey, ScheduleJob>, JobDelayMsgQueue<ScheduleJob>>();

            services.AddScoped<IDetailJob<BaseDataSynchronizationManager<UserInfo>> ,BaseDataSynchronizationManager<UserInfo>>();
            services.AddScoped<IDetailJob, BaseDataSynchronizationManager<UserInfo>>();
            services.AddScoped<BaseDataSynchronizationManager<UserInfo>>(services =>
            {
                var eventHandlers = services.GetServices<IObserver<ScheduleJob>>();
                var service = services.GetRequiredService<BaseDataSynchronizationManager<UserInfo>>();
                foreach (var eventHandler in eventHandlers)
                {
                    service.Subscribe(eventHandler);
                }
                return service;
            });

            services.AddTransient<IIndexSynchronization<UserInfo>, IndexSynchronization<UserInfo>>();

            services.AddTransient<IObserver<ScheduleJob>, DelayUpdateSceduleJobHandler>();
            

            return services;
        }
    }
}
