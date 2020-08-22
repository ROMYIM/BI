
using Quartz;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Schedule.Job
{
    public interface IDetailJob : IJob, IDisposable
    {
        public IJobDetail DetailInformation { get; set; }
    }
}
