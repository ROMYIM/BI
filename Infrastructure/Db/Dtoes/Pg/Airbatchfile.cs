using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("airbatchfile")]
    public partial class Airbatchfile
    {
        [Column("extension")]
        [StringLength(255)]
        public string Extension { get; set; }
        [Column("filekey")]
        [StringLength(255)]
        public string Filekey { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("airbatchid")]
        [StringLength(255)]
        public string Airbatchid { get; set; }
        [Column("createtime")]
        public DateTime? Createtime { get; set; }
        [Column("filename")]
        [StringLength(255)]
        public string Filename { get; set; }
    }
}
