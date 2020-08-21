using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain.Repository
{
    public interface IRepository<TEntity, TKey>
    {
        Task AddAsync(TEntity entity);

        Task<TEntity> FirstOrDefaultAsync(TKey id);

        Task UpdateAsync(TEntity entity);

        Task DeleteAsync(TKey key);
    }
}
