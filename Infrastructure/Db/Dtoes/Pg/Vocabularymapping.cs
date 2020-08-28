using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("vocabularymapping")]
    public partial class Vocabularymapping
    {
        [Column("mappingword")]
        [StringLength(255)]
        public string Mappingword { get; set; }
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
        [Column("word")]
        [StringLength(255)]
        public string Word { get; set; }
        [Column("createtime")]
        public DateTime? Createtime { get; set; }
        [Column("createuserid")]
        public double? Createuserid { get; set; }
        [Column("operatorid")]
        public double? Operatorid { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
    }
}
