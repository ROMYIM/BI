using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Exceptions
{
    public class JobStatusException : ApplicationException
    {
        private readonly string _message;

        public string Status { get; }

        public override string Message => _message;

        public JobStatusException(string statusDescription) 
        {
            Status = statusDescription;
            _message = $"当前任务状态为【{Status}】";
        }

        public JobStatusException(string statusDescription, string toChangeStatusDescription)
        {
            Status = statusDescription;
            _message = $"当前任务状态为【{Status}】，不能更改为【{toChangeStatusDescription}】";
        }
    }
}
