using Core.DataBase.Mongo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    /// <summary>
    /// 转运历史记录表
    /// </summary>
    [Table("TransferHistory")]
    public class TransferHistory
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
        public int TransferStatus { get; set; }

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

        private DateTime _utcCreateTime;

        /// <summary>
        /// 创建时间(UTC)
        /// </summary>
        public DateTime UtcCreateTime
        {
            get => _utcCreateTime == default ? (_utcCreateTime = DateTime.UtcNow) : _utcCreateTime;
            set => _utcCreateTime = value;
        }

        private DateTime _utcModifyTime;

        /// <summary>
        /// 修改时间(UTC)
        /// </summary>
        public DateTime UtcModifyTime
        {
            get => _utcModifyTime == default ? (_utcModifyTime = DateTime.UtcNow) : _utcModifyTime;
            set => _utcModifyTime = value;
        }

        private DateTime _utcCancelTime;
        /// <summary>
        /// 作废时间(UTC)
        /// </summary>
        public DateTime? UtcCancelTime
        {
            get => _utcCancelTime;
            set => _utcCancelTime = value ?? new DateTime(2001, 1, 1).ToUniversalTime();
        }
    }
}
