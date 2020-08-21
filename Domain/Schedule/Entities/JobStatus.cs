using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Domain.Schedule.Entities
{
    public enum JobStatus
    {
        [Description("初始化")]
        Init = 0,

        [Description("运行中")]
        Running = 1,

        [Description("调度中")]
        Scheduling = 2,

        [Description("已停止")]
        Stopped = 3,
    }
}
