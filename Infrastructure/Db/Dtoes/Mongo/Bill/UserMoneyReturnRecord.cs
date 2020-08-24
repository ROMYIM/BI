using Infrastructure.Db.Dtoes.Mongo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Bill
{
    /// <summary>
    /// 用户费用返点记录
    /// </summary>
    [Table("UserMoneyReturnRecord")]
    public class UserMoneyReturnRecord : UserMoneyRecord
    {
        /// <summary>
        /// 是否已返点（补扣）
        /// </summary>
        public bool IsReturnFlag { get; set; }

        /// <summary>
        /// 返点时间
        /// </summary>
        public DateTime? RetrunDateTime { get; set; }

        /// <summary>
        /// 返回费用
        /// </summary>
        public double ReturnMoney { get; set; }

        /// <summary>
        /// 平台费用
        /// </summary>
        public double PlatformUMoney { get; set; }

        /// <summary>
        /// 平台物流扣费账号
        /// </summary>
        public string PlatFormUaccount { get; set; }

        /// <summary>
        /// 返点类型
        /// </summary>
        public UserReturnMoneyReturnType ReturnType { get; set; }
    }
}
