using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("userordertag")]
    public partial class Userordertag
    {
        [Column("creationtime")]
        public DateTime? Creationtime { get; set; }
        [Column("tagid")]
        [StringLength(255)]
        public string Tagid { get; set; }
        [Column("tagtype")]
        public double? Tagtype { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("tagname")]
        [StringLength(255)]
        public string Tagname { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
    }
}
