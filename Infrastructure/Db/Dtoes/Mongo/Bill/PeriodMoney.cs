using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Bill
{
    /// <summary>
    /// 每笔费用对应账期内发生的金额（客户充值的时候可能会有多条记录 ）
    /// </summary>
    public class PeriodMoney
    {
        /// <summary>
        /// 账期唯一编码
        /// </summary>
        public string PeriodKey { get; set; }

        /// <summary>
        /// 对应账期内发生的金额
        /// </summary>
        [BsonElement("Moeny")]
        public double Money { get; set; }
    }
}
