using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity
{
    public interface IAggregateRoot<TKey> : IEntity<TKey>
    {
    }

    public interface IAggregateRoot : IAggregateRoot<object>, IEntity { }
}
