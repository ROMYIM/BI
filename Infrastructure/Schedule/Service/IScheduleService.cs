using Core.BackgroundService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Schedule.Service
{
    public interface IScheduleService : IAutoStartupService
    {
        Task RestartAsync(TimeSpan delaySpan, CancellationToken cancellationToken);
    }
}
