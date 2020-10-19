using Core.Domain.Entity;
using Core.Domain.Entity.Abractions;
using Core.Domain.Event.Abractions;
using Core.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Event.Abractions
{
    public abstract class DomainEvent
    {
        public Guid EventId { get; }

        public IAggregateRoot Source { get ; }

        public DateTime TriggerTime { get; set; }

        public DomainEvent(IAggregateRoot source)
        {
            Source = source ?? throw new ArgumentNullException(nameof(source));
            EventId = GuidHelper.GenerateComb();
        }
    }
}
