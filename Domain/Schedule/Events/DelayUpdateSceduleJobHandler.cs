using Core.MessageQueues.Abractions;
using Domain.Schedule.Entities;
using Domain.Schedule.Repositories;
using Domain.ScheduleHistory.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Schedule.Events
{
    public class DelayUpdateSceduleJobHandler : IMessageConsumer<ScheduleJob>
    {
        private const string HistoryName = "修改定时任务属性";

        private readonly ILogger _logger;

        private readonly IScheduleJobRepository _jobRepository;

        private readonly IJobHistoryRepository _historyRepository;

        private ScheduleJob _job;

        public DelayUpdateSceduleJobHandler(
            ILoggerFactory loggerFactory,
            IScheduleJobRepository jobRepository,
            IJobHistoryRepository historyRepository)
        {
            _jobRepository = jobRepository;
            _historyRepository = historyRepository;
            _logger = loggerFactory.CreateLogger(GetType());
        }

        public async void OnCompleted()
        {
            _logger.LogInformation("写入历史记录");
            var history = _job.CreateHistory(HistoryName, "操作成功");
            await _historyRepository.AddAsync(history);
            await _historyRepository.SaveChangesAsync();
        }

        public async void OnError(Exception error)
        {
            _logger.LogInformation("写入历史记录");

            var descriptionBuilder = new StringBuilder("操作失败");
            descriptionBuilder.Append("详细信息：").Append(error.Message).Append("堆栈信息：").Append(error.StackTrace);
            var history = _job.CreateHistory(HistoryName, descriptionBuilder.ToString());
            await _historyRepository.AddAsync(history);
            await _historyRepository.SaveChangesAsync();
        }

        public async void OnNext(IMessageSource<ScheduleJob> value)
        {
            _logger.LogInformation("延时修改定时任务回调");
            value.ConsumeTime = DateTime.Now;
            _job = value.Source;
            await _jobRepository.UpdateAsync(_job);
            await _jobRepository.SaveChangesAsync();
        }
    }
}
