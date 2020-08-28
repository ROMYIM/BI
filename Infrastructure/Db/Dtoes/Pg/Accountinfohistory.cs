using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("accountinfohistory")]
    public partial class Accountinfohistory
    {
        [Column("operatename")]
        [StringLength(255)]
        public string Operatename { get; set; }
        [Column("operatorname")]
        [StringLength(255)]
        public string Operatorname { get; set; }
        [Column("userid")]
        public double? Userid { get; set; }
        [Column("logcontent")]
        [StringLength(255)]
        public string Logcontent { get; set; }
        [Column("operatedate")]
        public DateTime? Operatedate { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("accountinfoid")]
        [StringLength(255)]
        public string Accountinfoid { get; set; }
    }
}
