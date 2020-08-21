using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("Users")]
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string CnName { get; set; }
        public string EnName { get; set; }
        public string Email { get; set; }
        public string QqNumber { get; set; }
        public string Phone { get; set; }
        public string ParentId { get; set; }
        public string PositionId { get; set; }
        public string Rid { get; set; }
        public string Unumber { get; set; }
        public DateTime? RegDatetime { get; set; }
        public string CompanyId { get; set; }
        public string Roleds { get; set; }
        public string Permissions { get; set; }
        public bool? Locked { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? VerifyState { get; set; }
        public string VerfiyUserId { get; set; }
        public DateTime? UpdatePwDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string LastLoginIp { get; set; }
        public string Uid { get; set; }
    }
}
