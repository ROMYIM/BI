using Core.Domain.Entity;
using Core.Domain.Entity.Abractions;
using Core.Domain.Event.Abractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Event
{
    public class UpdateDomainEvent<T> : DomainEvent where T : IAggregateRoot
    {
        public UpdateDomainEvent(T source) : base(source)
        {
        }
    }
}
