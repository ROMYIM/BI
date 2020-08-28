using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("abroadquestionhistory")]
    public partial class Abroadquestionhistory
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("operatename")]
        [StringLength(255)]
        public string Operatename { get; set; }
        [Column("operatorname")]
        [StringLength(255)]
        public string Operatorname { get; set; }
        [Column("content")]
        [StringLength(255)]
        public string Content { get; set; }
        [Column("statename")]
        [StringLength(255)]
        public string Statename { get; set; }
        [Column("quentionid")]
        [StringLength(255)]
        public string Quentionid { get; set; }
        [Column("operatedate")]
        public DateTime? Operatedate { get; set; }
    }
}
