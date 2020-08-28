using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("tbcorderparent")]
    public partial class Tbcorderparent
    {
        [Column("ccode")]
        [StringLength(255)]
        public string Ccode { get; set; }
        [Column("zip")]
        [StringLength(255)]
        public string Zip { get; set; }
        [Column("goodstype")]
        public double? Goodstype { get; set; }
        [Column("countweight")]
        public double? Countweight { get; set; }
        [Column("salesplatformmsg")]
        [StringLength(255)]
        public string Salesplatformmsg { get; set; }
        [Column("tbcordercheckinfos", TypeName = "json")]
        public string Tbcordercheckinfos { get; set; }
        [Column("haikwanproductid")]
        [StringLength(255)]
        public string Haikwanproductid { get; set; }
        [Column("countweightunit")]
        public double? Countweightunit { get; set; }
        [Column("osid")]
        public double? Osid { get; set; }
        [Column("freight")]
        [StringLength(255)]
        public string Freight { get; set; }
        [Column("deliverytype")]
        public bool? Deliverytype { get; set; }
        [Column("isdeleted")]
        public bool? Isdeleted { get; set; }
        [Column("isparent")]
        public bool? Isparent { get; set; }
        [Column("salesplatformwebsit")]
        [StringLength(255)]
        public string Salesplatformwebsit { get; set; }
        [Column("receivermergemd5")]
        [StringLength(255)]
        public string Receivermergemd5 { get; set; }
        [Column("isprinted")]
        public bool? Isprinted { get; set; }
        [Column("paymenttime")]
        public DateTime? Paymenttime { get; set; }
        [Column("importtime")]
        public DateTime? Importtime { get; set; }
        [Column("remarks", TypeName = "json")]
        public string Remarks { get; set; }
        [Column("confirmedremark")]
        [StringLength(255)]
        public string Confirmedremark { get; set; }
        [Column("ispassverification")]
        public bool? Ispassverification { get; set; }
        [Column("issplit")]
        public bool? Issplit { get; set; }
        [Column("width")]
        public double? Width { get; set; }
        [Column("ciid")]
        [StringLength(255)]
        public string Ciid { get; set; }
        [Column("processcenterid")]
        [StringLength(255)]
        public string Processcenterid { get; set; }
        [Column("receivedtime")]
        public DateTime? Receivedtime { get; set; }
        [Column("length")]
        public double? Length { get; set; }
        [Column("totalprice")]
        [StringLength(255)]
        public string Totalprice { get; set; }
        [Column("multipackagequantity")]
        public double? Multipackagequantity { get; set; }
        [Column("orderdetailsfirstsku")]
        [StringLength(255)]
        public string Orderdetailsfirstsku { get; set; }
        [Column("ptid")]
        [StringLength(255)]
        public string Ptid { get; set; }
        [Column("onlineshopname")]
        [StringLength(255)]
        public string Onlineshopname { get; set; }
        [Column("rsid")]
        [StringLength(255)]
        public string Rsid { get; set; }
        [Column("haikwangtid")]
        [StringLength(255)]
        public string Haikwangtid { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("_tbcordercheckinfos", TypeName = "json")]
        public string Tbcordercheckinfos1 { get; set; }
        [Column("packtype")]
        public double? Packtype { get; set; }
        [Column("ordervolume")]
        public double? Ordervolume { get; set; }
        [Column("receiverandshopmergemd5")]
        [StringLength(255)]
        public string Receiverandshopmergemd5 { get; set; }
        [Column("apiorderids", TypeName = "json")]
        public string Apiorderids { get; set; }
        [Column("onlineshippingtype")]
        [StringLength(255)]
        public string Onlineshippingtype { get; set; }
        [Column("ordertype")]
        public double? Ordertype { get; set; }
        [Column("isdeducted")]
        public bool? Isdeducted { get; set; }
        [Column("haikwanccode")]
        [StringLength(255)]
        public string Haikwanccode { get; set; }
        [Column("city")]
        [StringLength(255)]
        public string City { get; set; }
        [Column("weight")]
        public double? Weight { get; set; }
        [Column("hasreturnedtraceid")]
        public bool? Hasreturnedtraceid { get; set; }
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
        [Column("senttime")]
        public DateTime? Senttime { get; set; }
        [Column("traceid")]
        [StringLength(255)]
        public string Traceid { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
        [Column("receiverstateabbreviation")]
        [StringLength(255)]
        public string Receiverstateabbreviation { get; set; }
        [Column("weightunit")]
        public double? Weightunit { get; set; }
        [Column("ispaytariffs")]
        public bool? Ispaytariffs { get; set; }
        [Column("county")]
        [StringLength(255)]
        public string County { get; set; }
        [Column("buyerid")]
        [StringLength(255)]
        public string Buyerid { get; set; }
        [Column("phone")]
        [StringLength(255)]
        public string Phone { get; set; }
        [Column("postedtime")]
        public DateTime? Postedtime { get; set; }
        [Column("syncplatformflag")]
        [StringLength(255)]
        public string Syncplatformflag { get; set; }
        [Column("height")]
        public double? Height { get; set; }
        [Column("salesplatformflag")]
        public double? Salesplatformflag { get; set; }
        [Column("taxnumber")]
        [StringLength(255)]
        public string Taxnumber { get; set; }
        [Column("iscancel")]
        [StringLength(255)]
        public string Iscancel { get; set; }
        [Column("address2")]
        [StringLength(255)]
        public string Address2 { get; set; }
        [Column("inputweight")]
        public double? Inputweight { get; set; }
        [Column("address1")]
        [StringLength(255)]
        public string Address1 { get; set; }
        [Column("salesplatformtransactionids", TypeName = "json")]
        public string Salesplatformtransactionids { get; set; }
        [Column("receivername")]
        [StringLength(255)]
        public string Receivername { get; set; }
        [Column("salesrecordnumbers", TypeName = "json")]
        public string Salesrecordnumbers { get; set; }
        [Column("orderdetailist", TypeName = "json")]
        public string Orderdetailist { get; set; }
        [Column("haikwandetiallist", TypeName = "json")]
        public string Haikwandetiallist { get; set; }
    }
}
