using Core.MessageQueues.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.MessageQueues.Abractions
{
    public interface IMessagQueue<TKey, TMessage>
    {
        void ConsumeMessage(TKey msgKey, IEnumerable<IMessageConsumer<TMessage>> consumers);
    }
}
