using System;
using Domain.DataSynchronization.Abstract;
using Microsoft.AspNetCore.Mvc;
using PgTransferDetail = Infrastructure.Db.Dtoes.Pg.TransferDetail;
using MongoTransferDetail = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferDetail;
using PgTransferHistory = Infrastructure.Db.Dtoes.Pg.TransferHistory;
using MongoTransferHistory = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferHistory;
using MongoTransferParent = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferParent;
using PgTransferParent = Infrastructure.Db.Dtoes.Pg.TransferParent;
using MongoOrderOperationNodeTime = Infrastructure.Db.Dtoes.Mongo.OrderEntity.OrderOperationNodeTime;
using PgOrderOperationNodeTime = Infrastructure.Db.Dtoes.Pg.OrderOperationNodeTime;
using MongoUserMoneyRecord = Infrastructure.Db.Dtoes.Mongo.Bill.UserMoneyRecord;
using PgUserMoneyRecord = Infrastructure.Db.Dtoes.Pg.UserMoneyRecord;
using MongoOrder = Infrastructure.Db.Dotes.Mongo.OrderEntity.OrderParent;
using PgOrder = Infrastructure.Db.Dtoes.Pg.OrderParent;
using MongoTransferRouteNode = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferRouteNode;
using PgTransferRouteNode = Infrastructure.Db.Dtoes.Pg.TransferRouteNode;
using MongoTranferRoute = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferRoute;
using PgTransferRoute = Infrastructure.Db.Dtoes.Pg.TransferRoute;
using MongoTransferWeighing = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferWeighing;
using PgTransferWeighing = Infrastructure.Db.Dtoes.Pg.TransferWeighing;
using MongoPostType = Infrastructure.Db.Dtoes.Mongo.ChannelProduct.PostTypes;
using PgPostType = Infrastructure.Db.Dtoes.Pg.PostType;
using MongoUserInfo = Infrastructure.Db.Dtoes.Mongo.Customer.UserInfo;
using PgUserInfo = Infrastructure.Db.Dtoes.Pg.UserInfo;
using MongoUser = Infrastructure.Db.Dtoes.Mongo.Authorization.UserRolePermission.Users;
using PgUser = Infrastructure.Db.Dtoes.Pg.Users;


namespace FlytexpressBI.Controllers
{
    [Route("[Controller]")]
    public class DataController : Controller
    {
        private readonly ITimeSynchronization<MongoOrder, PgOrder> _orderSynchronization;

        private readonly IIndexSynchronization<MongoUser, PgUser> _userSynchronization;

        private readonly IIndexSynchronization<MongoUserInfo, PgUserInfo> _userInfoSynchronization;

        private readonly ITimeSynchronization<MongoUserMoneyRecord, PgUserMoneyRecord> _userMoneyRecordSynchronization;

        private readonly IIndexSynchronization<MongoTranferRoute, PgTransferRoute> _transferRouteSynchronization;

        private readonly IIndexSynchronization<MongoTransferRouteNode, PgTransferRouteNode> _transferRouteNodeSynchornization;

        private readonly ITimeSynchronization<MongoTransferParent, PgTransferParent> _transferParentSynchronization;

        private readonly ITimeSynchronization<MongoTransferHistory, PgTransferHistory> _transferHistorySynchronization;

        private readonly ITimeSynchronization<MongoTransferDetail, PgTransferDetail> _transferDetailSynchronization;

        private readonly IIndexSynchronization<MongoTransferWeighing, PgTransferWeighing> _transferWeighingSynchronization;

        private readonly IIndexSynchronization<MongoPostType, PgPostType> _postTypeSynchronization;

        private readonly ITimeSynchronization<MongoOrderOperationNodeTime, PgOrderOperationNodeTime> _orderOperationNodeTimeSynchronization;

        public DataController(
            ITimeSynchronization<MongoOrder, PgOrder> orderParentSynchronization,
            IIndexSynchronization<MongoPostType, PgPostType> postTypeSynchronization,
            IIndexSynchronization<MongoUser, PgUser> userSynchronization,
            IIndexSynchronization<MongoUserInfo, PgUserInfo> userInfoSynchronization,
            ITimeSynchronization<MongoUserMoneyRecord, PgUserMoneyRecord> userMoneyRecordSynchronization,
            IIndexSynchronization<MongoTranferRoute, PgTransferRoute> transferRouteSynchronization,
            IIndexSynchronization<MongoTransferRouteNode, PgTransferRouteNode> transferRouteNodeSynchornization,
            ITimeSynchronization<MongoTransferDetail, PgTransferDetail> transferDetailSynchronization,
            ITimeSynchronization<MongoTransferParent, PgTransferParent> transferParentSynchronization,
            ITimeSynchronization<MongoTransferHistory, PgTransferHistory> transferHistorySynchronization,
            IIndexSynchronization<MongoTransferWeighing, PgTransferWeighing> transferWeighingSynchronization,
            ITimeSynchronization<MongoOrderOperationNodeTime, PgOrderOperationNodeTime> orderOperationNodeTimeSynchronization)
        {
            _orderSynchronization = orderParentSynchronization;
            _postTypeSynchronization = postTypeSynchronization;
            _userSynchronization = userSynchronization;
            _userInfoSynchronization = userInfoSynchronization;
            _userMoneyRecordSynchronization = userMoneyRecordSynchronization;
            _transferDetailSynchronization = transferDetailSynchronization;
            _transferParentSynchronization = transferParentSynchronization;
            _transferHistorySynchronization = transferHistorySynchronization;
            _transferRouteSynchronization = transferRouteSynchronization;
            _transferRouteNodeSynchornization = transferRouteNodeSynchornization;
            _transferWeighingSynchronization = transferWeighingSynchronization;
            _orderOperationNodeTimeSynchronization = orderOperationNodeTimeSynchronization;
        }

