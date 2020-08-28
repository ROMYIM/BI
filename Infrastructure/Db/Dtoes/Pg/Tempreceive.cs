using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("tempreceive")]
    public partial class Tempreceive
    {
        [Column("auid")]
        public double? Auid { get; set; }
        [Column("delflag")]
        public bool? Delflag { get; set; }
        [Column("trflag")]
        public bool? Trflag { get; set; }
        [Column("userid")]
        public double? Userid { get; set; }
        [Column("uiid")]
        [StringLength(255)]
        public string Uiid { get; set; }
        [Column("createdatetime")]
        public DateTime? Createdatetime { get; set; }
        [Column("operatedate")]
        public DateTime? Operatedate { get; set; }
        [Column("creator")]
        public double? Creator { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("enddate")]
        public DateTime? Enddate { get; set; }
        [Column("begindate")]
        public DateTime? Begindate { get; set; }
        [Column("remark")]
        [StringLength(255)]
        public string Remark { get; set; }
    }
}
