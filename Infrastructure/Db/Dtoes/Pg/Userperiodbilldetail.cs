using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("userperiodbilldetail")]
    public partial class Userperiodbilldetail
    {
        [Column("ccode")]
        [StringLength(255)]
        public string Ccode { get; set; }
        [Column("packtype")]
        public double? Packtype { get; set; }
        [Column("feeitemclasses", TypeName = "json")]
        public string Feeitemclasses { get; set; }
        [Column("receivestationname")]
        [StringLength(255)]
        public string Receivestationname { get; set; }
        [Column("rechagetypedesc")]
        [StringLength(255)]
        public string Rechagetypedesc { get; set; }
        [Column("receivestationid")]
        [StringLength(255)]
        public string Receivestationid { get; set; }
        [Column("periodkey")]
        [StringLength(255)]
        public string Periodkey { get; set; }
        [Column("hedginggroup")]
        [StringLength(255)]
        public string Hedginggroup { get; set; }
        [Column("remark")]
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("currencycode")]
        [StringLength(255)]
        public string Currencycode { get; set; }
        [Column("formula")]
        [StringLength(255)]
        public string Formula { get; set; }
        [Column("rechagetype")]
        public double? Rechagetype { get; set; }
        [Column("umoney")]
        [StringLength(255)]
        public string Umoney { get; set; }
        [Column("deducttype")]
        public double? Deducttype { get; set; }
        [Column("apiorderid")]
        [StringLength(255)]
        public string Apiorderid { get; set; }
        [Column("hedgingflag_1")]
        public double? Hedgingflag1 { get; set; }
        [Column("businessuserid")]
        public double? Businessuserid { get; set; }
        [Column("feestype")]
        public double? Feestype { get; set; }
        [Column("posttypeid")]
        [StringLength(255)]
        public string Posttypeid { get; set; }
        [Column("ioflag")]
        public double? Ioflag { get; set; }
        [Column("hedgingflag")]
        public double? Hedgingflag { get; set; }
        [Column("itemmoney")]
        public double? Itemmoney { get; set; }
        [Column("leftmoney")]
        [StringLength(255)]
        public string Leftmoney { get; set; }
        [Column("countryid")]
        [StringLength(255)]
        public string Countryid { get; set; }
        [Column("operatorname")]
        [StringLength(255)]
        public string Operatorname { get; set; }
        [Column("receiver")]
        [StringLength(255)]
        public string Receiver { get; set; }
        [Column("orderplatform")]
        [StringLength(255)]
        public string Orderplatform { get; set; }
        [Column("city")]
        [StringLength(255)]
        public string City { get; set; }
        [Column("orderid")]
        [StringLength(255)]
        public string Orderid { get; set; }
        [Column("province")]
        [StringLength(255)]
        public string Province { get; set; }
        [Column("weight")]
        [StringLength(255)]
        public string Weight { get; set; }
        [Column("moneyrecordid")]
        [StringLength(255)]
        public string Moneyrecordid { get; set; }
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
        [Column("billid")]
        [StringLength(255)]
        public string Billid { get; set; }
        [Column("traceid")]
        [StringLength(255)]
        public string Traceid { get; set; }
        [Column("cname")]
        [StringLength(255)]
        public string Cname { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [Column("exchangerate")]
        public double? Exchangerate { get; set; }
        [Column("countryname")]
        [StringLength(255)]
        public string Countryname { get; set; }
        [Column("chargeclass")]
        public double? Chargeclass { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("ordercount")]
        public double? Ordercount { get; set; }
        [Column("costprice")]
        public double? Costprice { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
        [Column("transitno")]
        [StringLength(255)]
        public string Transitno { get; set; }
        [Column("zipcode")]
        [StringLength(255)]
        public string Zipcode { get; set; }
        [Column("address2")]
        [StringLength(255)]
        public string Address2 { get; set; }
        [Column("address1")]
        [StringLength(255)]
        public string Address1 { get; set; }
        [Column("operatorid")]
        public double? Operatorid { get; set; }
        [Column("packtypedesc")]
        [StringLength(255)]
        public string Packtypedesc { get; set; }
        [Column("periodid")]
        [StringLength(255)]
        public string Periodid { get; set; }
        [Column("mobile")]
        [StringLength(255)]
        public string Mobile { get; set; }
        [Column("posttypename")]
        [StringLength(255)]
        public string Posttypename { get; set; }
        [Column("balancecycletype")]
        public double? Balancecycletype { get; set; }
        [Column("oricurfeevalue")]
        public double? Oricurfeevalue { get; set; }
        [Column("businessusername")]
        [StringLength(255)]
        public string Businessusername { get; set; }
        [Column("chargeplatform")]
        public double? Chargeplatform { get; set; }
        [Column("transno")]
        [StringLength(255)]
        public string Transno { get; set; }
        [Column("uaccountname")]
        [StringLength(255)]
        public string Uaccountname { get; set; }
        [Column("hedgingid")]
        [StringLength(255)]
        public string Hedgingid { get; set; }
    }
}
