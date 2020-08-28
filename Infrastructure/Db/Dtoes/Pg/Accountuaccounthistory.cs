using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("accountuaccounthistory")]
    public partial class Accountuaccounthistory
    {
        [Column("accountinfoname")]
        [StringLength(255)]
        public string Accountinfoname { get; set; }
        [Column("operatorname")]
        [StringLength(255)]
        public string Operatorname { get; set; }
        [Column("content")]
        [StringLength(255)]
        public string Content { get; set; }
        [Column("operatedate")]
        public DateTime? Operatedate { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("accountinfoid")]
        [StringLength(255)]
        public string Accountinfoid { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
    }
}
