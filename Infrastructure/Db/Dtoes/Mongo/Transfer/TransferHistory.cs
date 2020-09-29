using Core.DataBase.Mongo.Models;
using Infrastructure.Db.Dtoes.Mongo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Transfer
{
    /// <summary>
    /// 转运历史记录表
    /// </summary>
    [Table("TransferHistory")]
    public class TransferHistory : MongoDbBasePo
    {
        /// <summary>
        /// 主键ID 
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 包裹标签ID (包裹标签指PKG或批次转运单号)
        /// </summary>
        public string Pkg { get; set; }

        /// <summary>
        /// 转运状态 (1=装袋 2=发起 3=转运 4=签收)
        /// </summary>
        public TransferStatus TransferStatus { get; set; }

        /// <summary>
        /// 始发地ID 
        /// </summary>
        public string FromDeliverAddressId { get; set; }

        /// <summary>
        /// 目的地ID 
        /// </summary>
        public string ToDeliverAddressId { get; set; }

        /// <summary>
        /// 操作描述 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 操作员ID 
        /// </summary>
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作时间 
        /// </summary>
        public DateTime OperateTime { get; set; }
    }
}
