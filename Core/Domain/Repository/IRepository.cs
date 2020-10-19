using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Repository
{
    public interface IRepository<TEntity, TKey>
    {
        ValueTask AddAsync(TEntity entity);

        ValueTask<TEntity> FirstOrDefaultAsync(TKey id);

        ValueTask UpdateAsync(TEntity entity);

        ValueTask DeleteAsync(TEntity entity);

        Task<int> SaveChangesAsync();
    }
}
