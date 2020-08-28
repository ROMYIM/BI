using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("wishonlineordercancel")]
    public partial class Wishonlineordercancel
    {
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("apikey")]
        [StringLength(255)]
        public string Apikey { get; set; }
        [Column("cancelreason")]
        [StringLength(255)]
        public string Cancelreason { get; set; }
        [Column("dataversion")]
        public double? Dataversion { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("logisticsordercode")]
        [StringLength(255)]
        public string Logisticsordercode { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [Column("trackingid")]
        [StringLength(255)]
        public string Trackingid { get; set; }
        [Column("carrytype")]
        public double? Carrytype { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
    }
}
