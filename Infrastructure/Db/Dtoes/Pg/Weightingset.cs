using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("weightingset")]
    public partial class Weightingset
    {
        [Column("operatedatetime")]
        public DateTime? Operatedatetime { get; set; }
        [Column("companyid")]
        [StringLength(255)]
        public string Companyid { get; set; }
        [Column("isdelete")]
        [StringLength(255)]
        public string Isdelete { get; set; }
        [Column("operateuserid")]
        public double? Operateuserid { get; set; }
        [Column("feesweight")]
        [StringLength(255)]
        public string Feesweight { get; set; }
        [Column("serviceprescriptionweight")]
        [StringLength(255)]
        public string Serviceprescriptionweight { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("servicelevelweight")]
        [StringLength(255)]
        public string Servicelevelweight { get; set; }
        [Column("remark")]
        [StringLength(255)]
        public string Remark { get; set; }
    }
}
