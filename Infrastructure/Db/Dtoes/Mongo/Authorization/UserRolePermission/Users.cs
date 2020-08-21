using Infrastructure.Db.Dtoes.Mongo.Enums;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Mongo.Authorization.UserRolePermission
{
    /// <summary>
    /// 用户管理实体类
    /// </summary>
    [Serializable]
    [ProtoContract]
    [Table("Users")]
    public class Users
    {
        /// <summary> 
        /// 用户序号
        /// </summary>
        [ProtoMember(1)]
        public int Id { set; get; }

        /// <summary> 
        /// 登录名
        /// </summary>
        [ProtoMember(2)]
        public string UserName { set; get; }

        /// <summary> 
        /// 中文名称
        /// </summary>
        [ProtoMember(3)]
        public string CnName { set; get; }

        /// <summary> 
        /// 英文名称
        /// </summary>
        [ProtoMember(4)]
        public string EnName { set; get; }

        /// <summary> 
        /// Email
        /// </summary>
        [ProtoMember(5)]
        public string Email { set; get; }

        /// <summary>
        /// QQ号码
        /// </summary>
        [ProtoMember(6)]
        public string QqNumber { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [ProtoMember(7)]
        public string Phone { get; set; }

        /// <summary> 
        /// 父级ID
        /// </summary>
        [ProtoMember(8)]
        public string ParentId { set; get; }

        /// <summary> 
        /// 岗位编号
        /// </summary>
        [ProtoMember(9)]
        public string PositionId { set; get; }

        /// <summary>
        /// 收货点编号
        /// </summary>
        [ProtoMember(10)]
        public string RId { get; set; }

        /// <summary> 
        /// 员工编号
        /// </summary>
        [ProtoMember(11)]
        public double UNumber { set; get; }

        /// <summary> 
        /// 注册时间
        /// </summary>
        [ProtoMember(12)]
        public DateTime RegDatetime { set; get; }

        /// <summary>
        /// 公司编号
        /// </summary>
        [ProtoMember(13)]
        public string CompanyId { get; set; }

        /// <summary>
        /// 用户角色编号
        /// </summary>
        [ProtoMember(14)]
        public List<string> RoleIds { get; set; }

        /// <summary>
        /// 权限资源
        /// </summary>
        [ProtoMember(15)]
        public List<ResourceDataEntity> Permissions { get; set; }

        /// <summary> 
        /// 是否锁定 0=否  1=是
        /// </summary>
        [ProtoMember(16)]
        public bool Locked { set; get; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [ProtoMember(17)]
        public bool IsDeleted { get; set; }

        /// <summary> 
        /// 审核状态  0=不通过  1=通过
        /// </summary>
        [ProtoMember(18)]
        public UserVerifyState VerifyState { set; get; }

        /// <summary>
        /// 审核人编号
        /// </summary>
        [ProtoMember(19)]
        public string VerfiyUserId { get; set; }

        /// <summary> 
        /// 密码更新日期
        /// </summary>
        public DateTime? UpdatePwDate { set; get; }

        /// <summary> 
        /// 用户密码
        /// </summary>
        public string UPassword { set; get; }

        /// <summary> 
        /// 是否验证IP  0=否  1=是
        /// </summary>
        public bool IsUserLoginIp { set; get; }

        /// <summary> 
        /// 最后一次登录时间
        /// </summary>
        public DateTime LastLoginDate { set; get; }

        /// <summary> 
        /// 最后一次登录IP
        /// </summary>
        public string LastLoginIp { set; get; }

        /// <summary>
        /// 用户编号（迁移ORACLE用）
        /// </summary>
        public string Uid { get; set; }
    }
}
