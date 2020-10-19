using Core.Domain.Entity;
using Core.Domain.Entity.Abractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Event.Abractions
{
    public interface IDomainEvent
    {
        public Guid EventId { get; }

        public IAggregateRoot Source { get; }

        public DateTime TriggerTime { get; set; }
    }

}
