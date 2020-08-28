using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("tempprintrule")]
    public partial class Tempprintrule
    {
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("targetchannelid")]
        [StringLength(255)]
        public string Targetchannelid { get; set; }
        [Column("customer")]
        [StringLength(255)]
        public string Customer { get; set; }
        [Column("creatorid")]
        public double? Creatorid { get; set; }
        [Column("createtime")]
        public DateTime? Createtime { get; set; }
        [Column("operatorid")]
        public double? Operatorid { get; set; }
        [Column("countrys")]
        [StringLength(255)]
        public string Countrys { get; set; }
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
        [Column("originalchannelids", TypeName = "json")]
        public string Originalchannelids { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("isgettargettracknumber")]
        [StringLength(255)]
        public string Isgettargettracknumber { get; set; }
        [Column("rulename")]
        [StringLength(255)]
        public string Rulename { get; set; }
    }
}
