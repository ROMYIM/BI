using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("abroadorderparent")]
    public partial class Abroadorderparent
    {
        [Column("_id")]
        public int? Id { get; set; }
        [Column("ccode")]
        [StringLength(255)]
        public string Ccode { get; set; }
        [Column("haikwangtid")]
        [StringLength(255)]
        public string Haikwangtid { get; set; }
        [Column("zip")]
        [StringLength(255)]
        public string Zip { get; set; }
        [Column("goodstype")]
        public double? Goodstype { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("countweight")]
        public double? Countweight { get; set; }
        [Column("salesplatformmsg")]
        [StringLength(255)]
        public string Salesplatformmsg { get; set; }
        [Column("packtype")]
        public double? Packtype { get; set; }
        [Column("ordervolume")]
        public double? Ordervolume { get; set; }
        [Column("lastprinttime")]
        public DateTime? Lastprinttime { get; set; }
        [Column("haikwanproductid")]
        [StringLength(255)]
        public string Haikwanproductid { get; set; }
        [Column("countweightunit")]
        public double? Countweightunit { get; set; }
        [Column("onlineshippingtype")]
        [StringLength(255)]
        public string Onlineshippingtype { get; set; }
        [Column("synabroadatetime")]
        [StringLength(255)]
        public string Synabroadatetime { get; set; }
        [Column("ordertype")]
        public double? Ordertype { get; set; }
        [Column("isdeducted")]
        [StringLength(255)]
        public string Isdeducted { get; set; }
        [Column("osid")]
        public double? Osid { get; set; }
        [Column("freight")]
        [StringLength(255)]
        public string Freight { get; set; }
        [Column("deliverytype")]
        [StringLength(255)]
        public string Deliverytype { get; set; }
        [Column("isresended")]
        [StringLength(255)]
        public string Isresended { get; set; }
        [Column("haikwanccode")]
        [StringLength(255)]
        public string Haikwanccode { get; set; }
        [Column("isdeleted")]
        [StringLength(255)]
        public string Isdeleted { get; set; }
        [Column("isparent")]
        [StringLength(255)]
        public string Isparent { get; set; }
        [Column("salesplatformwebsit")]
        [StringLength(255)]
        public string Salesplatformwebsit { get; set; }
        [Column("city")]
        [StringLength(255)]
        public string City { get; set; }
        [Column("weight")]
        public double? Weight { get; set; }
        [Column("hasreturnedtraceid")]
        [StringLength(255)]
        public string Hasreturnedtraceid { get; set; }
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
        [Column("senttime")]
        public DateTime? Senttime { get; set; }
        [Column("receivercompany")]
        [StringLength(255)]
        public string Receivercompany { get; set; }
        [Column("traceid")]
        [StringLength(255)]
        public string Traceid { get; set; }
        [Column("isprinted")]
        [StringLength(255)]
        public string Isprinted { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
        [Column("receiverstateabbreviation")]
        [StringLength(255)]
        public string Receiverstateabbreviation { get; set; }
        [Column("weightunit")]
        public double? Weightunit { get; set; }
        [Column("firstapiorderid")]
        [StringLength(255)]
        public string Firstapiorderid { get; set; }
        [Column("paymenttime")]
        public DateTime? Paymenttime { get; set; }
        [Column("syndomesticdatetime")]
        [StringLength(255)]
        public string Syndomesticdatetime { get; set; }
        [Column("importtime")]
        public DateTime? Importtime { get; set; }
        [Column("ispaytariffs")]
        [StringLength(255)]
        public string Ispaytariffs { get; set; }
        [Column("county")]
        [StringLength(255)]
        public string County { get; set; }
        [Column("exceptionstate")]
        public double? Exceptionstate { get; set; }
        [Column("Remarks[0]")]
        [StringLength(255)]
        public string Remarks0 { get; set; }
        [Column("buyerid")]
        [StringLength(255)]
        public string Buyerid { get; set; }
        [Column("phone")]
        [StringLength(255)]
        public string Phone { get; set; }
        [Column("postedtime")]
        public DateTime? Postedtime { get; set; }
        [Column("confirmedremark")]
        [StringLength(255)]
        public string Confirmedremark { get; set; }
        [Column("syncplatformflag")]
        [StringLength(255)]
        public string Syncplatformflag { get; set; }
        [Column("height")]
        public double? Height { get; set; }
        [Column("issplit")]
        [StringLength(255)]
        public string Issplit { get; set; }
        [Column("salesplatformflag")]
        public double? Salesplatformflag { get; set; }
        [Column("taxnumber")]
        [StringLength(255)]
        public string Taxnumber { get; set; }
        [Column("width")]
        public double? Width { get; set; }
        [Column("ciid")]
        [StringLength(255)]
        public string Ciid { get; set; }
        [Column("transitno")]
        [StringLength(255)]
        public string Transitno { get; set; }
        [Column("processcenterid")]
        [StringLength(255)]
        public string Processcenterid { get; set; }
        [Column("address2")]
        [StringLength(255)]
        public string Address2 { get; set; }
        [Column("inputweight")]
        public double? Inputweight { get; set; }
        [Column("address1")]
        [StringLength(255)]
        public string Address1 { get; set; }
        [Column("receivedtime")]
        public DateTime? Receivedtime { get; set; }
        public double? Length { get; set; }
        [Column("SalesPlatformTransactionIds[0]")]
        [StringLength(255)]
        public string SalesPlatformTransactionIds0 { get; set; }
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
        [Column("receivername")]
        [StringLength(255)]
        public string Receivername { get; set; }
    }
}
