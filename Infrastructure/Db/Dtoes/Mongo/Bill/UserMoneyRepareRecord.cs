using Infrastructure.Db.Dtoes.Mongo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Bill
{
    /// <summary>
    /// 平台客户预扣费记录表
    /// </summary>
    [Table("UserMoneyPrepareRecord")]
    public class UserMoneyPrepareRecord : UserMoneyRecord
    {
        /// <summary>
        /// 是否删除(退费)
        /// </summary>
        public bool IsDelete { get; set; }

        /// <summary>
        /// 是否已补扣过
        /// </summary>
        public bool IsDeDuct { get; set; }

        /// <summary>
        /// 补扣费用
        /// </summary>
        public double DeDuctFee { get; set; }

        /// <summary>
        /// 补扣操作员
        /// </summary>
        public int? DeDuctUserId { get; set; }

        /// <summary>
        /// 补扣时间
        /// </summary>

        public DateTime? DeDuctFeeDateTime { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        public PrepareRecordOperateType? PrepareRecordOperateType { get; set; }


    }
}
