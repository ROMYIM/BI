using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("windowsservice")]
    public partial class Windowsservice
    {
        [Column("creater")]
        [StringLength(255)]
        public string Creater { get; set; }
        [Column("processname")]
        [StringLength(255)]
        public string Processname { get; set; }
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }
        [Column("createtime")]
        public DateTime? Createtime { get; set; }
        [Column("lastruntime")]
        public DateTime? Lastruntime { get; set; }
        [Column("enable")]
        [StringLength(255)]
        public string Enable { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
