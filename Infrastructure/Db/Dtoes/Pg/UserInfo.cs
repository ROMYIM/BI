using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class UserInfo
    {
        [Key]
        [Column("_Id")]
        [StringLength(255)]
        public string Id { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(255)]
        public string CardFilename { get; set; }
        [StringLength(255)]
        public string CardNumber { get; set; }
        [StringLength(255)]
        public string CreditRating { get; set; }
        [StringLength(255)]
        public string CtId { get; set; }
        [Column("CId")]
        [StringLength(255)]
        public string Cid { get; set; }
        [Column("CName")]
        [StringLength(255)]
        public string Cname { get; set; }
        [Column("RId")]
        [StringLength(255)]
        public string Rid { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string EnName { get; set; }
        [StringLength(255)]
        public string Fax { get; set; }
        [StringLength(255)]
        public string FuId { get; set; }
        [StringLength(255)]
        public string IdctId { get; set; }
        [StringLength(255)]
        public string LinkMan { get; set; }
        [StringLength(255)]
        public string Mobile { get; set; }
        [StringLength(255)]
        public string MsnQq { get; set; }
        [Column(TypeName = "timestamp(6) without time zone")]
        public DateTime? OpenDate { get; set; }
        [Column(TypeName = "timestamp(6) without time zone")]
        public DateTime? OperateDate { get; set; }
        [StringLength(255)]
        public string Passwd { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        [Column("PUaccount")]
        [StringLength(255)]
        public string Puaccount { get; set; }
        [Column(TypeName = "timestamp(6) without time zone")]
        public DateTime? Regtime { get; set; }
        [StringLength(255)]
        public string Remark { get; set; }
        public int? StateFlag { get; set; }
        [StringLength(255)]
        public string Token { get; set; }
        [Column(TypeName = "timestamp(6) without time zone")]
        public DateTime? TokenExpireTime { get; set; }
        [StringLength(255)]
        public string UserId { get; set; }
        [Column("UId")]
        [StringLength(255)]
        public string Uid { get; set; }
        [Column("UType")]
        [StringLength(255)]
        public string Utype { get; set; }
        [StringLength(255)]
        public string ZhName { get; set; }
        [Column(TypeName = "json")]
        public string Groups { get; set; }
        [StringLength(255)]
        public string ReceiveId { get; set; }
        [StringLength(255)]
        public string UiId { get; set; }
        [StringLength(255)]
        public string ContactServiceUid { get; set; }
        public bool? IsAuthentication { get; set; }
        [StringLength(255)]
        public string AuthenticationType { get; set; }
        [StringLength(255)]
        public string AuditState { get; set; }
        [StringLength(255)]
        public string AuditOperatorId { get; set; }
        [Column("IsNeedVATInvoice")]
        public bool? IsNeedVatinvoice { get; set; }
        [StringLength(255)]
        public string SignCompanyId { get; set; }
        [StringLength(255)]
        public string PlatformFlags { get; set; }
        [StringLength(255)]
        public string FlytProduct { get; set; }
        [StringLength(255)]
        public string Competitor { get; set; }
        [StringLength(255)]
        public string ProductsTypes { get; set; }
        [StringLength(255)]
        public string CertifyFileKey { get; set; }
        [StringLength(255)]
        public string CertifyFileName { get; set; }
    }
}
