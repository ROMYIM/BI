using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("administrativeregion")]
    public partial class Administrativeregion
    {
        [Column("countryid")]
        [StringLength(255)]
        public string Countryid { get; set; }
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
        [Column("distrcttown")]
        [StringLength(255)]
        public string Distrcttown { get; set; }
        [Column("city")]
        [StringLength(255)]
        public string City { get; set; }
        [Column("operatorid")]
        public double? Operatorid { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("province")]
        [StringLength(255)]
        public string Province { get; set; }
    }
}
