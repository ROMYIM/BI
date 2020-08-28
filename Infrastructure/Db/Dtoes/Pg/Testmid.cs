using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("testmid")]
    public partial class Testmid
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("names")]
        [StringLength(255)]
        public string Names { get; set; }
    }
}
