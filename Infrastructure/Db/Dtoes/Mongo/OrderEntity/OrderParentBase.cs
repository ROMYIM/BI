using System;
using System.Collections.Generic;
using System.Linq;
using Core.DataBase.Mongo.Models;
using Infrastructure.Db.Dtoes.Mongo.Enums;
using Infrastructure.Db.Dtoes.Mongo.OrderEntity;

namespace Infrastructure.Db.Dotes.Mongo.OrderEntity
{
    /// <summary>
    /// 订单主表基础类
    /// </summary>
    public class OrderParentBase : MongoDbVersionPo
    {
        /// <summary> 
        /// 分拆地址1
        /// </summary>
        public string Address1 { set; get; }

        /// <summary> 
        /// 分拆地址2
        /// </summary>
        public string Address2 { set; get; }

        /// <summary>
        /// 收件人公司
        /// </summary>
        public string ReceiverCompany { get; set; }

        private List<string> _apiOrderIds;

        /// <summary> 
        /// 第三方接口订单号
        /// </summary>
        public List<string> ApiOrderIds
        {
            get { return _apiOrderIds ??= new List<string>(); }
            set
            {
                _apiOrderIds = value;
                FirstApiOrderId = value == null
                    ? string.Empty
                    : value.FirstOrDefault();
            }
        }

        /// <summary>
        /// 记录第一个第三方接口订单号
        /// </summary>
        public string FirstApiOrderId { get; private set; }

        /// <summary> 
        /// 买家Id
        /// </summary>
        public string BuyerId { set; get; }

        /// <summary> 
        /// 城市
        /// </summary>
        public string City { set; get; }

        /// <summary> 
        /// 国家表标识
        /// </summary>
        public string CiId { set; get; }

        /// <summary>
        /// 收货人国家缩写
        /// </summary>
        public string ReceiverStateAbbreviation { get; set; }

        /// <summary> 
        /// 订单确认后备注
        /// </summary>
        public string ConfirmedRemark { set; get; }

        /// <summary> 
        /// 州
        /// </summary>
        public string County { set; get; }

        private string _cCode;

        /// <summary>
        /// 运费货币代码 
        /// </summary>
        public string CCode
        {
            get { return _cCode; }
            set { _cCode = value?.Trim(); }
        }

        /// <summary> 
        /// 报关货币代码
        /// </summary>
        public string HaikwanCCode { set; get; }

        /// <summary>
        /// 是否签名
        /// </summary>
        public bool DeliveryType { set; get; }

        /// <summary> 
        /// 收件人Email
        /// </summary>
        public string Email { set; get; }

        /// <summary> 
        /// 物流运费
        /// </summary>
        public decimal Freight { set; get; }

        /// <summary> 
        /// 报关物品类型(用于指定所有报关明细的物品类型  Stdmode 枚举)
        /// </summary>
        public Stdmode GoodsType { set; get; }

        /// <summary> 
        /// 报关产品ID (用于指定所有报关明细的产品ID)，一般是客人设置的SKU
        /// </summary>
        public string HaikwanProductId { set; get; }

        /// <summary> 
        /// 订单编号
        /// </summary>
        public string Id { set; get; }

        /// <summary> 
        /// 导入时间(订单入库时间)
        /// </summary>
        public DateTime ImportTime { set; get; }

        /// <summary>
        /// 重量单位
        /// </summary>
        public WeightUnit WeightUnit { get; set; }

        /// <summary> 
        /// 是否已扣费
        /// </summary>
        public bool IsDeducted { set; get; }



        /// <summary>
        /// 是否合并主单 [0=否 1=是]
        /// </summary>
        public bool IsParent { get; set; }

        /// <summary>
        /// 是否被拆分过 [0=否 1=是]
        /// </summary>
        public bool IsSplit { get; set; }

        /// <summary> 
        /// 是否已打印
        /// </summary>
        public bool IsPrinted { set; get; }

