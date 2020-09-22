using System;
using Domain.DataSynchronization;
using Domain.DataSynchronization.Managers;
using Domain.Schedule.Managers;
using Microsoft.AspNetCore.Mvc;

namespace FlytexpressBI.Controllers
{
    [Route("[Controller]")]
    public class DataController : Controller
    {
        private readonly UserMoneyRecordSynchronization _synchronization;

        private readonly OrderParentSynchronization _orderSynchronization;

        private readonly DataSynchornizationJob _syncJob;

        public DataController(
            UserMoneyRecordSynchronization synchronization,
            OrderParentSynchronization orderParentSynchronization,
            DataSynchornizationJob syncJob)
        {
            _synchronization = synchronization;
            _orderSynchronization = orderParentSynchronization;
            _syncJob = syncJob;
        }

        public IActionResult Index()
        {
            _ = _synchronization.SynchronizeDataAsync(new DateTime(2019, 1, 1), TimeSpan.FromDays(1));
            //_ = _syncJob.SynchronizeData(1000, new CancellationTokenSource().Token);
            return Ok();
        }

        [Route("sync/orders")]
        public IActionResult OrderSynchronize(DateTime startTime, DateTime endTime)
        {
            _ = _orderSynchronization.SynchronizeDataAsync(startTime, TimeSpan.FromDays(1), endTime);
            return Ok();
        }

        [Route("sync/usermoneyrecords")]
        public IActionResult UserMoneyRecordSynchronize(DateTime startTime, DateTime endTime)
        {
            _ = _synchronization.SynchronizeDataAsync(startTime, TimeSpan.FromDays(1), endTime);
            //_ = _syncJob.SynchronizeData(1000, new CancellationTokenSource().Token);
            return Ok();
        }

        [Route("init")]
        public IActionResult InitializeData(DateTime startTime)
        {
            
            return Ok(startTime);
        }
    }
}
