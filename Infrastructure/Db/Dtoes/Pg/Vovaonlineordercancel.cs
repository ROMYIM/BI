using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("vovaonlineordercancel")]
    public partial class Vovaonlineordercancel
    {
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("apikey")]
        [StringLength(255)]
        public string Apikey { get; set; }
        [Column("cancelreason")]
        [StringLength(255)]
        public string Cancelreason { get; set; }
        [Column("vovapostordersn")]
        [StringLength(255)]
        public string Vovapostordersn { get; set; }
        [Column("apiusername")]
        [StringLength(255)]
        public string Apiusername { get; set; }
        [Column("dataversion")]
        public double? Dataversion { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("logisticstrackingnumber")]
        [StringLength(255)]
        public string Logisticstrackingnumber { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [StringLength(255)]
        public string Timestamp { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
    }
}
