using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("airbatchflightinfo")]
    public partial class Airbatchflightinfo
    {
        [Column("status")]
        [StringLength(255)]
        public string Status { get; set; }
        [Column("serialno")]
        public double? Serialno { get; set; }
        [Column("destinationcity")]
        [StringLength(255)]
        public string Destinationcity { get; set; }
        [Column("departurecity")]
        [StringLength(255)]
        public string Departurecity { get; set; }
        [Column("batchno")]
        [StringLength(255)]
        public string Batchno { get; set; }
        [Column("batchweight")]
        [StringLength(255)]
        public string Batchweight { get; set; }
        [Column("remark")]
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("station")]
        [StringLength(255)]
        public string Station { get; set; }
        [Column("airlinemark")]
        [StringLength(255)]
        public string Airlinemark { get; set; }
        [Column("totalweight")]
        [StringLength(255)]
        public string Totalweight { get; set; }
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("eventtime")]
        [StringLength(255)]
        public string Eventtime { get; set; }
        [Column("collecttime")]
        public DateTime? Collecttime { get; set; }
        [Column("flightnumber")]
        [StringLength(255)]
        public string Flightnumber { get; set; }
        [Column("isdelete")]
        public double? Isdelete { get; set; }
        [Column("quantities")]
        [StringLength(255)]
        public string Quantities { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
    }
}
