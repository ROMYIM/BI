using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("userperiodbilllog")]
    public partial class Userperiodbilllog
    {
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
        [Column("operatename")]
        [StringLength(255)]
        public string Operatename { get; set; }
        [Column("operatorname")]
        [StringLength(255)]
        public string Operatorname { get; set; }
        [Column("periodid")]
        [StringLength(255)]
        public string Periodid { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("operatelog")]
        [StringLength(255)]
        public string Operatelog { get; set; }
    }
}
