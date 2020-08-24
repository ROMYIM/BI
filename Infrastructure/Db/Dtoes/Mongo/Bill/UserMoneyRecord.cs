using Core.DataBase.Mongo.Models;
using Infrastructure.Db.Dtoes.Mongo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Bill
{
    /// <summary>
    /// 客户费用记录表
    /// </summary>
    [Table("UserMoneyRecord")]
    public partial class UserMoneyRecord : MongoDbBasePo
    {
        ///<summary>
        ///费用记录序号
        ///</summary>
        [Key]
        public Guid Id { get; set; }

        ///<summary>
        ///物流账号
        ///</summary>
        public string UAccount { get; set; }

        ///<summary>
        ///交易金额
        ///</summary>
        public double UMoney { get; set; }

        ///<summary>
        ///交易后余额
        ///</summary>
        public double LeftMoney { get; set; }

        ///<summary>
        ///货币符号
        ///</summary>
        public string CCode { get; set; }

        ///<summary>
        ///存款平台 存款用  0=现金支付   1=Paypal 2=快钱支付 3=支付宝
        ///</summary>
        public DepositPlatform DepositPlatform { get; set; }

        ///<summary>
        ///存款账号
        ///</summary>
        public string Dan { get; set; }

        ///<summary>
        ///交易号
        ///</summary>
        public string TransNo { get; set; }

        ///<summary>
        /// 费用类型 
        ///</summary>
        public FeesType FeesType { get; set; }

        ///<summary>
        ///充值类型 现金 Cash = 0,银行到账 BankTransfer = 1 快钱 KuaiQian = 2
        ///</summary>
        public ReChargeType RechageType { get; set; }

        private string _orderId;
        ///<summary>
        ///订单编号 记录客户退款或返还费用是记录订单信息
        ///</summary>
        public string OrderId
        {
            get => _orderId;
            set => _orderId = value ?? "";
        }

        ///<summary>
        ///邮递方式编号
        ///</summary>
        public string PtId { get; set; }

        ///<summary>
        ///邮递方式名称
        ///</summary>
        public string PosttypeName { get; set; }

        ///<summary>
        ///国家信息编号
        ///</summary>
        public string CiId { get; set; }

        ///<summary>
        ///简体中文名
        ///</summary>
        public string FsName { get; set; }

        ///<summary>
        ///收货点(部门)序号  费用统计报表用
        ///</summary>
        public string RId { get; set; }

        ///<summary>
        ///跟踪号
        ///</summary>
        public string TranceId { get; set; }

        ///<summary>
        ///费用收支  0=收 1=支
        ///</summary>
        public IoFlag IoFlag { get; set; }

        ///<summary>
        ///结算状态0=新增  1=已结算      --操作员点击计算按钮后，不容许对该记录做删除、重算等操作，主要是针对返回费用等             2=结算不通过  --可以做重算等操作  3=结算已通过  -- 不许做任何更新、删除操作
        ///</summary>
        public BalanceCycleState IState { get; set; }

        ///<summary>
        ///数据类型标识 0=原数据 1=对冲数据 2=新数据
        ///</summary>
        public HedgingFlagType HedgingFlag { get; set; }

        /// <summary>
        /// 对冲组号（方便归组）
        /// </summary>
        public Guid? HedgingGroup { get; set; }


        ///<summary>
        ///扣费类型 0 =非扣费 1=客户 2= 点
        ///</summary>
        public DeDuctType DeDuctType { get; set; }

        ///<summary>
        ///业务员序号
        ///</summary>
        public int? UId { get; set; }

        ///<summary>
        ///结算周期
        ///</summary>
        public string BalanceCycle { get; set; }

        ///<summary>
        ///结算日期
        ///</summary>
        public DateTime? BalanceDate { get; set; }

        ///<summary>
        ///结算员
        ///</summary>
        public int? BUserId { get; set; }

        ///<summary>
        ///结算审核员
        ///</summary>
        public int? BaUserId { get; set; }

        ///<summary>
        ///结算审核日期
        ///</summary>
        public DateTime? AuBalanceDate { get; set; }

        ///<summary>
        ///是否同步到Mongo
        ///</summary>
        public bool SynMongoFlag { get; set; }

        ///<summary>
        ///操作人员
        ///</summary>
        public int UserId { get; set; }

        ///<summary>
        ///操作日期
        ///</summary>
        public DateTime OperateDate { get; set; }

        ///<summary>
        ///备注
        ///</summary>
        public string Remark { get; set; }

        ///<summary>
        ///对冲记录编号(方便统计到具体哪一笔记录)
        ///</summary>
        public Guid? HedgingId { get; set; }

        /// <summary>
        /// 成本邮递方式编号
        /// </summary>
        public string CostPtId { get; set; }

        /// <summary>
        /// 成本邮递方式名称
        /// </summary>
        public string CostPosttypeName { get; set; }

        ///<summary>
        ///成本金额
        ///</summary>
        public decimal CostMoney { get; set; }

        private int _orderCount;

        /// <summary>
        /// 订单件数（必填，默认为1）
        /// </summary>
        public int OrderCount
        {
            get { return _orderCount; }
            set { _orderCount = value <= 0 ? 1 : value; }
        }

        /// <summary>
        /// 重量
        /// </summary>
        public decimal Weight { get; set; }

        /// <summary>
        /// 扣费平台（根据订单平账时需要根据平台来确定是否需要平账）
        /// </summary>
        public ChargebackPlatform ChargebackPlatform { get; set; }

        /// <summary>
        /// 计算提示信息
        /// </summary>
        public string CountInfor { get; set; }

        /// <summary> 
        /// 包装类型 (子邮递方式)
        /// </summary>
        public PackType PackType { set; get; }

        ///<summary>
        ///订单子编号  一票多件时有效
        ///</summary>
        [NotMapped]
        public List<string> SopIds { get; set; }

        /// <summary>
        /// 客户扣费科目费项明细
        /// </summary>
        [NotMapped]
        public List<UserFeesClassItem> UserFeesClassItemsList { get; set; }

        /// <summary>
        /// 成本邮递方式扣费科目费项明细
        /// </summary>
        [NotMapped]
        public List<UserFeesClassItem> CostPostTypeFeesClassItemsList { get; set; }

        /// <summary>
        /// 应收应付组号
        /// </summary>
        public string AccountsRePayGroupId { get; set; }

        /// <summary> 
        /// 第三方接口订单号
        /// </summary>
        public string ApiOrderId
        {
            get; set;
        }

        /// <summary>
        /// 客户账期编号（统计报表用）
        /// </summary>
        public string UcSpIds { get; set; }

        /// <summary>
        /// 原始货币
        /// </summary>
        public string OCCode { get; set; }

        /// <summary>
        /// 原始货币对应的金额
        /// </summary>
        public double OUMoney { get; set; }

        /// <summary>
        /// 与目标货币兑换汇率(充值时使用，与金碟系统对应)
        /// </summary>
        public double OExchangeRate { get; set; } = 1;

        /// <summary>
        /// 账期金额列表
        /// </summary>
        [NotMapped]
        public List<PeriodMoney> PeriodMoneys { get; set; }




        private DateTime _mathDateTime;
        /// <summary>
        /// 账单匹配时间
        /// </summary>
        public DateTime? MathDateTime
        {
            get => _mathDateTime;
            set => _mathDateTime = value ?? Convert.ToDateTime("2001-01-01");
        }
    }
}
