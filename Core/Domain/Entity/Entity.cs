using Core.Domain.Entity.Abractions;
using System;
namespace Core.Domain.Entity
{
    public class Entity<TKey> : IEntity<TKey>
    {
        public virtual TKey Id { get; protected set; }

        public virtual DateTime CreationTime { get; set; }

        public virtual DateTime UpdateTime { get; set; }
    }
}
