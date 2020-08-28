using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("verificationorderrule")]
    public partial class Verificationorderrule
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("rulename")]
        [StringLength(255)]
        public string Rulename { get; set; }
        [Column("conditions", TypeName = "json")]
        public string Conditions { get; set; }
        [Column("optrnodes", TypeName = "json")]
        public string Optrnodes { get; set; }
        [Column("countries", TypeName = "json")]
        public string Countries { get; set; }
        [Column("posttypes", TypeName = "json")]
        public string Posttypes { get; set; }
        [Column("uiids", TypeName = "json")]
        public string Uiids { get; set; }
        [Column("priority")]
        public double? Priority { get; set; }
        [Column("operateId")]
        [StringLength(255)]
        public string OperateId { get; set; }
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
        [Column("operatetype")]
        [StringLength(255)]
        public string Operatetype { get; set; }
        [Column("id")]
        [StringLength(255)]
        public string Id1 { get; set; }
    }
}
