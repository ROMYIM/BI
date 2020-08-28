using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("userorderreturnmoneyrecord")]
    public partial class Userorderreturnmoneyrecord
    {
        [Column("createdatetime")]
        public DateTime? Createdatetime { get; set; }
        [Column("isdelete")]
        [StringLength(255)]
        public string Isdelete { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("orderid")]
        [StringLength(255)]
        public string Orderid { get; set; }
        [Column("updatetime")]
        public DateTime? Updatetime { get; set; }
    }
}
