using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("userperiodbillsend")]
    public partial class Userperiodbillsend
    {
        [Column("billsendbody")]
        [StringLength(255)]
        public string Billsendbody { get; set; }
        [Column("toemails", TypeName = "json")]
        public string Toemails { get; set; }
        [Column("createtime")]
        public DateTime? Createtime { get; set; }
        [Column("billid")]
        [StringLength(255)]
        public string Billid { get; set; }
        [Column("periodid")]
        [StringLength(255)]
        public string Periodid { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("billsendsubject")]
        [StringLength(255)]
        public string Billsendsubject { get; set; }
    }
}
