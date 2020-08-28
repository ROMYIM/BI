using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("abroadquestionimportlogselfreport")]
    public partial class Abroadquestionimportlogselfreport
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("createdate")]
        public DateTime? Createdate { get; set; }
        [Column("logid")]
        [StringLength(255)]
        public string Logid { get; set; }
        [Column("reportdata", TypeName = "json")]
        public string Reportdata { get; set; }
    }
}
