using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    /// <summary>
    /// 用户管理实体类
    /// </summary>
    [Table("Users")]
    public class Users
    {
        /// <summary> 
        /// 用户序号
        /// </summary>
        public int Id { set; get; }

        /// <summary> 
        /// 登录名
        /// </summary>
        public string UserName { set; get; }

        /// <summary> 
        /// 中文名称
        /// </summary>
        public string CnName { set; get; }

        /// <summary> 
        /// 英文名称
        /// </summary>
        public string EnName { set; get; }

        /// <summary> 
        /// Email
        /// </summary>
        public string Email { set; get; }

        /// <summary>
        /// QQ号码
        /// </summary>
        public string QqNumber { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }

        /// <summary> 
        /// 父级ID
        /// </summary>
        public string ParentId { set; get; }

        /// <summary> 
        /// 岗位编号
        /// </summary>
        public string PositionId { set; get; }

        /// <summary>
        /// 收货点编号
        /// </summary>
        public string RId { get; set; }

        /// <summary> 
        /// 员工编号
        /// </summary>
        public double UNumber { set; get; }

        /// <summary> 
        /// 注册时间
        /// </summary>
        public DateTime RegDatetime { set; get; }

        /// <summary>
        /// 公司编号
        /// </summary>
        public string CompanyId { get; set; }

        /// <summary> 
        /// 是否锁定 0=否  1=是
        /// </summary>
        public bool Locked { set; get; }

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary> 
        /// 审核状态  0=不通过  1=通过
        /// </summary>
        public int VerifyState { set; get; }

        /// <summary>
        /// 审核人编号
        /// </summary>
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
        public string UId { get; set; }
    }
}
