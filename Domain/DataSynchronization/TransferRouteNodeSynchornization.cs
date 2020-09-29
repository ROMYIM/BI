using Core.DataBase.Mongo;
using Domain.DataSynchronization.Managers;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using MongoTransferRouteNode = Infrastructure.Db.Dtoes.Mongo.Transfer.TransferRouteNode;
using PgTransferRouteNode = Infrastructure.Db.Dtoes.Pg.TransferRouteNode;

namespace Domain.DataSynchronization
{
    public class TransferRouteNodeSynchornization : Synchronization<MongoTransferRouteNode, PgTransferRouteNode>
    {
        public TransferRouteNodeSynchornization(
            MongoDbContext mongoDbContext, 
            ILoggerFactory loggerFactory, 
            IServiceProvider serviceProvider) 
            : base(mongoDbContext, loggerFactory, serviceProvider)
        {
        }

        protected override string UtcModifyTime => "UpdateTime";
    }
}
