using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataSynchronization.Abstract
{
    public interface ITimeSynchronization : ISynchronization
    {
        Task SynchronizeDataAsync(DateTime startTime, TimeSpan synchronizeDuration, DateTime endTime = default);
    }

    public interface ITimeSynchronization<TMongo, TPg> : ITimeSynchronization { }
}
