using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Db.Dtoes.Pg
{
    public class TransferDetail
    {
        /// <summary>
        /// 主键ID 
        /// </summary>
        [Key]
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
        public int OrderType { get; set; }

        public int DataVersion { get; set; }

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
