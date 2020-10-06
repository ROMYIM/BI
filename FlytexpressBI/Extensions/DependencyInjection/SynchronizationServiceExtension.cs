using Domain.DataSynchronization;
using Domain.DataSynchronization.Managers;
using Domain.DataSynchronization.Abstract;
using Microsoft.Extensions.DependencyInjection;
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

namespace FlytexpressBI.Extensions.DependencyInjection
{
    public static class SynchronizationServiceExtension
    {
        /// <summary>
        /// 注册同步服务。因为会使用多个类型别名所以做成一个扩展函数
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSynchronizationServices(this IServiceCollection services)
        {
            services.AddSingleton<ITimeSynchronization<MongoUserMoneyRecord, PgUserMoneyRecord>, UserMoneyRecordSynchronization>();
            services.AddSingleton<ITimeSynchronization<MongoOrder, PgOrder>, OrderParentSynchronization>();
            services.AddSingleton<ITimeSynchronization<MongoTransferDetail, PgTransferDetail>, Synchronization<MongoTransferDetail, PgTransferDetail>>();
            services.AddSingleton<ITimeSynchronization<MongoTransferHistory, PgTransferHistory>, Synchronization<MongoTransferHistory, PgTransferHistory>>();
            services.AddSingleton<ITimeSynchronization<MongoTransferParent, PgTransferParent>, Synchronization<MongoTransferParent, PgTransferParent>>();
            services.AddSingleton<IIndexSynchronization<MongoTransferRouteNode, PgTransferRouteNode>, TransferRouteNodeSynchornization>();
            services.AddSingleton<IIndexSynchronization<MongoTranferRoute, PgTransferRoute>, TransferRouteSynchronization>();
            services.AddSingleton<ITimeSynchronization<MongoOrderOperationNodeTime, PgOrderOperationNodeTime>, Synchronization<MongoOrderOperationNodeTime, PgOrderOperationNodeTime>>();
            services.AddSingleton<IIndexSynchronization<MongoTransferWeighing, PgTransferWeighing>, Synchronization<MongoTransferWeighing, PgTransferWeighing>>();
            services.AddSingleton<IIndexSynchronization<MongoPostType, PgPostType>, Synchronization<MongoPostType, PgPostType>>();
            services.AddSingleton<IIndexSynchronization<MongoUserInfo, PgUserInfo>, Synchronization<MongoUserInfo, PgUserInfo>>();
            services.AddSingleton<IIndexSynchronization<MongoUser, PgUser>, Synchronization<MongoUser, PgUser>>();

            return services;
        }
    }
}
