using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Enums
{
    /// <summary>
    /// 业务员分组类型
    /// </summary>
    public enum BusinessUserGroupType
    {
        [Description("区域")] Area = 1,
        [Description("团队")] Group = 2,
    }
}
