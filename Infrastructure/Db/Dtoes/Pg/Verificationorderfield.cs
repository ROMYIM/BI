using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("verificationorderfield")]
    public partial class Verificationorderfield
    {
        [Column("isdefault")]
        [StringLength(255)]
        public string Isdefault { get; set; }
        [Column("names")]
        [StringLength(255)]
        public string Names { get; set; }
        [Column("moduletype")]
        public double? Moduletype { get; set; }
        [Column("filetype")]
        public double? Filetype { get; set; }
        [Column("resourcetype")]
        public double? Resourcetype { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("annotation")]
        [StringLength(255)]
        public string Annotation { get; set; }
    }
}
