using Core.Domain.Repository;
using Domain.Schedule.Entities;
using Infrastructure.Db.Contexts;
using Microsoft.EntityFrameworkCore;
using Quartz;
using System;
using System.Threading.Tasks;
using PgScheduleJob = Infrastructure.Db.Dtoes.Pg.ScheduleJob;

namespace Domain.Schedule.Repositories
{
    public interface IScheduleJobRepository : IRepository<ScheduleJob, JobKey>
    {
    }

    public class ScheduleJobRepository : IScheduleJobRepository
    {
        private readonly FlytBIDbContext _dbContext;

        public ScheduleJobRepository(FlytBIDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public ValueTask AddAsync(ScheduleJob entity)
        {
            var dto = ToScheduleJobPgDto(entity);
            _dbContext.ScheduleJobs.AddAsync(dto);
            return new ValueTask();
        }

        public ValueTask DeleteAsync(ScheduleJob entity)
        {
            var dto = ToScheduleJobPgDto(entity);
            _dbContext.ScheduleJobs.Remove(dto);
            return new ValueTask();
        }

        public async ValueTask<ScheduleJob> FirstOrDefaultAsync(JobKey id)
        {
            var dto = await _dbContext.ScheduleJobs.FirstOrDefaultAsync(job =>
            job.GroupName == id.Group && job.JobName == id.Name);

            if (dto == null) return null;
            else return ToScheduleJobDomainEntity(dto);
        }

        public Task<int> SaveChangesAsync()
        {
            return _dbContext.SaveChangesAsync();
        }

        public ValueTask UpdateAsync(ScheduleJob entity)
        {
            var dto = ToScheduleJobPgDto(entity);
            _dbContext.ScheduleJobs.Update(dto);
            return new ValueTask();
        }

        private PgScheduleJob ToScheduleJobPgDto(ScheduleJob job)
        {
            (var groupName, var jobName, var status, var table, var stragetegyId, var creationTime, var updateTime) 
                = job ?? throw new ArgumentNullException(nameof(job));

            return new PgScheduleJob
            {
                GroupName = groupName,
                JobName = jobName,
                StragtegyId = stragetegyId,
                Status = status,
                CreationTime = creationTime,
                UpdateTime = updateTime,
                Table = table,
            };

        }

        private ScheduleJob ToScheduleJobDomainEntity(PgScheduleJob dto)
        {
            if (dto == null) throw new ArgumentNullException(nameof(dto));

            return new ScheduleJob(
                dto.GroupName, 
                dto.JobName, 
                (JobStatus)dto.Status, 
                dto.Table,
                dto.StragtegyId, 
                dto.CreationTime, 
                dto.UpdateTime);
        }
    }
}
