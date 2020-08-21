using Core.Domain.Entity;
using Domain.Schedule.Managers;
using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Schedule.Entities
{
    public class ScheduleJob : IAggregateRoot<int>
    {
        public int Id { get; set; }

        public DateTime CreationTime { get; set; }

        public string JobName { get; set; }

        public JobStatus Status { get; set; }

        public JobType Type { get; set; }

        public string CronExpression { get; set; }

        private IJobDetail _jobDetail;

        private ITrigger _trigger;

        public IJobDetail GetJob()
        {

            return _jobDetail ??= JobBuilder.Create(Type.GetJobType())
                .WithIdentity(JobKey.Create(JobName))
                .WithDescription("数据库同步")
                .Build();
        }

        public ITrigger GetTrigger()
        {
            return _trigger ??= TriggerBuilder.Create()
                .ForJob(JobKey.Create(JobName))
                .WithIdentity(JobName)
                .WithCronSchedule(CronExpression)
                .Build();
        }
    }
}
