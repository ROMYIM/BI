using Quartz;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Schedule.Job
{
    public interface IScheduleJob : IJob, IDisposable
    {
        public Type GetJobType()
        {
            return GetType();
        }
    }

    public interface IScheduleJob<T> : IScheduleJob { }
}
