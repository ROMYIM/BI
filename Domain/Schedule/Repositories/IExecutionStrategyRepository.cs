using Core.Domain.Repository;
using Domain.Schedule.Entities;
using Infrastructure.Db.Contexts;
using Infrastructure.Db.Dtoes.Pg;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Domain.Schedule.Repositories
{
    public interface IExecutionStrategyRepository : IRepository<ExecutionStrategy, string>
    {
    }

    public class ExecutionStrategyRepository : IExecutionStrategyRepository
    {
        private readonly FlytBIDbContext _dbContext;

        public ExecutionStrategyRepository(FlytBIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ValueTask AddAsync(ExecutionStrategy entity)
        {
            var dto = ToStrategyPgDto(entity);
            _dbContext.Strategies.Add(dto);
            return new ValueTask();
        }

        public ValueTask DeleteAsync(ExecutionStrategy entity)
        {
            var dto = ToStrategyPgDto(entity);
            _dbContext.Strategies.Remove(dto);
            return new ValueTask();
        }

        public async ValueTask<ExecutionStrategy> FirstOrDefaultAsync(string id)
        {
            var dto = await _dbContext.Strategies.FirstOrDefaultAsync(s => s.Id == id);
            return ToStrategyDomainEntity(dto);
        }

        public Task<int> SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public ValueTask UpdateAsync(ExecutionStrategy entity)
        {
            _dbContext.Strategies.Update(ToStrategyPgDto(entity));
            return new ValueTask();
        }

        private ExecutionStrategy ToStrategyDomainEntity(JobStrategy dto) 
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            return new ExecutionStrategy(dto.Id, dto.StartTime, dto.EndTime, dto.Description, dto.Period);
        }

        private JobStrategy ToStrategyPgDto(ExecutionStrategy strategy)
        {
            if (strategy == null) throw new ArgumentNullException(nameof(strategy));

            return new JobStrategy
            {
                Id = strategy.Id,
                StartTime = strategy.StartTime,
                EndTime = strategy.EndTime,
                Description = strategy.Description,
                Period = strategy.Period
            };
        }
    }
}
