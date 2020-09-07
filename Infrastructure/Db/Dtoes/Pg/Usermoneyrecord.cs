using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    //[Table("usermoneyrecord")]
    //public partial class Usermoneyrecord
    //{
    //    [Column("ccode")]
    //    [StringLength(255)]
    //    public string Ccode { get; set; }
    //    [Column("buserid")]
    //    [StringLength(255)]
    //    public string Buserid { get; set; }
    //    [Column("rechagetype")]
    //    public int Rechagetype { get; set; }
    //    [Column("tranceid")]
    //    [StringLength(255)]
    //    public string Tranceid { get; set; }
    //    [Column("costptid")]
    //    [StringLength(255)]
    //    public string Costptid { get; set; }
    //    [Column("costmoney")]
    //    [StringLength(255)]
    //    public string Costmoney { get; set; }
    //    [Column("uaccount")]
    //    [StringLength(255)]
    //    public string Uaccount { get; set; }
    //    [Column("depositplatform")]
    //    public int Depositplatform { get; set; }
    //    [Column("aubalancedate")]
    //    [StringLength(255)]
    //    public string Aubalancedate { get; set; }
    //    [Column("rid")]
    //    [StringLength(255)]
    //    public string Rid { get; set; }
    //    [Column("balancedate")]
    //    [StringLength(255)]
    //    public string Balancedate { get; set; }
    //    [Column("hedginggroup")]
    //    [StringLength(255)]
    //    public string Hedginggroup { get; set; }
    //    [Column("remark")]
    //    [StringLength(255)]
    //    public string Remark { get; set; }
    //    [Column("istate")]
    //    public int Istate { get; set; }
    //    [Column("uid")]
    //    [StringLength(255)]
    //    public string Uid { get; set; }
    //    [Column("utccreatetime")]
    //    public DateTime Utccreatetime { get; set; }
    //    [Column("chargebackplatform")]
    //    public int Chargebackplatform { get; set; }
    //    //[Column("sopids")]
    //    //[StringLength(255)]
    //    //public string Sopids { get; set; }
    //    [Column("umoney")]
    //    public double Umoney { get; set; }
    //    [Column("deducttype")]
    //    public int Deducttype { get; set; }
    //    [Column("feestype")]
    //    public int Feestype { get; set; }
    //    [Column("ordercount")]
    //    public double Ordercount { get; set; }
    //    [Column("ioflag")]
    //    public int Ioflag { get; set; }
    //    [Column("synmongoflag")]
    //    [StringLength(255)]
    //    public bool Synmongoflag { get; set; }
    //    [Column("hedgingflag")]
    //    public int Hedgingflag { get; set; }
    //    [Column("utccanceltime")]
    //    public DateTime Utccanceltime { get; set; }
    //    [Column("bauserid")]
    //    [StringLength(255)]
    //    public string Bauserid { get; set; }
    //    [Column("leftmoney")]
    //    public double Leftmoney { get; set; }
    //    [Column("balancecycle")]
    //    [StringLength(255)]
    //    public string Balancecycle { get; set; }
    //    [Column("ciid")]
    //    [StringLength(255)]
    //    public string Ciid { get; set; }
    //    [Column("operatedate")]
    //    public DateTime Operatedate { get; set; }
    //    [Column("orderid")]
    //    [StringLength(255)]
    //    public string Orderid { get; set; }

    //    //[Column("userfeesclassitemslist")]
    //    //public string Userfeesclassitemslist { get; set; }

    //    [Column("weight")]
    //    [StringLength(255)]
    //    public string Weight { get; set; }
    //    [Column("dan")]
    //    [StringLength(255)]
    //    public string Dan { get; set; }

    //    //[Column("costposttypefeesclassitemslist")]
    //    //public string Costposttypefeesclassitemslist { get; set; }

    //    [Column("fsname")]
    //    [StringLength(255)]
    //    public string Fsname { get; set; }
    //    [Column("userid")]
    //    public int Userid { get; set; }
    //    [Column("transno")]
    //    [StringLength(255)]
    //    public string Transno { get; set; }
    //    [Column("costposttypename")]
    //    [StringLength(255)]
    //    public string Costposttypename { get; set; }

    //    [Column("ptid")]
    //    [StringLength(255)]
    //    public string Ptid { get; set; }
    //    [Key]
    //    [Column("_id")]
    //    [StringLength(255)]
    //    public string Id { get; set; }
    //    [Column("utcmodifytime")]
    //    public DateTime Utcmodifytime { get; set; }
    //    [Column("hedgingid")]
    //    [StringLength(255)]
    //    public string Hedgingid { get; set; }
    //    [Column("posttypename")]
    //    [StringLength(255)]
    //    public string Posttypename { get; set; }
    //}

    /// <summary>
    /// 客户费用记录表
    /// </summary>
    [Table("UserMoneyRecord")]
    public partial class UserMoneyRecord
    {
        ///<summary>
        ///费用记录序号
        ///</summary>
        [Key]
        public string Id { get; set; }

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
        public int DepositPlatform { get; set; }

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
        public int FeesType { get; set; }

        ///<summary>
        ///充值类型 现金 Cash = 0,银行到账 BankTransfer = 1 快钱 KuaiQian = 2
        ///</summary>
        public int RechageType { get; set; }

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
        public int IoFlag { get; set; }

        ///<summary>
        ///结算状态0=新增  1=已结算      --操作员点击计算按钮后，不容许对该记录做删除、重算等操作，主要是针对返回费用等             2=结算不通过  --可以做重算等操作  3=结算已通过  -- 不许做任何更新、删除操作
        ///</summary>
        public int IState { get; set; }

        ///<summary>
        ///数据类型标识 0=原数据 1=对冲数据 2=新数据
        ///</summary>
        public int HedgingFlag { get; set; }

        /// <summary>
        /// 对冲组号（方便归组）
        /// </summary>
        public string HedgingGroup { get; set; }


        ///<summary>
        ///扣费类型 0 =非扣费 1=客户 2= 点
        ///</summary>
        public int DeDuctType { get; set; }

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
        public string HedgingId { get; set; }

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
        public int ChargebackPlatform { get; set; }

        /// <summary>
        /// 计算提示信息
        /// </summary>
        public string CountInfor { get; set; }

        /// <summary> 
        /// 包装类型 (子邮递方式)
        /// </summary>
        public int PackType { set; get; }

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
