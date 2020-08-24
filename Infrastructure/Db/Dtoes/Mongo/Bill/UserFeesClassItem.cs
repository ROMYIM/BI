using Infrastructure.Db.Dtoes.Mongo.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Bill
{
    /// <summary>
    /// 费项科目明细
    /// </summary>
    public class UserFeesClassItem
    {
        ///<summary>
        ///科目序号
        ///</summary>
        public ChargeClass ChargeClass { get; set; }
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
        public HedgingFlagType HedgingFlag { get; set; }
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
    }
}
