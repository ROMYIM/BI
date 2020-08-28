using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("wishorderrelateinfo")]
    public partial class Wishorderrelateinfo
    {
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("actualuaccount")]
        [StringLength(255)]
        public string Actualuaccount { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
        [Column("traceid")]
        [StringLength(255)]
        public string Traceid { get; set; }
        [Column("dataversion")]
        public double? Dataversion { get; set; }
        [Column("isbangdingoffline")]
        public bool? Isbangdingoffline { get; set; }
        [Column("platformorderid")]
        [StringLength(255)]
        public string Platformorderid { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("orderid")]
        [StringLength(255)]
        public string Orderid { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [Column("isonlinepaied")]
        public bool? Isonlinepaied { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
    }
}
