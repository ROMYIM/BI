using Core.Extensions.Annotation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Exceptions
{
    public class JobStragtegyException : ApplicationException
    {
        private readonly string _message;

        public override string Message => _message;

        public JobStragtegyException(StragetySetting setting, string detailMessage)
        {
            var description = setting.GetDescription();
            _message = $"{description}设置错误：{detailMessage}";
        }
    }

    public enum StragetySetting
    {
        [Description("开始时间")]
        StartTime,

        [Description("结束时间")]
        EndTime,

        [Description("执行周期")]
        Period
    }
}
