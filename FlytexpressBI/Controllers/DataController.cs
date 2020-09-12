using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain.DataSynchronization;
using Domain.DataSynchronization.Managers;
using Domain.Schedule.Managers;
using Infrastructure.Db.Contexts;
using Infrastructure.Db.Dtoes.Mongo.Bill;
using Infrastructure.Db.Dtoes.Pg;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Npgsql;

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
            _ = _synchronization.SynchronizeDataAsync(0, 1000);
            //_ = _syncJob.SynchronizeData(1000, new CancellationTokenSource().Token);
            return Ok();
        }

        [Route("sync/order")]
        public IActionResult OrderSynchronize()
        {
            _ = _orderSynchronization.SynchronizeDataAsync(17624000, 10000);
            return Ok();
        }

        [Route("sync/usermoneyrecord")]
        public IActionResult UserMoneyRecordSynchronize()
        {
            _ = _synchronization.SynchronizeDataAsync(0, 1000);
            //_ = _syncJob.SynchronizeData(1000, new CancellationTokenSource().Token);
            return Ok();
        }

        [Route("init")]
        public IActionResult InitializeData()
        {
            
            return Ok();
        }
    }
}