        [HttpPatch]
        public IActionResult Index()
        {
            _ = _userMoneyRecordSynchronization.SynchronizeDataAsync(new DateTime(2019, 1, 1), TimeSpan.FromDays(1));
            //_ = _syncJob.SynchronizeData(1000, new CancellationTokenSource().Token);
            return Ok();
        }

        [Route("sync/orders")]
        [HttpPatch]
        public IActionResult OrderSynchronize(DateTime startTime, DateTime endTime)
        {
            _ = _orderSynchronization.SynchronizeDataAsync(startTime, TimeSpan.FromDays(1), endTime);
            return Ok();
        }

        [Route("sync/usermoneyrecords")]
        [HttpPatch]
        public IActionResult UserMoneyRecordSynchronize(DateTime startTime, DateTime endTime)
        {
            _ = _userMoneyRecordSynchronization.SynchronizeDataAsync(startTime, TimeSpan.FromDays(1), endTime);
            //_ = _syncJob.SynchronizeData(1000, new CancellationTokenSource().Token);
            return Ok();
        }

        [Route("sync/transferdetails")]
        [HttpPatch]
        public IActionResult TransferDetailSynchronize(DateTime startTime, DateTime endTime)
        {
            _ = _transferDetailSynchronization.SynchronizeDataAsync(startTime, TimeSpan.FromDays(1), endTime);
            return Ok();
        }

        [Route("sync/order/nodetime")]
        [HttpPatch]
        public IActionResult OrderOperationNodeTimeSynchronization(DateTime startTime, DateTime endTime)
        {
            _ = _orderOperationNodeTimeSynchronization.SynchronizeDataAsync(startTime, TimeSpan.FromDays(1), endTime);
            return Ok();
        }

        [Route("sync/transferhistory")]
        [HttpPatch]
        public IActionResult TransferHistorySynchronize(DateTime startTime, DateTime endTime)
        {
            _ = _transferHistorySynchronization.SynchronizeDataAsync(startTime, TimeSpan.FromDays(1), endTime);
            return Ok();
        }

        [Route("sync/transfer")]
        [HttpPatch]
        public IActionResult TransferParentSynchronize(DateTime startTime, DateTime endTime)
        {
            _ = _transferParentSynchronization.SynchronizeDataAsync(startTime, TimeSpan.FromDays(1), endTime);
            return Ok();
        }

        [Route("sync/transferroute")]
        [HttpPatch]
        public IActionResult TransferRouteSynchronize(int startIndex, int synchronizeCountPerTime, int? synchronizationCount)
        {
            _ = _transferRouteSynchronization.SynchronizeDataAsync(startIndex, synchronizeCountPerTime, synchronizationCount);
            return Ok();
        }

        [HttpPatch]
        [Route("sync/transferroute/node")]
        public IActionResult TransferRouteNodeSynchronize(int startIndex, int synchronizeCountPerTime, int? synchronizationCount)
        {
            _ = _transferRouteNodeSynchornization.SynchronizeDataAsync(startIndex, synchronizeCountPerTime, synchronizationCount);
            return Ok();
        }

        [HttpPatch]
        [Route("sync/transfer/weighing")]
        public IActionResult TransferWeighingSynchronize(int startIndex, int synchronizeCountPerTime, int? synchronizationCount)
        {
            _ = _transferWeighingSynchronization.SynchronizeDataAsync(startIndex, synchronizeCountPerTime, synchronizationCount);
            return Ok();
        }

        [HttpPatch]
        [Route("sync/posttype")]
        public IActionResult PostTypeSynchronize(int startIndex, int synchronizeCountPerTime, int? synchronizationCount)
        {
            _ = _postTypeSynchronization.SynchronizeDataAsync(startIndex, synchronizeCountPerTime, synchronizationCount);
            return Ok();
        }

        [HttpPatch]
        [Route("sync/user")]
        public IActionResult UserSynchronize(int startIndex, int synchronizeCountPerTime, int? synchronizationCount)
        {
            _ = _userSynchronization.SynchronizeDataAsync(startIndex, synchronizeCountPerTime, synchronizationCount);
            return Ok();
        }

        [HttpPatch]
        [Route("sync/userinfo")]
        public IActionResult UserInfoSynchronize(int startIndex, int synchronizeCountPerTime, int? synchronizationCount)
        {
            _ = _userInfoSynchronization.SynchronizeDataAsync(startIndex, synchronizeCountPerTime, synchronizationCount);
            return Ok();
        }

        [HttpGet]
        [Route("init")]
        public IActionResult InitializeData(DateTime startTime)
        {
            
            return Ok(startTime);
        }
    }
}
