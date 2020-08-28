using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("userinfoidentity")]
    public partial class Userinfoidentity
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("identityno")]
        [StringLength(255)]
        public string Identityno { get; set; }
        [Column("identityname")]
        [StringLength(255)]
        public string Identityname { get; set; }
        [Column("identitytype")]
        [StringLength(255)]
        public string Identitytype { get; set; }
        [Column("operatetime", TypeName = "timestamp(6) without time zone")]
        public DateTime? Operatetime { get; set; }
    }
}
