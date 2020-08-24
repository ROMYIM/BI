using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Enums
{
    /// <summary>
    /// 证件类型枚举
    /// </summary>
    public enum IdentityCard
    {
        [Description(" ")]
        Default = 0,

        //[Description("学生证")]
        //Student = 1,

        [Description("护照")]
        PassPort = 2,

        [Description("身份证")]
        Person = 3,

        [Description("营业执照号码")]
        BinuessLicence = 4,

        [Description("组织机构代码")]
        Organization = 5,

        //[Description("其它")]
        //Other = 6
    }

    /// <summary>
    /// 身份识别类型
    /// </summary>
    public enum IdentityType
    {
        [Description("未定义")]
        UnIdentity = 0,

        [Description("个人身份证")]
        Person = 1,

        [Description("统一社会信用代码")]
        UnifiedSocialCreditCode = 2,

        //[Description("护照")]
        //PassPort = 3,
    }
}
