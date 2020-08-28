using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("wishcarrier")]
    public partial class Wishcarrier
    {
        [Column("posttypename")]
        [StringLength(255)]
        public string Posttypename { get; set; }
        [Column("carrier")]
        [StringLength(255)]
        public string Carrier { get; set; }
        [Column("posttypeid")]
        [StringLength(255)]
        public string Posttypeid { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
    }
}
