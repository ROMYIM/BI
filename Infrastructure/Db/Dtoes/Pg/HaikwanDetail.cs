using Core.DataAnnotations.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    /// <summary> 
    ///订单报关明细表
    /// </summary>
    [Table("HaikwanDetail")]
    [ChildrenTable(ParentTable = "OrderParent")]
    public class HaikwanDetail
    {  
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary> 
        /// 海关编码
        /// </summary>
        public string HwCode { set; get; }

        /// <summary> 
        /// 物品中文名称
        /// </summary>
        public string ItemCnName { set; get; }

        /// <summary> 
        /// 物品英文名称
        /// </summary>
        public string ItemEnName { set; get; }

        /// <summary> 
        /// 物品ID,平台物品标示
        /// </summary>
        public string ItemId { set; get; }

        /// <summary> 
        /// 产地
        /// </summary>
        public string ProducingArea { set; get; }

        /// <summary> 
        /// 物品数量
        /// </summary>
        public int Quantities { set; get; }

        /// <summary> 
        /// 真实价格
        /// </summary>
        public decimal RealPrice { set; get; }

        /// <summary> 
        /// 备注
        /// </summary>
        public string Remark { set; get; }

        /// <summary> 
        /// 产品编号(SKU)
        /// </summary>
        public string Sku { set; get; }

        /// <summary> 
        /// 报关单价
        /// </summary>
        public decimal UnitPrice { set; get; }

        /// <summary> 
        /// 重量
        /// </summary>
        public double Weight { set; get; }

        /// <summary>
        /// 电池类型Id
        /// </summary>
        public string BtId { get; set; }

        private string _fbaNumber;
        /// <summary>
        /// FBA单号
        /// </summary>
        public string FbaNumber
        {
            get => _fbaNumber ?? "";
            set => _fbaNumber = value ?? "";
        }

        /// <summary>
        /// 货币代码 
        /// </summary>
        public string CCode { get; set; }

        /// <summary>
        /// 品牌(FBA必填)
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// 型号(FBA必填)
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// 用途(FBA必填)
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// 材质(FBA必填)
        /// </summary>
        public string Material { get; set; }

        [ForeginKeyColumn]
        public string OrderId { get; set; }

    }
}
