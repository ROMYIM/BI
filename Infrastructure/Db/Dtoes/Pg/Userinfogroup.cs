using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("userinfogroup")]
    public partial class Userinfogroup
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("gname")]
        [StringLength(255)]
        public string Gname { get; set; }
        [Column("operatedate", TypeName = "timestamp(6) without time zone")]
        public DateTime? Operatedate { get; set; }
        [Column("userid")]
        [StringLength(255)]
        public string Userid { get; set; }
        [Column("delflag")]
        [StringLength(255)]
        public string Delflag { get; set; }
    }
}
