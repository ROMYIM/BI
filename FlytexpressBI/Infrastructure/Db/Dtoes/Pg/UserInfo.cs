using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class UserInfo
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public string CardFilename { get; set; }
        public string CardNumber { get; set; }
        public string CreditRating { get; set; }
        public string CtId { get; set; }
        public string Cid { get; set; }
        public string Cname { get; set; }
        public string Rid { get; set; }
        public string Email { get; set; }
        public string EnName { get; set; }
        public string Fax { get; set; }
        public string FuId { get; set; }
        public string IdctId { get; set; }
        public string LinkMan { get; set; }
        public string Mobile { get; set; }
        public string MsnQq { get; set; }
        public DateTime? OpenDate { get; set; }
        public DateTime? OperateDate { get; set; }
        public string Passwd { get; set; }
        public string Phone { get; set; }
        public string Puaccount { get; set; }
        public DateTime? Regtime { get; set; }
        public string Remark { get; set; }
        public double? StateFlag { get; set; }
        public string Token { get; set; }
        public DateTime? TokenExpireTime { get; set; }
        public string UserId { get; set; }
        public string Uid { get; set; }
        public string Utype { get; set; }
        public string ZhName { get; set; }
        public string Groups { get; set; }
        public string ReceiveId { get; set; }
        public string UiId { get; set; }
        public string ContactServiceUid { get; set; }
        public bool? IsAuthentication { get; set; }
        public string AuthenticationType { get; set; }
        public string AuditState { get; set; }
        public string AuditOperatorId { get; set; }
        public bool? IsNeedVatinvoice { get; set; }
        public string SignCompanyId { get; set; }
        public string PlatformFlags { get; set; }
        public string FlytProduct { get; set; }
        public string Competitor { get; set; }
        public string ProductsTypes { get; set; }
        public string CertifyFileKey { get; set; }
        public string CertifyFileName { get; set; }
    }
}
