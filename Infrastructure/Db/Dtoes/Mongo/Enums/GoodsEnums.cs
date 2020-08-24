using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Enums
{
    /// <summary>
    /// 货物种类
    /// </summary>
    public enum FreightType
    {
        [Description("普货")]
        NormalFreight = 0,

        [Description("带电")]
        Electrify = 1,

        [Description("纯电")]
        PureElectric = 2,

        [Description("液体(不接白色)")]
        Liquid = 3,

        [Description("粉末（不接白色）")]
        Powder = 4,

        [Description("膏状物")]
        Cream = 5,
    }
}
