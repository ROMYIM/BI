using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("wishonlineorderquantityrecord")]
    public partial class Wishonlineorderquantityrecord
    {
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("recorddate")]
        [StringLength(255)]
        public string Recorddate { get; set; }
        [Column("quantity")]
        public double? Quantity { get; set; }
        [Column("dataversion")]
        public double? Dataversion { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
    }
}
