using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Enums
{
    /// <summary>
    /// 物品类型
    /// </summary>
    public enum Stdmode
    {
        /// <summary>
        /// 礼物
        /// </summary>
        [Description("礼物")]
        Gift = 0,
        /// <summary>
        /// 文件
        /// </summary>
        [Description("文件")]
        File = 1,
        /// <summary>
        /// 商业样本
        /// </summary>
        [Description("商业样本")]
        BusinessSample = 2,
        /// <summary>
        /// 退回商品
        /// </summary>
        [Description("退回货品")]
        ReturnGoods = 3,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        Other = 4,

    }
}
