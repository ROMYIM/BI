using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("zipcode")]
    public partial class Zipcode
    {
        [Column("startzip")]
        [StringLength(255)]
        public string Startzip { get; set; }
        [Column("country")]
        [StringLength(255)]
        public string Country { get; set; }
        [Column("city")]
        [StringLength(255)]
        public string City { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("alphatwo")]
        [StringLength(255)]
        public string Alphatwo { get; set; }
        [Column("endzip")]
        [StringLength(255)]
        public string Endzip { get; set; }
        [Column("alphathress")]
        [StringLength(255)]
        public string Alphathress { get; set; }
    }
}
