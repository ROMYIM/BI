using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("usernotificationrecord")]
    public partial class Usernotificationrecord
    {
        [Column("hasread")]
        [StringLength(255)]
        public string Hasread { get; set; }
        [Column("pushed")]
        [StringLength(255)]
        public string Pushed { get; set; }
        [Column("noticeid")]
        [StringLength(255)]
        public string Noticeid { get; set; }
        [Column("readtime")]
        public DateTime? Readtime { get; set; }
        [Column("_id_1")]
        [StringLength(255)]
        public string Id1 { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
    }
}
