using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DataSynchronization.Abstract
{
    public interface IIndexSynchronization : ISynchronization
    {
        Task SynchronizeDataAsync(int startIndex, int synchronizeCountPerTime, int? synchornizationCount = default);
    }

    public interface IIndexSynchronization<TMongo, TPg> : IIndexSynchronization { }
}
