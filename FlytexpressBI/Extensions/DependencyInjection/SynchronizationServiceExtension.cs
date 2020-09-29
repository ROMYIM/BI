using Domain.DataSynchronization;
using Domain.DataSynchronization.Managers;
using Microsoft.Extensions.DependencyInjection;
using PgTransferDetail = Infrastructure.Db.Dtoes.Pg.TransferDetail;
using MongoTransferDetail = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferDetail;
using PgTransferHistory = Infrastructure.Db.Dtoes.Pg.TransferHistory;
using MongoTransferHistory = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferHistory;
using MongoTransferParent = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferParent;
using PgTransferParent = Infrastructure.Db.Dtoes.Pg.TransferParent;
using MongoOrderOperationNodeTime = Infrastructure.Db.Dtoes.Mongo.OrderEntity.OrderOperationNodeTime;
using PgOrderOperationNodeTime = Infrastructure.Db.Dtoes.Pg.OrderOperationNodeTime;

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
            services.AddSingleton<UserMoneyRecordSynchronization>();
            services.AddSingleton<OrderParentSynchronization>();
            services.AddSingleton<Synchronization<MongoTransferDetail, PgTransferDetail>>();
            services.AddSingleton<Synchronization<MongoTransferHistory, PgTransferHistory>>();
            services.AddSingleton<Synchronization<MongoTransferParent, PgTransferParent>>();
            services.AddSingleton<TransferRouteNodeSynchornization>();
            services.AddSingleton<TransferRouteSynchronization>();
            services.AddSingleton<Synchronization<MongoOrderOperationNodeTime, PgOrderOperationNodeTime>>();

            return services;
        }
    }
}
