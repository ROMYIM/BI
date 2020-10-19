using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity.Abractions
{
    public interface IEntity<TKey> : IEntity
    {
        public TKey Id { get; }

    }

    public interface IEntity 
    {

        public DateTime CreationTime { get; set; }

        public DateTime UpdateTime { get; set; }
    }
}
