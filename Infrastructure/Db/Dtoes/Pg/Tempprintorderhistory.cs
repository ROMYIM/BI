using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("tempprintorderhistory")]
    public partial class Tempprintorderhistory
    {
        [Column("operatename")]
        [StringLength(255)]
        public string Operatename { get; set; }
        [Column("operatorname")]
        [StringLength(255)]
        public string Operatorname { get; set; }
        [Column("newchanneltraceid")]
        [StringLength(255)]
        public string Newchanneltraceid { get; set; }
        [Column("createtime")]
        public DateTime? Createtime { get; set; }
        [Column("oldchanneltraceid")]
        [StringLength(255)]
        public string Oldchanneltraceid { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("orderid")]
        [StringLength(255)]
        public string Orderid { get; set; }
        [Column("tracknumber")]
        [StringLength(255)]
        public string Tracknumber { get; set; }
    }
}
