using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("usermoneypreparerecord")]
    public partial class Usermoneypreparerecord
    {
        [Column("ccode")]
        [StringLength(255)]
        public string Ccode { get; set; }
        [Column("deductuserid")]
        [StringLength(255)]
        public string Deductuserid { get; set; }
        [Column("mathdatetime")]
        public DateTime? Mathdatetime { get; set; }
        [Column("rechagetype")]
        public double? Rechagetype { get; set; }
        [Column("packtype")]
        public double? Packtype { get; set; }
        [Column("costmoney")]
        [StringLength(255)]
        public string Costmoney { get; set; }
        [Column("sopids", TypeName = "json")]
        public string Sopids { get; set; }
        [Column("depositplatform")]
        public double? Depositplatform { get; set; }
        [Column("rid")]
        [StringLength(255)]
        public string Rid { get; set; }
        [Column("balancedate")]
        [StringLength(255)]
        public string Balancedate { get; set; }
        [Column("deductfeedatetime")]
        [StringLength(255)]
        public string Deductfeedatetime { get; set; }
        [Column("hedginggroup")]
        [StringLength(255)]
        public string Hedginggroup { get; set; }
        [Column("remark")]
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("istate")]
        public double? Istate { get; set; }
        [Column("chargebackplatform")]
        public double? Chargebackplatform { get; set; }
        [Column("isdeduct")]
        [StringLength(255)]
        public string Isdeduct { get; set; }
        [Column("umoney")]
        public double? Umoney { get; set; }
        [Column("apiorderid")]
        [StringLength(255)]
        public string Apiorderid { get; set; }
        [Column("hedgingflag_1")]
        public double? Hedgingflag1 { get; set; }
        [Column("feestype")]
        public double? Feestype { get; set; }
        [Column("ioflag")]
        public double? Ioflag { get; set; }
        [Column("hedgingflag")]
        public double? Hedgingflag { get; set; }
        [Column("leftmoney")]
        public double? Leftmoney { get; set; }
        [Column("itemmoney")]
        public double? Itemmoney { get; set; }
        [Column("periodmoenys")]
        [StringLength(255)]
        public string Periodmoenys { get; set; }
        [Column("ucspids")]
        [StringLength(255)]
        public string Ucspids { get; set; }
        [Column("orderid")]
        [StringLength(255)]
        public string Orderid { get; set; }
        [Column("weight")]
        [StringLength(255)]
        public string Weight { get; set; }
        [Column("countinfor")]
        [StringLength(255)]
        public string Countinfor { get; set; }
        [Column("costposttypename")]
        [StringLength(255)]
        public string Costposttypename { get; set; }
        [Column("cname")]
        [StringLength(255)]
        public string Cname { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [Column("preparerecordoperatetype")]
        [StringLength(255)]
        public string Preparerecordoperatetype { get; set; }
        [Column("exchangerate")]
        public double? Exchangerate { get; set; }
        [Column("buserid")]
        [StringLength(255)]
        public string Buserid { get; set; }
        [Column("tranceid")]
        [StringLength(255)]
        public string Tranceid { get; set; }
        [Column("costptid")]
        [StringLength(255)]
        public string Costptid { get; set; }
        [Column("chargeclass")]
        public double? Chargeclass { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
        [Column("aubalancedate")]
        [StringLength(255)]
        public string Aubalancedate { get; set; }
        [Column("uid")]
        [StringLength(255)]
        public string Uid { get; set; }
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("deducttype")]
        public double? Deducttype { get; set; }
        [Column("ordercount")]
        public double? Ordercount { get; set; }
        [Column("costprice")]
        public double? Costprice { get; set; }
        [Column("synmongoflag")]
        [StringLength(255)]
        public string Synmongoflag { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
        [Column("bauserid")]
        [StringLength(255)]
        public string Bauserid { get; set; }
        [Column("balancecycle")]
        [StringLength(255)]
        public string Balancecycle { get; set; }
        [Column("ciid")]
        [StringLength(255)]
        public string Ciid { get; set; }
        [Column("oexchangerate")]
        public double? Oexchangerate { get; set; }
        [Column("ccode_1")]
        [StringLength(255)]
        public string Ccode1 { get; set; }
        [Column("accountsrepaygroupid")]
        [StringLength(255)]
        public string Accountsrepaygroupid { get; set; }
        [Column("operatedate")]
        public DateTime? Operatedate { get; set; }
        [Column("dan")]
        [StringLength(255)]
        public string Dan { get; set; }
        [Column("oumoney")]
        public double? Oumoney { get; set; }
        [Column("oricurfeevalue")]
        public double? Oricurfeevalue { get; set; }
        [Column("fsname")]
        [StringLength(255)]
        public string Fsname { get; set; }
        [Column("userid")]
        public double? Userid { get; set; }
        [Column("transno")]
        [StringLength(255)]
        public string Transno { get; set; }
        [Column("deductfee")]
        public double? Deductfee { get; set; }
        [Column("isdelete")]
        [StringLength(255)]
        public string Isdelete { get; set; }
        [Column("ptid")]
        [StringLength(255)]
        public string Ptid { get; set; }
        [Column("hedgingid")]
        [StringLength(255)]
        public string Hedgingid { get; set; }
        [Column("occode")]
        [StringLength(255)]
        public string Occode { get; set; }
        [Column("posttypename")]
        [StringLength(255)]
        public string Posttypename { get; set; }
    }
}