        private int _multiPackageQuantity;

        /// <summary> 
        /// 一票多件件数
        /// </summary>
        public int MultiPackageQuantity
        {
            get { return _multiPackageQuantity > 0 ? _multiPackageQuantity : 1; }
            set { _multiPackageQuantity = value; }
        }

        /// <summary> 
        /// 线上货运方式名称
        /// </summary>
        public string OnlineShippingType { set; get; }

        /// <summary> 
        /// 线上店铺名
        /// </summary>
        public string OnlineShopName { set; get; }

        private DateTime _operateTime;

        /// <summary> 
        /// 操作时间
        /// </summary>
        public DateTime OperateTime
        {
            set { _operateTime = DateTime.Now; }
            get { return _operateTime; }
        }

        /// <summary> 
        /// 运单类型 (0=普通订单[Axxx] 1=调拨单)
        /// </summary>
        public OrderType OrderType { set; get; }

        /// <summary> 
        /// 订单体积
        /// </summary>
        public double OrderVolume { set; get; }

        /// <summary>
        /// 长
        /// </summary>
        public double Length { get; set; }

        /// <summary>
        /// 宽
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// 高
        /// </summary>
        public double Height { get; set; }

        /// <summary> 
        /// 订单状态ID
        /// </summary>
        public OrderState OsId { set; get; }

        /// <summary> 
        /// 包装类型 (子邮递方式)
        /// </summary>
        public PackType PackType { set; get; }

        /// <summary> 
        /// 付款时间
        /// </summary>
        public DateTime PaymentTime { set; get; }

        /// <summary> 
        /// 电话
        /// </summary>
        public string Phone { set; get; }

        /// <summary> 
        /// 交寄时间
        /// </summary>
        public DateTime PostedTime { set; get; }

        /// <summary> 
        /// 处理中心ID
        /// </summary>
        public string ProcessCenterId { set; get; }

        /// <summary> 
        /// 邮递方式表标识
        /// </summary>
        public string PtId { set; get; }

        /// <summary> 
        /// 收货时间
        /// </summary>
        public DateTime ReceivedTime { set; get; }

        /// <summary> 
        /// 收件人姓名
        /// </summary>
        public string ReceiverName { set; get; }

        /// <summary> 
        /// 备注
        /// </summary>
        public List<string> Remarks { set; get; }

        /// <summary> 
        /// 收货门店（点)
        /// </summary>
        public string RsId { set; get; }

        /// <summary> 
        /// 销售平台标识 [0=默认(不区分);1=ebay;2=amazon(亚马逊);3=aliexpress(速卖通)]
        /// </summary>
        public SalesPlatformFlag SalesPlatformFlag { set; get; }

        /// <summary> 
        /// 销售平台客户留言
        /// </summary>
        public string SalesPlatformMsg { set; get; }

        /// <summary> 
        /// 销售平台交易号
        /// </summary>
        public List<string> SalesPlatformTransactionIds { set; get; }

        /// <summary> 
        /// 销售平台站点
        /// </summary>
        public string SalesPlatformWebsit { set; get; }

        /// <summary> 
        /// 拣货时间
        /// </summary>
        public DateTime PickTime { set; get; }

        /// <summary> 
        /// 发货时间
        /// </summary>
        public DateTime SentTime { set; get; }

        /// <summary> 
        /// 订单同步平台标识 (第三方平台在权限表的的GUID)(废弃)
        /// </summary>
        public Guid? SyncPlatformFlag { set; get; }

        /// <summary> 
        /// 订单总金额
        /// </summary>
        public decimal TotalPrice { set; get; }

        /// <summary>
        /// 订单总价货币符号
        /// </summary>
        public string TotalPriceCCode { set; get; }


        /// <summary> 
        /// 跟踪号
        /// </summary>
        public string TraceId { set; get; }

        /// <summary> 
        /// 物流账号
        /// </summary>
        public string UAccount { set; get; }

