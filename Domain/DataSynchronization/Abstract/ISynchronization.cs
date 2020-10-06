using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Domain.DataSynchronization.Abstract
{
    public interface ISynchronization
    {
        CancellationTokenSource TokenSource { get; }
    }
}
