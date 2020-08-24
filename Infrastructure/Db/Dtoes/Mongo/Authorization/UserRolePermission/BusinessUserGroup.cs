using Infrastructure.Db.Dtoes.Mongo.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Authorization.UserRolePermission
{

    /// <summary>
    /// 业务员分组
    /// </summary>
    [Table("BusinessUserGroup")]
    public class BusinessUserGroup
    {
        /// <summary>
        /// 主键
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// 组名
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// 业务员所属分组
        /// </summary>
        public List<UserBlongBusinessGroup> UsersModels { get; set; }

        /// <summary>
        /// 区域编号
        /// </summary>
        public int? AreaId { get; set; }

        /// <summary>
        /// 团队编号
        /// </summary>
        public int? GroupId { get; set; }

        /// <summary>
        /// 操作日期
        /// </summary>
        public DateTime OperateDateTime { get; set; }
        /// <summary>
        /// 操作人员
        /// </summary>
        public int OperateId { get; set; }
    }

    public class UserBlongBusinessGroup
    {
        /// <summary>
        /// 业务员编号
        /// </summary>
        public int UserId { set; get; }

        /// <summary>
        /// 业务员名称
        /// </summary>
        public string UserName { get; set; }
    }

    /// <summary>
    /// 业务员分组信息
    /// </summary>
    [Table("BusinessUserGroupInfo")]
    public class BusinessUserGroupInfo
    {
        /// <summary>
        /// 类型编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分组类型
        /// </summary>
        public BusinessUserGroupType GroupType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime OperateDate { get; set; }

        /// <summary>
        /// 创建人编号
        /// </summary>
        public int CreateUserId { get; set; }

        /// <summary>
        /// 操作人编号
        /// </summary>
        public int OperatorId { get; set; }
    }
}
