using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("tableidcounter")]
    public partial class Tableidcounter
    {
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
        [Column("maxquantities")]
        [StringLength(255)]
        public string Maxquantities { get; set; }
        [Column("countertype")]
        [StringLength(255)]
        public string Countertype { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("staticsdate")]
        [StringLength(255)]
        public string Staticsdate { get; set; }
    }
}
