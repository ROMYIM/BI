using Core.Domain.Entity.Abractions;
using Core.MessageQueues.Abractions;
using Core.MessageQueues.Options;
using Quartz;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Schedule.MessaageQueues
{
    public class JobDelayMsgQueue<TJobMessage> : IMessagQueue<JobKey, TJobMessage>
    {
        private readonly Dictionary<JobKey, ConcurrentQueue<IMessageSource<TJobMessage>>> _queues;

        public JobDelayMsgQueue()
        {
            _queues = new Dictionary<JobKey, ConcurrentQueue<IMessageSource<TJobMessage>>>();
        }

        public void ConsumeMessage(JobKey msgKey, IEnumerable<IMessageConsumer<TJobMessage>> consumers)
        {
            if (!(consumers?.Any() ?? false))
                return;

            if (_queues.TryGetValue(msgKey, out var queue))
            {
                while (queue?.Any() ?? false)
                {
                    if (queue.TryPeek(out var jobMessage))
                    {
                        switch (jobMessage.ConsumeOptions)
                        {
                            case ConsumeOptions.Any:
                                foreach (var consumer in consumers)
                                    if (Consume(consumer, jobMessage))
                                        break;
                                queue.TryDequeue(out var message);
                                break;
                            case ConsumeOptions.All:
                                var result = true;
                                foreach (var consumer in consumers)
                                    if (!Consume(consumer, jobMessage))
                                    {
                                        result = false;
                                        break;
                                    }
                                if (result) queue.TryDequeue(out message);
                                break;
                            case ConsumeOptions.None:
                                queue.TryDequeue(out message);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }

            static bool Consume(IMessageConsumer<TJobMessage> consumer, IMessageSource<TJobMessage> message)
            {
                try
                {
                    consumer.OnNext(message);
                    consumer.OnCompleted();
                    return true;
                }
                catch (Exception ex)
                {
                    consumer.OnError(ex);
                    return false;
                }
            }
        }
    }
}
