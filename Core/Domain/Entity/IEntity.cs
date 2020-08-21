using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity
{
    public interface IEntity<TKey>
    {
        public TKey Id { get; set; }

        public DateTime CreationTime { get; set; }
    }

    public interface IEntity : IEntity<object> { }
}
