using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("usermoneylogs")]
    public partial class Usermoneylogs
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("computername")]
        [StringLength(255)]
        public string Computername { get; set; }
        [Column("objectid")]
        [StringLength(255)]
        public string Objectid { get; set; }
        [Column("times")]
        public double? Times { get; set; }
        [Column("message")]
        [StringLength(255)]
        public string Message { get; set; }
        [Column("createdate")]
        public DateTime? Createdate { get; set; }
        [Column("remark")]
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("serviceip")]
        [StringLength(255)]
        public string Serviceip { get; set; }
    }
}
