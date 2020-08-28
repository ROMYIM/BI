using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("airbatchfbadetail")]
    public partial class Airbatchfbadetail
    {
        [Column("destinationcountry")]
        [StringLength(255)]
        public string Destinationcountry { get; set; }
        [Column("sendtime")]
        public DateTime? Sendtime { get; set; }
        [Column("airbatchid")]
        [StringLength(255)]
        public string Airbatchid { get; set; }
        [Column("fbashipmentid")]
        [StringLength(255)]
        public string Fbashipmentid { get; set; }
        [Column("postingcountry")]
        [StringLength(255)]
        public string Postingcountry { get; set; }
        [Column("orderid")]
        [StringLength(255)]
        public string Orderid { get; set; }
        [Column("pkg")]
        [StringLength(255)]
        public string Pkg { get; set; }
        [Column("deliverytime")]
        [StringLength(255)]
        public string Deliverytime { get; set; }
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("traceid")]
        [StringLength(255)]
        public string Traceid { get; set; }
        [Column("dataversion")]
        [StringLength(255)]
        public string Dataversion { get; set; }
        [Column("posttypeid")]
        [StringLength(255)]
        public string Posttypeid { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
    }
}
