using Core.Domain.Event.Abractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity.Abractions
{
    public interface IAggregateRoot<TKey> : IEntity<TKey>, IAggregateRoot
    {
    }

    public interface IAggregateRoot : IEntity 
    {
        public ICollection<IDomainEvent> DomainEvents { get; }
    }
}
