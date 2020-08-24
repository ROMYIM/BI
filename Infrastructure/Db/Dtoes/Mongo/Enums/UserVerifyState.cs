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

    /// <summary>
    /// 客户信息状态
    /// </summary>
    public enum UsersInfoState
    {
        [Description("新增")] Create = 0,
        [Description("审核不通过")] AuditNotPass = 1,
        [Description("审核通过")] Audit = 2,
        [Description("停用")] Stop = 3,
        //[Description("删除")] Delete = 4,
        [Description("审核中")] InReview = 5
    }

    /// <summary>
    /// 客户审核状态
    /// </summary>
    public enum UserAuditState
    {
        [Description("待审核")] NonAudit = 0,
        [Description("销售审核不通过")] SaleAuditNonPass = 1,
        [Description("销售审核通过")] SaleAuditPass = 2,
        [Description("财务审核不通过")] FinanceAuditNonPass = 3,
        [Description("财务审核通过")] FinanceAuditPass = 4,
    }
}
