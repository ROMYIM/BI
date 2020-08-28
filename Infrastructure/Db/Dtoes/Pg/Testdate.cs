using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("testdate")]
    public partial class Testdate
    {
        [Column("_id")]
        public double? Id { get; set; }
        [Column("testdatefield")]
        public DateTime? Testdatefield { get; set; }
    }
}
