using System;
using System.Collections.Generic;
using System.Text;

namespace Core.MessageQueues.Abractions
{
    public interface IMessageConsumer<T> : IObserver<IMessageSource<T>>
    {
    }
}
