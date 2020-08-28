using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("wishordercollection")]
    public partial class Wishordercollection
    {
        [Column("signtime")]
        public DateTime? Signtime { get; set; }
        [Column("address")]
        [StringLength(255)]
        public string Address { get; set; }
        [Column("createtime")]
        public DateTime? Createtime { get; set; }
        [Column("issign")]
        public bool? Issign { get; set; }
        [Column("city")]
        [StringLength(255)]
        public string City { get; set; }
        [Column("channelid")]
        [StringLength(255)]
        public string Channelid { get; set; }
        [Column("orderid")]
        [StringLength(255)]
        public string Orderid { get; set; }
        [Column("province")]
        [StringLength(255)]
        public string Province { get; set; }
        [Column("signer")]
        [StringLength(255)]
        public string Signer { get; set; }
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("isdelete")]
        public bool? Isdelete { get; set; }
        [Column("traceid")]
        [StringLength(255)]
        public string Traceid { get; set; }
        [Column("dataversion")]
        public double? Dataversion { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("posttypeid")]
        [StringLength(255)]
        public string Posttypeid { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
    }
}
