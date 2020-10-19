using Core.Domain.Repository;
using Domain.Schedule.Entities;
using Domain.ScheduleHistory.Entities;
using Infrastructure.Db.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PgDto = Infrastructure.Db.Dtoes.Pg.JobHistory;

namespace Domain.ScheduleHistory.Repositories
{
    public interface IJobHistoryRepository : IRepository<JobHistory, ulong>
    {
    }

    public class JobHistoryRepository : IJobHistoryRepository
    {
        private readonly FlytBIDbContext _dbContext;

        public JobHistoryRepository(FlytBIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ValueTask AddAsync(JobHistory entity)
        {
            _dbContext.Histories.AddAsync(EntityToDto(entity));
            return new ValueTask();
        }

        public ValueTask DeleteAsync(JobHistory entity)
        {
            _dbContext.Histories.Remove(EntityToDto(entity));
            return new ValueTask();
        }

        public async ValueTask<JobHistory> FirstOrDefaultAsync(ulong id)
        {
            var dto = await _dbContext.Histories.FirstOrDefaultAsync(h => h.Id == id);
            return DtoToEntity(dto);
        }

        public Task<int> SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public ValueTask UpdateAsync(JobHistory entity)
        {
            _dbContext.Histories.Update(EntityToDto(entity));
            return new ValueTask();
        }

        private JobHistory DtoToEntity(PgDto dto)
        {
            return new JobHistory(
                dto.Id, dto.Name, dto.Description, dto.CreationTime, dto.UpdateTime);
        }

        private PgDto EntityToDto(JobHistory history)
        {
            (var id, var name, var description, var creationTime, var updateTime) = history;
            return new PgDto
            {
                Id = id,
                Name = name,
                Description = description,
                CreationTime = creationTime,
                UpdateTime = updateTime
            };
        }
    }
}
