using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("wechatintercept")]
    public partial class Wechatintercept
    {
        [StringLength(255)]
        public string Operator { get; set; }
        [Column("wechattime")]
        [StringLength(255)]
        public string Wechattime { get; set; }
        public double? State { get; set; }
        [Column("createtime")]
        public DateTime? Createtime { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("code")]
        [StringLength(255)]
        public string Code { get; set; }
        [Column("reason")]
        [StringLength(255)]
        public string Reason { get; set; }
        [Column("wechatname")]
        [StringLength(255)]
        public string Wechatname { get; set; }
    }
}
