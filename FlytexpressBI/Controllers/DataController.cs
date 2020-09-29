using System;
using Domain.DataSynchronization;
using Domain.DataSynchronization.Managers;
using Microsoft.AspNetCore.Mvc;
using PgTransferDetail = Infrastructure.Db.Dtoes.Pg.TransferDetail;
using MongoTransferDetail = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferDetail;
using PgTransferHistory = Infrastructure.Db.Dtoes.Pg.TransferHistory;
using MongoTransferHistory = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferHistory;
using MongoTransferParent = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferParent;
using PgTransferParent = Infrastructure.Db.Dtoes.Pg.TransferParent;


namespace FlytexpressBI.Controllers
{
    [Route("[Controller]")]
    public class DataController : Controller
    {
        private readonly UserMoneyRecordSynchronization _synchronization;

        private readonly OrderParentSynchronization _orderSynchronization;

        private readonly TransferRouteSynchronization _transferRouteSynchronization;

        private readonly TransferRouteNodeSynchornization _transferRouteNodeSynchornization;

        private readonly Synchronization<MongoTransferParent, PgTransferParent> _transferParentSynchronization;

        private readonly Synchronization<MongoTransferHistory, PgTransferHistory> _transferHistorySynchronization;

        private readonly Synchronization<MongoTransferDetail, PgTransferDetail> _transferDetailSynchronization;

        public DataController(
            UserMoneyRecordSynchronization synchronization,
            OrderParentSynchronization orderParentSynchronization,
            TransferRouteSynchronization transferRouteSynchronization,
            TransferRouteNodeSynchornization transferRouteNodeSynchornization,
            Synchronization<MongoTransferDetail, PgTransferDetail> transferDetailSynchronization,
            Synchronization<MongoTransferParent, PgTransferParent> transferParentSynchronization,
            Synchronization<MongoTransferHistory, PgTransferHistory> transferHistorySynchronization)
        {
            _synchronization = synchronization;
            _orderSynchronization = orderParentSynchronization;
            _transferDetailSynchronization = transferDetailSynchronization;
            _transferParentSynchronization = transferParentSynchronization;
            _transferHistorySynchronization = transferHistorySynchronization;
            _transferRouteSynchronization = transferRouteSynchronization;
            _transferRouteNodeSynchornization = transferRouteNodeSynchornization;
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

        [Route("sync/transferdetails")]
        public IActionResult TransferDetailSynchronize(DateTime startTime, DateTime endTime)
        {
            _ = _transferDetailSynchronization.SynchronizeDataAsync(startTime, TimeSpan.FromDays(1), endTime);
            return Ok();
        }

        public IActionResult TransferDetailSynchronization()
        {
            _transferParentSynchronization.TokenSource.Cancel(true);
            return Ok();
        }

        [Route("sync/transferhistory")]
        public IActionResult TransferHistorySynchronize(DateTime startTime, DateTime endTime)
        {
            _ = _transferHistorySynchronization.SynchronizeDataAsync(startTime, TimeSpan.FromDays(1), endTime);
            return Ok();
        }

        [Route("sync/transfer")]
        public IActionResult TransferParentSynchronize(DateTime startTime, DateTime endTime)
        {
            _ = _transferParentSynchronization.SynchronizeDataAsync(startTime, TimeSpan.FromDays(1), endTime);
            return Ok();
        }

        [Route("sync/transferroute")]
        public IActionResult TransferRouteSynchronize(DateTime startTime, DateTime endTime)
        {
            _ = _transferRouteSynchronization.SynchronizeDataAsync(startTime, TimeSpan.FromDays(1), endTime);
            return Ok();
        }

        [Route("sync/transferroute/node")]
        public IActionResult TransferRouteNodeSynchronize(DateTime startTime, DateTime endTime)
        {
            _ = _transferRouteNodeSynchornization.SynchronizeDataAsync(startTime, TimeSpan.FromDays(1), endTime);
            return Ok();
        }

        [Route("init")]
        public IActionResult InitializeData(DateTime startTime)
        {
            
            return Ok(startTime);
        }
    }
}