        /// <summary> 
        /// 物流收货重量（计算重量）
        /// </summary>
        public double Weight { set; get; }

        /// <summary>
        /// 客户输入重量(即称重重量)
        /// </summary>
        public double InputWeight { get; set; }

        /// <summary>
        /// 计费重量
        /// </summary>
        public double CountWeight { get; set; }

        /// <summary>
        /// 计费重量单位
        /// </summary>
        public WeightUnit CountWeightUnit { get; set; }

        /// <summary> 
        /// 邮编
        /// </summary>
        public string Zip { set; get; }

        /// <summary>
        /// 收件人税号
        /// </summary>
        public string TaxNumber { get; set; }

        /// <summary>
        /// 寄件人税号
        /// </summary>
        public string SenderTaxNumber { get; set; }

        /// <summary>
        /// 是否回传跟踪号标识
        /// </summary>
        public bool HasReturnedTraceId { get; set; }

        ///// <summary>
        ///// 订单客户类别（修改订单重新平账、扣费用）
        ///// </summary>
        //public CustomType OrderCustomerType { get; set; }

        private List<int> _salesRecordNumbers;

        /// <summary>
        /// 第三方平台销售记录号
        /// </summary>
        public List<int> SalesRecordNumbers
        {
            get { return _salesRecordNumbers ??= new List<int>(); }
            set { _salesRecordNumbers = value; }
        }

        private List<OrderDetail> _orderDetailList;

        /// <summary>
        /// 订单明细
        /// </summary>
        public List<OrderDetail> OrderDetailList
        {
            get { return _orderDetailList ??= new List<OrderDetail>(); }
            set
            {
                _orderDetailList = value;
                OrderDetailsFirstSku = value == null
                    ? string.Empty
                    : value.Where(a => a.Sku != null).Select(n => n.Sku).FirstOrDefault();
            }
        }

        /// <summary>
        /// 订单报关详情第一个有值的SKU记录(排序用)
        /// </summary>
        public string OrderDetailsFirstSku { get; set; }

        private List<HaikwanDetail> _haikwanDetailList;

        /// <summary>
        /// 报关明细
        /// </summary>
        public List<HaikwanDetail> HaikwanDetialList
        {
            get { return _haikwanDetailList ??= new List<HaikwanDetail>(); }
            set { _haikwanDetailList = value; }
        }

        /// <summary>
        /// 是否已删除
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// 是否预付关税
        /// </summary>
        public bool IsPayTariffs { get; set; }

        /// <summary>
        /// 报关物品类型ID (用于指定所有报关明细的物品类型)
        /// </summary>
        public string HaikwanGtId { get; set; }

        /// <summary>
        /// 最后一次打印时间
        /// </summary>
        public DateTime LastPrintTime { get; set; }

        /// <summary>
        /// 新erp第三方平台标识
        /// </summary>
        public string NewSyncPlatformFlag { set; get; }

        /// <summary>
        /// 分箱单号集合
        /// </summary>
        public List<string> MultiPackageIds { get; set; }

        /// <summary>
        /// 保险金额
        /// </summary>
        public decimal InsuredAmount { get; set; }

        /// <summary>
        /// 保费
        /// </summary>
        public decimal Premium { get; set; }

        /// <summary>
        /// 回邮地址
        /// </summary>
        public string ReturnAddress { get; set; }

        private string _platformWarehouseCode;

        /// <summary>
        /// 平台仓库代码 
        /// </summary>
        public string PlatformWarehouseCode
        {
            get => _platformWarehouseCode;
            set => _platformWarehouseCode = value?.Trim();
        }

        /// <summary>
        /// 走货渠道简码
        /// </summary>
        public string ChannelCode { get; set; }

        /// <summary>
        /// 渠道跟踪号
        /// </summary>
        public string ChannelTraceId { get; set; }

        /// <summary>
        /// 是否自带跟踪号
        /// </summary>
        public bool WhetherByoTraceId { get; set; }
    }
}
