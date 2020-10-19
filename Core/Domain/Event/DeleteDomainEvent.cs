using Core.Domain.Entity;
using Core.Domain.Entity.Abractions;
using Core.Domain.Event.Abractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Event
{
    public class DeleteDomainEvent<T> : DomainEvent where T : IAggregateRoot
    {
        public DeleteDomainEvent(T source) : base(source)
        {
        }
    }
}
