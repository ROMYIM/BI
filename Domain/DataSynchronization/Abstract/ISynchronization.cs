using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Domain.DataSynchronization.Abstract
{
    public interface ISynchronization
    {
        internal CancellationTokenSource TokenSource { get; }

        internal string MongoTable { get; set; }
    }
}
