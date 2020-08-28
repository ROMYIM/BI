using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("templatehistory")]
    public partial class Templatehistory
    {
        [Column("operator")]
        [StringLength(255)]
        public string Operator { get; set; }
        [Column("xmltemplate")]
        [StringLength(255)]
        public string Xmltemplate { get; set; }
        [Column("time")]
        public DateTime? Time { get; set; }
        [Column("_id")]
        public double? Id { get; set; }
        [Column("originjsontemplate")]
        [StringLength(255)]
        public string Originjsontemplate { get; set; }
        [Column("reason")]
        [StringLength(255)]
        public string Reason { get; set; }
        [Column("templateid")]
        public double? Templateid { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
