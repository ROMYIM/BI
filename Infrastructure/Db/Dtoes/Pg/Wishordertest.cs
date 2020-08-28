using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("wishordertest")]
    public partial class Wishordertest
    {
        [Column("uaccount")]
        public double? Uaccount { get; set; }
        [Column("ptid")]
        [StringLength(255)]
        public string Ptid { get; set; }
        [Column("traceid")]
        [StringLength(255)]
        public string Traceid { get; set; }
        [Column("firstapiorderid")]
        [StringLength(255)]
        public string Firstapiorderid { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
    }
}
