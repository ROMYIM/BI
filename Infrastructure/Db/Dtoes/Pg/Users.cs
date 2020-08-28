using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Users
    {
        [Key]
        [Column("_id")]
        public int Id { get; set; }
        [StringLength(255)]
        public string UserName { get; set; }
        [StringLength(255)]
        public string CnName { get; set; }
        [StringLength(255)]
        public string EnName { get; set; }
        [StringLength(255)]
        public string Email { get; set; }
        [StringLength(255)]
        public string QqNumber { get; set; }
        [StringLength(255)]
        public string Phone { get; set; }
        [StringLength(255)]
        public string ParentId { get; set; }
        [StringLength(255)]
        public string PositionId { get; set; }
        [Column("RId")]
        [StringLength(255)]
        public string Rid { get; set; }
        [Column("UNumber")]
        [StringLength(255)]
        public string Unumber { get; set; }
        public DateTime? RegDatetime { get; set; }
        [Column(TypeName = "character varying")]
        public string CompanyId { get; set; }
        [Column(TypeName = "json")]
        public string Roleds { get; set; }
        [Column(TypeName = "json")]
        public string Permissions { get; set; }
        public bool? Locked { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? VerifyState { get; set; }
        [StringLength(255)]
        public string VerfiyUserId { get; set; }
        public DateTime? UpdatePwDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        [StringLength(255)]
        public string LastLoginIp { get; set; }
        [Column("UId")]
        [StringLength(255)]
        public string Uid { get; set; }
    }
}
