using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Enums
{
    /// <summary>
    /// 邮递方式分组
    /// </summary>
    public enum PostTypeGroup
    {
        /// <summary>
        /// 快递
        /// </summary>
        [Description("快递")] Express = 0,

        /// <summary>
        /// 国内小包平邮
        /// </summary>
        [Description("国内小包平邮")] DomesticPacket = 1,

        /// <summary>
        /// 外邮小包平邮
        /// </summary>
        [Description("外邮小包平邮")] ParcelPost = 2,

        /// <summary>
        /// 专线
        /// </summary>
        [Description("专线")] PostLine = 3,

        /// <summary>
        /// 大包
        /// </summary>
        [Description("大包")] AirParcel = 4,

        /// <summary>
        /// 美国仓
        /// </summary>
        [Description("美国仓")] AmericanWareHouse = 5,

        /// <summary>
        /// 英国仓
        /// </summary>
        [Description("英国仓")] BritishWareHouse = 6,

        /// <summary>
        /// 其它
        /// </summary>
        [Description("其它")] Other = 7,

        /*[Description("平邮")] SurfaceMail = 8,*/

        /// <summary>
        /// 空加派
        /// </summary>
        [Description("空加派")] AdditionalAir = 9,

        /// <summary>
        /// 国内小包挂号
        /// </summary>
        [Description("国内小包挂号")] DomesticPacketRegister = 10,

        /// <summary>
        /// 外邮小包挂号
        /// </summary>
        [Description("外邮小包挂号")] ParcelPostRegister = 11,

        /// <summary>
        /// 国际E邮宝
        /// </summary>
        [Description("国际E邮宝")] InternationalEub = 12
    }

    /// <summary>
    /// 一票多件取重方式
    /// </summary>
    public enum MultiGetWeightType : int
    {

        /// <summary>
        /// 体积重、实际重汇总取大值(默认)
        /// </summary>
        [Description("体积重、实际重汇总取大值")]
        GatherLarge = 0,
        /// <summary>
        /// 单件比较取大值汇总
        /// </summary>
        [Description("单件比较取大值汇总")]
        CompareLargeWeight = 1,
    }

    /// <summary>
    /// 邮递方式计费类型
    /// </summary>
    public enum PosttypeFeesType : int
    {
        /// <summary>
        /// 客户计费
        /// </summary>
        [Description("客户计费")]
        CustomerFees = 0,
        /// <summary>
        /// 核账计费
        /// </summary>
        [Description("核账计费")]
        CheckAccountsFees = 1,
    }

    /// <summary>
    /// 渠道类型
    /// </summary>
    public enum ChannelType
    {
        [Description("")] None = 0,

        /// <summary>
        /// 飞特产品
        /// </summary>
        [Description("飞特产品")] FlytProduct = 1,

        /// <summary>
        /// 第三方产品
        /// </summary>
        [Description("第三方产品")] ThirdPartProduct = 2
    }
}
