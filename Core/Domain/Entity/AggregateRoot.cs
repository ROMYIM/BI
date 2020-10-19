using Core.Domain.Entity.Abractions;
using Core.Domain.Event.Abractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity
{
    public class AggregateRoot<TKey> : Entity<TKey>, IAggregateRoot<TKey>
    {
        protected readonly List<IDomainEvent> _domianEvents = new List<IDomainEvent>();
        public virtual ICollection<IDomainEvent> DomainEvents { get => _domianEvents;}
    }
}
