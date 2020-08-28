using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("workwechatuser")]
    public partial class Workwechatuser
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("openid")]
        [StringLength(255)]
        public string Openid { get; set; }
        [Column("userid")]
        public double? Userid { get; set; }
        [Column("createtime")]
        public DateTime? Createtime { get; set; }
    }
}
