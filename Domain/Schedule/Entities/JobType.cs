using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Schedule.Entities
{
    public enum JobType
    {
        [Description("数据同步")]
        DataSynchronization = 0
    }
}
