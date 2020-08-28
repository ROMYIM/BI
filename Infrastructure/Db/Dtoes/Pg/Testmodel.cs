using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("testmodel")]
    public partial class Testmodel
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
        [Column("dataversion")]
        public double? Dataversion { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("type")]
        public double? Type { get; set; }
        [Column("quantity")]
        public double? Quantity { get; set; }
    }
}
