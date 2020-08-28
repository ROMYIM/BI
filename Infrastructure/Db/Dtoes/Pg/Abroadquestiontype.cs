using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("abroadquestiontype")]
    public partial class Abroadquestiontype
    {
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
        [Column("questionsection")]
        public double? Questionsection { get; set; }
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("creatorid")]
        public double? Creatorid { get; set; }
        [Column("createtime")]
        public DateTime? Createtime { get; set; }
        [Column("operatorid")]
        public double? Operatorid { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("code")]
        [StringLength(255)]
        public string Code { get; set; }
    }
}
