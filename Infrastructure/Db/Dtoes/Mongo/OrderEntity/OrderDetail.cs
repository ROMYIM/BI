using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.OrderEntity
{
    /// <summary> 
    ///订单明细表
    /// </summary>
    public class OrderDetail
    {
        public Guid Id { get; set; }

        /// <summary> 
        /// 物品颜色
        /// </summary>
        public string Color { set; get; }
        private decimal _freight;
        /// <summary>
        /// 运费 
        /// </summary>
        public decimal Freight
        {
            get { return _freight; }
            set { _freight = value < 0 ? 0 : value; }
        }
        /// <summary> 
        /// 物品ID
        /// </summary>
        public string ItemId { set; get; }
        /// <summary> 
        /// 物品序号
        /// </summary>
        public int ItemIndex { set; get; }
        /// <summary> 
        /// 物品名称
        /// </summary>
        public string ItemName { set; get; }
        /// <summary> 
        /// 物品交易号
        /// </summary>
        public string ItemTransactionId { set; get; }
        /// <summary> 
        /// 合并订单的原始ID
        /// </summary>
        public string MergeOriginalOrderId { set; get; }
        /// <summary> 
        /// 原平台ID(即销售平台或第三方同步平台)
        /// </summary>
        public string OriginalPlatformOrderId { set; get; }
        /// <summary> 
        /// Poa
        /// </summary>
        public string Poa { set; get; }

        private decimal _price;
        /// <summary>
        /// 价格 
        /// </summary>
        public decimal Price
        {
            get { return _price; }
            set { _price = value < 0 ? 0 : value; }
        }
        private int _quantities;
        /// <summary>
        /// 数量 
        /// </summary>
        public int Quantities
        {
            get { return _quantities; }
            set { _quantities = value < 0 ? 0 : value; }
        }
        /// <summary> 
        /// 备注
        /// </summary>
        public string Remark { set; get; }

        private decimal _salePrice;
        /// <summary>
        /// 销售价格 
        /// </summary>
        public decimal SalePrice
        {
            get { return _salePrice; }
            set { _salePrice = value < 0 ? 0 : value; }
        }
        /// <summary> 
        /// 货号(SKU)
        /// </summary>
        public string Sku { set; get; }
        /// <summary> 
        /// 拆分订单的原始ID
        /// </summary>
        public string SplitOriginalOrderId { set; get; }
        /// <summary>
        /// 是否回传跟踪号标识
        /// </summary>
        public bool HasReturnedTraceId { get; set; }

        private string _platformWarehouseCode;

        /// <summary>
        /// 平台仓库代码 
        /// </summary>
        public string PlatformWarehouseCode
        {
            get => _platformWarehouseCode;
            set => _platformWarehouseCode = value?.Trim();
        }
    }
}
