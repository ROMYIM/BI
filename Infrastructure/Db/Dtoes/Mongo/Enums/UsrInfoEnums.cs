using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Enums
{
    /// <summary>
    /// 客户帐号类型枚举
    /// </summary>
    public enum UserAccountType
    {
        [Description("客户账号")]
        OutUAmount = 0,
        [Description("收货点账号")]
        FlytDeliveAreaAmount = 1
    }

    /// <summary>
    /// 客户信誉级别枚举
    /// </summary>
    public enum UsersInfoCreditRating
    {
        [Description("一般")]
        Normal = 1,
        [Description("优质")]
        HighQuality = 2,
        [Description("良好")]
        Good = 3,
        [Description("合格")]
        Qualified = 4,
        [Description("不合格")]
        NonQualified = 5,
    }

    /// <summary>
    /// 行业产品类型
    /// </summary>
    public enum ProductsType
    {
        [Description("服饰")] Dress = 1,

        [Description("汽配")] AutoParts = 2,

        [Description("电子产品")] ElectronicProduct = 3,

        [Description("五金")] Hardware = 4,

        [Description("玩具")] Toys = 5,

        [Description("首饰")] Jewelry = 6,

        [Description("皮具")] Leather = 7,

        [Description("灯饰")] Lighting = 8,

        [Description("机械")] Mechanics = 9,

        [Description("化工产品")] ChemicalProducts = 10,

        [Description("家具")] Furniture = 11,

        [Description("家用电器")] HouseholdElectricalAppliances = 12,

        [Description("建筑材料")] BuildingMaterial = 13
    }

    /// <summary>
    /// 实名认证方式
    /// </summary>
    public enum UserAuthenticationType
    {
        [Description("未验证")]
        Default = 0,
        [Description("个人验证")]
        Person = 1,
        [Description("公司验证")]
        Enterprise = 2
    }

    /// <summary>
    /// 客户类别
    /// </summary>
    public enum CustomType
    {
        /// <summary>
        /// 其它（用于后台默认，不显示）
        /// </summary>
        [Description("其它")] Other = -1,

        /// <summary>
        /// 成本客户价
        /// </summary>
        [Description("成本价")] CostCustomer = 0,

        /// <summary>
        /// 棒谷客户价
        /// </summary>
        [Description("棒谷价")] BangGood = 1,

        /// <summary>
        /// 飞特客户价
        /// </summary>
        [Description("飞特价")] FlytUser = 2,

        /// <summary>
        ///公布价客户价
        /// </summary>
        [Description("公布价")] PulbicUser = 3,

        /// <summary>
        /// 结算客户价
        /// </summary>
        [Description("结算价")] SettlementUser = 4,

        /// <summary>
        /// 棒谷成本价
        /// </summary>
        [Description("棒谷成本价")] BanggoodCostCustomer = 5,

        /// <summary>
        /// 飞特成本价
        /// </summary>
        [Description("飞特成本价")] FlytCostCustomer = 6,

        /// <summary>
        /// 飞特价A类
        /// </summary>
        [Description("飞特价A类")] FlytAClass = 7,

        /// <summary>
        /// 飞特价B类
        /// </summary>
        [Description("飞特价B类")] FlytBClass = 8,

        /// <summary>
        /// 飞特价C类
        /// </summary>
        [Description("飞特价C类")] FlytCClass = 9,

        /// <summary>
        /// 飞特价D类
        /// </summary>
        [Description("飞特价D类")] FlytDClass = 10,

        /// <summary>
        /// 飞特价E类
        /// </summary>
        [Description("飞特价E类")] FlytEClass = 11,

        /// <summary>
        /// 飞特价F类
        /// </summary>
        [Description("飞特价F类")] FlytFClass = 12,

        /// <summary>
        /// 飞特价G类
        /// </summary>
        [Description("飞特价G类")] FlytGClass = 13,

        /// <summary>
        /// 飞特价H类
        /// </summary>
        [Description("飞特价H类")] FlytHClass = 14,

        /// <summary>
        /// 飞特价I类
        /// </summary>
        [Description("飞特价I类")] FlytIClass = 15,

        /// <summary>
        /// 飞特价J类
        /// </summary>
        [Description("飞特价J类")] FlytJClass = 16,

        /// <summary>
        /// 飞特价K类
        /// </summary>
        [Description("飞特价K类")] FlytKClass = 17,

        /// <summary>
        /// 飞特价L类
        /// </summary>
        [Description("飞特价L类")] FlytLClass = 18,

        /// <summary>
        /// 飞特价M类
        /// </summary>
        [Description("飞特价M类")] FlytMClass = 19,

        /// <summary>
        /// 飞特价N类
        /// </summary>
        [Description("飞特价N类")] FlytNClass = 20,

        /// <summary>
        /// 飞特价O类
        /// </summary>
        [Description("飞特价O类")] FlytOClass = 21,

        /// <summary>
        /// 飞特价P类
        /// </summary>
        [Description("飞特价P类")] FlytPClass = 22,

        /// <summary>
        /// 飞特价Q类
        /// </summary>
        [Description("飞特价Q类")] FlytQClass = 23,

        /// <summary>
        /// 飞特价R类
        /// </summary>
        [Description("飞特价R类")] FlytRClass = 24,

        /// <summary>
        /// 飞特价s类
        /// </summary>
        [Description("飞特价S类")] FlytSClass = 25,

        /// <summary>
        /// 飞特价T类
        /// </summary>
        [Description("飞特价T类")] FlytTClass = 26,

        /// <summary>
        /// 飞特价U类
        /// </summary>
        [Description("飞特价U类")] FlytUClass = 27,

        /// <summary>
        /// 飞特价V类
        /// </summary>
        [Description("飞特价V类")] FlytVClass = 28,

        /// <summary>
        /// 飞特价W类
        /// </summary>
        [Description("飞特价W类")] FlytWClass = 29,

        /// <summary>
        /// 飞特价X类
        /// </summary>
        [Description("飞特价X类")] FlytXClass = 30,

        /// <summary>
        /// 飞特价Y类
        /// </summary>
        [Description("飞特价Y类")] FlytYClass = 31,

        /// <summary>
        /// 飞特价Z类
        /// </summary>
        [Description("飞特价Z类")] FlytZClass = 32,

        /// <summary>
        /// 飞特价AA类
        /// </summary>
        [Description("飞特价AA类")] FlytAaClass = 33,

        /// <summary>
        /// 飞特价AB类
        /// </summary>
        [Description("飞特价AB类")] FlytAbClass = 34,

        /// <summary>
        /// 飞特价AC类
        /// </summary>
        [Description("飞特价AC类")] FlytAcClass = 35,

        /// <summary>
        /// 飞特价AF类
        /// </summary>
        [Description("飞特价AF类")] FlytAfClass = 37,

        /// <summary>
        /// 飞特价AG类
        /// </summary>
        [Description("飞特价AG类")] FlytAgClass = 38,

        /// <summary>
        /// 飞特价AH类
        /// </summary>
        [Description("飞特价AH类")] FlytAhClass = 39,

        /// <summary>
        /// 飞特价AI类
        /// </summary>
        [Description("飞特价AI类")] FlytAiClass = 40,
        /// <summary>
        /// 飞特价AJ类
        /// </summary>
        [Description("飞特价AJ类")] FlytAjClass = 41,
        /// <summary>
        /// 飞特价AK类
        /// </summary>
        [Description("飞特价AK类")] FlytAkClass = 42,
        /// <summary>
        /// 飞特价AL类
        /// </summary>
        [Description("飞特价AL类")] FlytAlClass = 43,
        /// <summary>
        /// 飞特价AM类
        /// </summary>
        [Description("飞特价AM类")] FlytAmClass = 44,
        /// <summary>
        /// 飞特价AO类
        /// </summary>
        [Description("飞特价AO类")] FlytAoClass = 45,
        /// <summary>
        /// 飞特价AP类
        /// </summary>
        [Description("飞特价AP类")] FlytApClass = 46,
        /// <summary>
        /// 飞特价AQ类
        /// </summary>
        [Description("飞特价AQ类")] FlytAqClass = 47,
        /// <summary>
        /// 飞特价AR类
        /// </summary>
        [Description("飞特价AR类")] FlytArClass = 48,
        /// <summary>
        /// 飞特价AS类
        /// </summary>
        [Description("飞特价AS类")] FlytAsClass = 49,
        /// <summary>
        /// 飞特价AT类
        /// </summary>
        [Description("飞特价AT类")] FlytAtClass = 50,
        /// <summary>
        /// 飞特价AU类
        /// </summary>
        [Description("飞特价AU类")] FlytAuClass = 51,
        /// <summary>
        /// 飞特价AV类
        /// </summary>
        [Description("飞特价AV类")] FlytAvClass = 52,
        /// <summary>
        /// 飞特价AX类
        /// </summary>
        [Description("飞特价AX类")] FlytAxClass = 54,
        /// <summary>
        /// 飞特价AY类
        /// </summary>
        [Description("飞特价AY类")] FlytAyClass = 55,
        /// <summary>
        /// 飞特价AZ类
        /// </summary>
        [Description("飞特价AZ类")] FlytAzClass = 56,
        /// <summary>
        /// 飞特价BA类
        /// </summary>
        [Description("飞特价BA类")] FlytBaClass = 57,
        /// <summary>
        /// 飞特价BB类
        /// </summary>
        [Description("飞特价BB类")] FlytBbClass = 58,
        /// <summary>
        /// 飞特价BC类
        /// </summary>
        [Description("飞特价BC类")] FlytBcClass = 59,
        /// <summary>
        /// 飞特价BD类
        /// </summary>
        [Description("飞特价BD类")] FlytBdClass = 60,
        /// <summary>
        /// 飞特价BD类
        /// </summary>
        [Description("飞特价BE类")] FlytBeClass = 61,
        /// <summary>
        /// 飞特价BD类
        /// </summary>
        [Description("飞特价BF类")] FlytBfClass = 62,
        /// <summary>
        /// 飞特价BD类
        /// </summary>
        [Description("飞特价BG类")] FlytBgClass = 63,
        /// <summary>
        /// 飞特价BD类
        /// </summary>
        [Description("飞特价BH类")] FlytBhClass = 64,
        /// <summary>
        /// 飞特价BD类
        /// </summary>
        [Description("飞特价BI类")] FlytBiClass = 65,
        /// <summary>
        /// 飞特价BD类
        /// </summary>
        [Description("飞特价BJ类")] FlytBjClass = 66,
        /// <summary>
        /// 飞特价BD类
        /// </summary>
        [Description("飞特价BK类")] FlytBkClass = 67,
        /// <summary>
        /// 飞特价BD类
        /// </summary>
        [Description("飞特价BL类")] FlytBlClass = 68,
        /// <summary>
        /// 飞特价BD类
        /// </summary>
        [Description("飞特价BM类")] FlytBmClass = 69,
        /// <summary>
        /// 飞特价BD类
        /// </summary>
        [Description("飞特价BN类")] FlytBnClass = 70,

    }
}
