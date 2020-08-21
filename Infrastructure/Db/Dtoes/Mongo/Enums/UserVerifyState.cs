using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Enums
{
    /// <summary>
    /// 用户审核状态
    /// </summary>
    public enum UserVerifyState
    {
        [Description("不通过")] NonPass = 0,
        [Description("通过")] Pass = 1,
    }
}
