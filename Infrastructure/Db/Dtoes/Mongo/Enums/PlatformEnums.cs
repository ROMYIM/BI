using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Enums
{
    /// <summary>
    /// 销售平台类型
    /// </summary>
    public enum SalesPlatformFlag
    {
        /// <summary>
        /// 未定义销售平台
        /// </summary>
        [Description("未定义销售平台")] Non = 0,

        /// <summary>
        /// Ebay
        /// </summary>
        [Description("eBay")] eBay = 1,

        /// <summary>
        /// 亚马逊
        /// </summary>
        [Description("亚马逊")] Amazon = 2,

        /// <summary>
        /// 速卖通
        /// </summary>
        [Description("速卖通")] AliExpress = 3,

        /// <summary>
        /// Wish
        /// </summary>
        [Description("Wish")] Wish = 4,

        /// <summary>
        /// 来赞达
        /// </summary>
        [Description("来赞达")] Lazada = 5,

        /// <summary>
        /// Lazada
        /// </summary>
        [Description("镖局")] BiaoJu = 6,

        /// <summary>
        /// WholeSale
        /// </summary>
        [Description("WholeSale")] WholeSale = 7,

        /// <summary>
        /// Linio
        /// </summary>
        [Description("Linio")] Linio = 8,

        /// <summary>
        /// 壹零客
        /// </summary>
        [Description("壹零客")] Yilinker = 9,

        /// <summary>
        /// Cdiscount
        /// </summary>
        [Description("Cdiscount")] Cdiscount = 10,

        /// <summary>
        /// Priceminister
        /// </summary>
        [Description("Priceminister")] Priceminister = 11,

        /// <summary>
        /// Shopee
        /// </summary>
        [Description("Shopee")] Shopee = 12,

        /// <summary>
        /// banggood
        /// </summary>
        [Description("banggood")] OsCommerce = 13,

        /// <summary>
        /// zenCart
        /// </summary>
        [Description("zenCart")] ZenCart = 14,

        /// <summary>
        /// 淘宝
        /// </summary>
        [Description("淘宝")] Taobao = 15,

        /// <summary>
        /// 敦煌
        /// </summary>
        [Description("Dh")] Dh = 16,

        /// <summary>
        /// 新蛋网
        /// </summary>
        [Description("新蛋")] Ne = 17,

        /// <summary>
        /// iOffer销售平台
        /// </summary>
        [Description("ioffer")] Ioffer = 18,

        /// <summary>
        /// Yoins
        /// </summary>
        [Description("Yoins")] Yoins = 19,

        /// <summary>
        /// Blanja
        /// </summary>
        [Description("Blanja")] Blanja = 20,

        /// <summary>
        /// 京东
        /// </summary>
        [Description("京东")] Jd = 21,

        /// <summary>
        /// Wanelo
        /// </summary>
        [Description("Wanelo")] Wanelo = 22,

        /// <summary>
        /// NewChic
        /// </summary>
        [Description("NewChic")] NewChic = 23,

        /// <summary>
        /// PriceMinister
        /// </summary>
        [Description("PriceMinister")] PriceMinister = 24,

        /// <summary>
        /// Kilimall
        /// </summary>
        [Description("Kilimall")] Kilimall = 25,

        /// <summary>
        /// Walmart
        /// </summary>
        [Description("Walmart")] Walmart = 26,

        /// <summary>
        /// JOOM
        /// </summary>
        [Description("JOOM")] Joom = 27,

        /// <summary>
        /// 11Street
        /// </summary>
        [Description("11Street")] Street11 = 28,

        /// <summary>
        /// Smt AE
        /// </summary>
        [Description("AE")] Smt = 29,

        /// <summary>
        /// Shopify
        /// </summary>
        [Description("Shopify")] Shopify = 30,

        /// <summary>
        /// Vova
        /// </summary>
        [Description("Vova")] Vova = 31,


        /// <summary>
        /// 自主网站
        /// </summary>
        [Description("自主网站")] SelfWebsite = 998,

        /// <summary>
        ///  其他
        /// </summary>
        [Description("其他")] Other = 999,
    }
}
