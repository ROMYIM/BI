using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories.Abbraction
{
    public interface IRepositoryBase<TEntity> : IRepository<TEntity, string>
    {
        IQueryable<TEntity> Entities { get; }
    }
}
