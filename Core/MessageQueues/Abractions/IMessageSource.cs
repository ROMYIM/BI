using Core.MessageQueues.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.MessageQueues.Abractions
{
    public interface IMessageSource<T>
    {
        Guid Id { get; set; }

        T Source { get; set; }

        DateTime ConsumeTime { get; set; }

        ConsumeOptions ConsumeOptions { get; set; }
    }
}
