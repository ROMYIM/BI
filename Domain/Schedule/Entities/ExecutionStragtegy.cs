using Core.Domain.Entity;
using Infrastructure.Exceptions;
using Quartz;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Schedule.Entities
{
    public class ExecutionStrategy : AggregateRoot<string>
    {
        private readonly TriggerBuilder _triggerBuilder = TriggerBuilder.Create();

        public DateTime? StartTime { get; protected set; }

        public TimeSpan Period { get; protected set; }

        public DateTime? EndTime { get; protected set; }

        public uint ExcutionTimes { get; protected set; } = 1;

        public string Description { get; set; }

        internal ExecutionStrategy(
            string id, DateTime? startTime, DateTime? endTime,
            string description, TimeSpan period)
        {
            Id = id;
            StartTime = startTime;
            EndTime = endTime;
            Description = description;
            Period = period;
        }

        public void SetTime(TimeSpan period, DateTime? startTime = default, DateTime? endTime = default)
        {
            if (period < TimeSpan.FromMinutes(30)) throw new JobStragtegyException(StragetySetting.Period, "周期不能少于30分钟");

            if (VerifyStartTime(startTime)) StartTime = startTime;

            if (VerifyEndTime(endTime)) EndTime = endTime;
        }

        public ITrigger GetTrigger()
        {
            _triggerBuilder.WithIdentity(Id)
                .WithDescription(Description);

            if (StartTime != null && StartTime.Value > DateTime.Now) _triggerBuilder.StartAt(StartTime.Value);
            else _triggerBuilder.StartNow();

            if (VerifyEndTime(EndTime)) _triggerBuilder.EndAt(EndTime);

            _triggerBuilder.WithCalendarIntervalSchedule(builder =>
            {
                builder.WithInterval(Convert.ToInt32(Period.TotalMilliseconds), IntervalUnit.Millisecond);
            });

            return _triggerBuilder.Build();
        }

        private bool VerifyEndTime(DateTime? endTime)
        {
            if (StartTime != null && endTime != null && StartTime.Value < endTime.Value)
                return true;

            if (StartTime == null && endTime != null && DateTime.Now < endTime.Value)
                return true;

            else return false;
            
        }

        private bool VerifyStartTime(DateTime? startTime)
        {
            return startTime != null && startTime.Value > DateTime.Now;
        }
    }
}
