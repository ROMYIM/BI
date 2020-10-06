using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("UserInfo")]
    public class UserInfo
    {
        /// <summary>
        /// 客户编号（物流账号）
        /// </summary>
        public string Id { get; set; }

        /// <summary> 
        /// 地址
        /// </summary>
        public string Address { set; get; }

        /// <summary> 
        /// 证件文件名1 作为上传证件正面图片文件的保存路径用
        /// </summary>
        public string CardFilename { set; get; }

        /// <summary> 
        /// 证件文件名2 作为上传证件反面图片文件的保存路径用
        /// </summary>
        public string CardFilename2 { set; get; }

        /// <summary> 
        /// 证件号码
        /// </summary>
        public string CardNumber { set; get; }

        /// <summary> 
        /// 客户信誉级别1:初级
        /// </summary>
        public int CreditRating { set; get; }

        /// <summary> 
        /// 客户类别序号
        /// </summary>
        public int CtId { set; get; }

        /// <summary> 
        /// 公司编号
        /// </summary>
        public string CId { set; get; }

        /// <summary> 
        /// 公司名称
        /// </summary>
        public string CName { set; get; }

        /// <summary> 
        /// 收货点编号
        /// </summary>
        public string RId { set; get; }

        /// <summary> 
        /// 邮箱地址
        /// </summary>
        public string Email { set; get; }

        /// <summary> 
        /// 英文名
        /// </summary>
        public string EnName { set; get; }

        /// <summary> 
        /// 传真号
        /// </summary>
        public string Fax { set; get; }

        /// <summary> 
        /// 财务员用户序号归属指定财务员结算
        /// </summary>
        public int FuId { set; get; }

        /// <summary> 
        /// 证件类型编号
        /// </summary>
        public int IdctId { set; get; }

        /// <summary> 
        /// 联系人
        /// </summary>
        public string LinkMan { set; get; }

        /// <summary> 
        /// 手机号
        /// </summary>
        public string Mobile { set; get; }

        /// <summary> 
        /// 在线联系账号
        /// </summary>
        public string MsnQq { set; get; }

        /// <summary> 
        /// 开通时间
        /// </summary>
        public DateTime OpenDate { set; get; }

        /// <summary> 
        /// 操作日期
        /// </summary>
        public DateTime OperateDate { set; get; }

        /// <summary> 
        /// 用户密码
        /// </summary>
        public string Passwd { set; get; }

        /// <summary> 
        /// 电话
        /// </summary>
        public string Phone { set; get; }

        /// <summary> 
        /// 父客户编号
        /// </summary>
        public string PUaccount { set; get; }

        /// <summary> 
        /// 注册时间
        /// </summary>
        public DateTime Regtime { set; get; }

        /// <summary> 
        /// 备注
        /// </summary>
        public string Remark { set; get; }

        /// <summary> 
        /// 状态 0=新增   1=审核不通过  2=审核通过   3=停用 4 = 删除
        /// </summary>
        public int StateFlag { set; get; }

        /// <summary> 
        /// 令牌
        /// </summary>
        public string Token { set; get; }

        /// <summary> 
        /// 令牌过期时间
        /// </summary>
        public DateTime TokenExpireTime { set; get; }

        /// <summary> 
        /// 操作人员
        /// </summary>
        public int UserId { set; get; }

        /// <summary> 
        /// 业务员编号
        /// </summary>
        public int UId { set; get; }

        /// <summary> 
        /// 账号类型  0= 外部客人物流账号，1 = 表示飞特收货点物流账号，扣操作点费用时使用
        /// </summary>
        public int UType { set; get; }

        /// <summary> 
        /// 中文名
        /// </summary>
        public string ZhName { set; get; }

        /// <summary> 
        /// 收货人姓名(司机,用户编号)
        /// </summary>
        public int ReceiveId { set; get; }

        /// <summary>
        /// 客户信息编号（ORACLE迁移用）
        /// </summary>
        public string UiId { get; set; }

        /// <summary>
        /// 飞特产品
        /// </summary>
        public string FlytProduct { get; set; }

        /// <summary>
        /// 竞争对手
        /// </summary>
        public string Competitor { get; set; }

        /// <summary>
        /// 是否需要增值税发票
        /// </summary>
        public bool IsNeedVATInvoice { get; set; }

        /// <summary>
        /// 签约主体公司
        /// </summary>
        public string SignCompanyId { get; set; }

        /// <summary>
        /// 接洽客服员编号
        /// </summary>
        public int ContactServiceUid { get; set; }

        /// <summary>
        /// 销售助理
        /// </summary>
        public int SalerAssistantUid { get; set; }

        /// <summary>
        ///  正面证照文件key
        /// </summary>
        public string CertifyFileKey { get; set; }
        /// <summary>
        ///  正面证照文件名
        /// </summary>
        public string CertifyFileName { get; set; }
        /// <summary>
        ///  反面证照文件key
        /// </summary>
        public string CertifyFileKey2 { get; set; }
        /// <summary>
        ///  反面证照文件名
        /// </summary>
        public string CertifyFileName2 { get; set; }
        /// <summary>
        /// 法人姓名
        /// </summary>
        public string LegalPerson { get; set; }
        /// <summary>
        /// 法人身份证
        /// </summary>
        public string LegalIdentityCard { get; set; }
        /// <summary>
        /// 企业工商注册号码
        /// </summary>
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// 认证方式
        /// </summary>
        public int AuthenticationType { get; set; }

        /// <summary>
        /// 是否已认证通过
        /// </summary>
        public bool IsAuthentication { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        public int AuditState { get; set; }

        /// <summary>
        /// 最近审核人
        /// </summary>
        public int AuditOperatorId { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime AuditTime { get; set; }
    }
}
