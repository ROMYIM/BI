using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    /// <summary>
    /// 客户扣费科目费项明细
    /// </summary>
    [Table("UserFeesClassItem")]
    public class UserFeesClassItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        ///<summary>
        ///科目序号
        ///</summary>
        public int ChargeClass { get; set; }
        ///<summary>
        ///原货币符号
        ///</summary>
        public string CCode { get; set; }
        ///<summary>
        ///费项明细金额
        ///</summary>
        public double ItemMoney { get; set; }
        ///<summary>
        ///数据类型标识 0=原数据 1=对冲数据 2=新数据
        ///</summary>
        public int HedgingFlag { get; set; }
        ///<summary>
        ///汇率
        ///</summary>
        public double ExchangeRate { get; set; }
        ///<summary>
        ///原货币金额
        ///</summary>
        public double OriCurFeeValue { get; set; }
        ///<summary>
        ///成本金额
        ///</summary>
        public double CostPrice { get; set; }
        ///<summary>
        ///承运商名称
        ///</summary>
        public string CName { get; set; }

        /// <summary>
        /// 关联账单的Id
        /// </summary>
        public string UserMoneyRecordId { get; set; }
    }
}
