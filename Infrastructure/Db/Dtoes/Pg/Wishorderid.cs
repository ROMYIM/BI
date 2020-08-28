using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("wishorderid")]
    public partial class Wishorderid
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
    }
}
