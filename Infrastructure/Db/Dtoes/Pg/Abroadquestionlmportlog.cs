using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("abroadquestionlmportlog")]
    public partial class Abroadquestionlmportlog
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
        [Column("selfreportcount")]
        public double? Selfreportcount { get; set; }
        [Column("isselfreport")]
        [StringLength(255)]
        public string Isselfreport { get; set; }
        [Column("content")]
        [StringLength(255)]
        public string Content { get; set; }
        [Column("importcount")]
        public double? Importcount { get; set; }
        [Column("operatorid")]
        public double? Operatorid { get; set; }
        [Column("errorcount")]
        public double? Errorcount { get; set; }
        [Column("createdate")]
        public DateTime? Createdate { get; set; }
    }
}
