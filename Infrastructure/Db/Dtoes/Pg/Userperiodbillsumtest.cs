using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("userperiodbillsumtest")]
    public partial class Userperiodbillsumtest
    {
        [Column("repayleftmoney")]
        [StringLength(255)]
        public string Repayleftmoney { get; set; }
        [Column("cycletype")]
        public double? Cycletype { get; set; }
        [Column("feetype")]
        public double? Feetype { get; set; }
        [Column("billmoney")]
        [StringLength(255)]
        public string Billmoney { get; set; }
        [Column("cratetime")]
        public DateTime? Cratetime { get; set; }
        [Column("endtime")]
        public DateTime? Endtime { get; set; }
        [Column("md5code")]
        [StringLength(255)]
        public string Md5code { get; set; }
        [Column("filename")]
        [StringLength(255)]
        public string Filename { get; set; }
        [Column("detailtotal")]
        public double? Detailtotal { get; set; }
        [Column("begintime")]
        public DateTime? Begintime { get; set; }
        [Column("periodkey")]
        [StringLength(255)]
        public string Periodkey { get; set; }
        [Column("repaytime")]
        public DateTime? Repaytime { get; set; }
        [Column("currencycode")]
        [StringLength(255)]
        public string Currencycode { get; set; }
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("isgeneraled")]
        [StringLength(255)]
        public string Isgeneraled { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
        [Column("isupload")]
        [StringLength(255)]
        public string Isupload { get; set; }
        [Column("filekey")]
        [StringLength(255)]
        public string Filekey { get; set; }
        [Column("amount")]
        [StringLength(255)]
        public string Amount { get; set; }
        [Column("repaymoney")]
        [StringLength(255)]
        public string Repaymoney { get; set; }
        [Column("ishavedetail")]
        [StringLength(255)]
        public string Ishavedetail { get; set; }
        [Column("periodid")]
        [StringLength(255)]
        public string Periodid { get; set; }
        [Column("currencyname")]
        [StringLength(255)]
        public string Currencyname { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
        [Column("fileurl")]
        [StringLength(255)]
        public string Fileurl { get; set; }
        [Column("creditmoney")]
        [StringLength(255)]
        public string Creditmoney { get; set; }
        [Column("beginbalance")]
        [StringLength(255)]
        public string Beginbalance { get; set; }
        [Column("creditdays")]
        public double? Creditdays { get; set; }
        [Column("dataversion")]
        public double? Dataversion { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [Column("issend")]
        [StringLength(255)]
        public string Issend { get; set; }
    }
}
