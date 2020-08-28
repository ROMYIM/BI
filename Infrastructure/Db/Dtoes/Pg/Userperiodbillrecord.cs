using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("userperiodbillrecord")]
    public partial class Userperiodbillrecord
    {
        [Column("havearrearagerecord")]
        [StringLength(255)]
        public string Havearrearagerecord { get; set; }
        [Column("md5code")]
        [StringLength(255)]
        public string Md5code { get; set; }
        [Column("periodupdatetime")]
        public DateTime? Periodupdatetime { get; set; }
        [Column("isoverdatetime")]
        [StringLength(255)]
        public string Isoverdatetime { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
        [Column("periodkey")]
        [StringLength(255)]
        public string Periodkey { get; set; }
        [Column("currencycode")]
        [StringLength(255)]
        public string Currencycode { get; set; }
        [Column("repaysettlementperiodleftmoney")]
        [StringLength(255)]
        public string Repaysettlementperiodleftmoney { get; set; }
        [Column("postingmoney")]
        [StringLength(255)]
        public string Postingmoney { get; set; }
        [Column("settlementbegintime")]
        public DateTime? Settlementbegintime { get; set; }
        [Column("periodcreatetime")]
        public DateTime? Periodcreatetime { get; set; }
        [Column("balanceendtime")]
        public DateTime? Balanceendtime { get; set; }
        [Column("repaysettlementperiodmoney")]
        [StringLength(255)]
        public string Repaysettlementperiodmoney { get; set; }
        [Column("isgeneral")]
        [StringLength(255)]
        public string Isgeneral { get; set; }
        [Column("settlementendtime")]
        public DateTime? Settlementendtime { get; set; }
        [Column("createtime")]
        public DateTime? Createtime { get; set; }
        [Column("settlementperiodmoney")]
        [StringLength(255)]
        public string Settlementperiodmoney { get; set; }
        [Column("currencyname")]
        [StringLength(255)]
        public string Currencyname { get; set; }
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
        [Column("balancecycletype")]
        public double? Balancecycletype { get; set; }
        [Column("balancedays")]
        public double? Balancedays { get; set; }
        [Column("beginbalance")]
        [StringLength(255)]
        public string Beginbalance { get; set; }
        [Column("creditdays")]
        public double? Creditdays { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("ishandled")]
        [StringLength(255)]
        public string Ishandled { get; set; }
    }
}
