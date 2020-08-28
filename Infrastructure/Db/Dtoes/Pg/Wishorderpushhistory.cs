using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("wishorderpushhistory")]
    public partial class Wishorderpushhistory
    {
        [Column("issuccess")]
        public bool? Issuccess { get; set; }
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
        [Column("apiorderid")]
        [StringLength(255)]
        public string Apiorderid { get; set; }
        [Column("traceid")]
        [StringLength(255)]
        public string Traceid { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("orderid")]
        [StringLength(255)]
        public string Orderid { get; set; }
        [Column("remark")]
        [StringLength(255)]
        public string Remark { get; set; }
    }
}
