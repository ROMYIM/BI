using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("testlststrpo")]
    public partial class Testlststrpo
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("names", TypeName = "json")]
        public string Names { get; set; }
        [Column("createtime")]
        public DateTime? Createtime { get; set; }
    }
}
