
using Quartz;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Schedule.Job
{
    public interface IDetailJob : IScheduleJob
    {
        public IJobDetail DetailInformation { get; }
    }

    public interface IDetailJob<T> : IScheduleJob<T>, IDetailJob { }
}
