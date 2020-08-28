using Core.BackgroundService;
using Infrastructure.Schedule.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Services.DataSynchorization
{
    public interface IDataSynchorizationService : IScheduleService
    {
        public Task SynchronizeData(CancellationToken token);
    }
}
