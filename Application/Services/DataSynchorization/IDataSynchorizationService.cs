using Core.BackgroundService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Services.DataSynchorization
{
    public interface IDataSynchorizationService : IAutoStartupService
    {
        Task RestartAsync(TimeSpan delaySpan, CancellationToken cancellationToken);
    }
}
