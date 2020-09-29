using Core.DataBase.Mongo.Models;
using Infrastructure.Db.Dtoes.Mongo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Transfer
{
    /// <summary>
    /// 物流转运明细表 对应旧表 TransitLableListItem
    /// </summary>
    [Table("TransferDetail")]
    public class TransferDetail : MongoDbVersionPo
    {
        /// <summary>
        /// 主键ID 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// PKG编号 
        /// </summary>
        public string Pkg { get; set; }

        /// <summary>
        /// 订单编号 
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// 明细重量 
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// 备注 
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 原因ID 
        /// </summary>
        public string BrId { get; set; }

        /// <summary>
        /// 操作时间 
        /// </summary>
        public DateTime OperateTime { get; set; }

        /// <summary>
        /// 操作人ID 
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 单号类型(空/默认为订单)
        /// </summary>
        public OrderType OrderType { get; set; }
    }
}
