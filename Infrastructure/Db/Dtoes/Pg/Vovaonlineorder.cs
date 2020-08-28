using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("vovaonlineorder")]
    public partial class Vovaonlineorder
    {
        [Column("hasflammable")]
        [StringLength(255)]
        public string Hasflammable { get; set; }
        [Column("name_4")]
        [StringLength(255)]
        public string Name4 { get; set; }
        [Column("hasbattery")]
        [StringLength(255)]
        public string Hasbattery { get; set; }
        [Column("address")]
        [StringLength(255)]
        public string Address { get; set; }
        [Column("logisticsproductid")]
        public double? Logisticsproductid { get; set; }
        [Column("haspowder")]
        [StringLength(255)]
        public string Haspowder { get; set; }
        [Column("height_1")]
        public double? Height1 { get; set; }
        [Column("addressen")]
        [StringLength(255)]
        public string Addressen { get; set; }
        [Column("descriptionlocal_1")]
        [StringLength(255)]
        public string Descriptionlocal1 { get; set; }
        [Column("streetaddress1_2")]
        [StringLength(255)]
        public string Streetaddress12 { get; set; }
        [Column("streetaddress1_1")]
        [StringLength(255)]
        public string Streetaddress11 { get; set; }
        [Column("zipcode")]
        [StringLength(255)]
        public string Zipcode { get; set; }
        [Column("street")]
        [StringLength(255)]
        public string Street { get; set; }
        [Column("logisticstrackingnumber")]
        [StringLength(255)]
        public string Logisticstrackingnumber { get; set; }
        [Column("descriptionlocal")]
        [StringLength(255)]
        public string Descriptionlocal { get; set; }
        [Column("descriptionen")]
        [StringLength(255)]
        public string Descriptionen { get; set; }
        [Column("payername")]
        [StringLength(255)]
        public string Payername { get; set; }
        [Column("city_2")]
        [StringLength(255)]
        public string City2 { get; set; }
        [Column("quantity_1")]
        public double? Quantity1 { get; set; }
        [Column("weight_1")]
        public double? Weight1 { get; set; }
        [Column("city_1")]
        [StringLength(255)]
        public string City1 { get; set; }
        [Column("mobile_1")]
        [StringLength(255)]
        public string Mobile1 { get; set; }
        [Column("incoterm")]
        [StringLength(255)]
        public string Incoterm { get; set; }
        [Column("country")]
        [StringLength(255)]
        public string Country { get; set; }
        [Column("phone_1")]
        [StringLength(255)]
        public string Phone1 { get; set; }
        [Column("name_3")]
        [StringLength(255)]
        public string Name3 { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [Column("pricecurrency")]
        [StringLength(255)]
        public string Pricecurrency { get; set; }
        [Column("name_2")]
        [StringLength(255)]
        public string Name2 { get; set; }
        [Column("name_1")]
        [StringLength(255)]
        public string Name1 { get; set; }
        [Column("apikey")]
        [StringLength(255)]
        public string Apikey { get; set; }
        [Column("vovapostordersn")]
        [StringLength(255)]
        public string Vovapostordersn { get; set; }
        [Column("vovapostordertime")]
        [StringLength(255)]
        public string Vovapostordertime { get; set; }
        [Column("dimensionunit")]
        [StringLength(255)]
        public string Dimensionunit { get; set; }
        [Column("timestamp")]
        [StringLength(255)]
        public string Timestamp { get; set; }
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("descriptionen_1")]
        [StringLength(255)]
        public string Descriptionen1 { get; set; }
        [Column("width")]
        public double? Width { get; set; }
        [Column("payerid")]
        [StringLength(255)]
        public string Payerid { get; set; }
        [Column("flytorderid")]
        [StringLength(255)]
        public string Flytorderid { get; set; }
        [Column("payercontactname")]
        [StringLength(255)]
        public string Payercontactname { get; set; }
        [Column("isliquid")]
        [StringLength(255)]
        public string Isliquid { get; set; }
        [Column("countrycode_1")]
        [StringLength(255)]
        public string Countrycode1 { get; set; }
        [Column("district_1")]
        [StringLength(255)]
        public string District1 { get; set; }
        [Column("mobile")]
        [StringLength(255)]
        public string Mobile { get; set; }
        [Column("district_2")]
        [StringLength(255)]
        public string District2 { get; set; }
        [Column("producturl")]
        [StringLength(255)]
        public string Producturl { get; set; }
        [Column("length")]
        public double? Length { get; set; }
        [Column("payerphone")]
        [StringLength(255)]
        public string Payerphone { get; set; }
        [Column("length_1")]
        public double? Length1 { get; set; }
        [Column("company")]
        [StringLength(255)]
        public string Company { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("payermobile")]
        [StringLength(255)]
        public string Payermobile { get; set; }
        [Column("countryoforigin")]
        [StringLength(255)]
        public string Countryoforigin { get; set; }
        [Column("addresslocal")]
        [StringLength(255)]
        public string Addresslocal { get; set; }
        [Column("declarevalue")]
        public double? Declarevalue { get; set; }
        [Column("street_2")]
        [StringLength(255)]
        public string Street2 { get; set; }
        [Column("street_1")]
        [StringLength(255)]
        public string Street1 { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("hasmetal")]
        [StringLength(255)]
        public string Hasmetal { get; set; }
        [Column("province_1")]
        [StringLength(255)]
        public string Province1 { get; set; }
        [Column("province_2")]
        [StringLength(255)]
        public string Province2 { get; set; }
        [Column("createflytordererrormsg")]
        [StringLength(255)]
        public string Createflytordererrormsg { get; set; }
        [Column("imageurl")]
        [StringLength(255)]
        public string Imageurl { get; set; }
        [Column("city")]
        [StringLength(255)]
        public string City { get; set; }
        [Column("weight")]
        public double? Weight { get; set; }
        [Column("province")]
        [StringLength(255)]
        public string Province { get; set; }
        [Column("countryoforigincode")]
        [StringLength(255)]
        public string Countryoforigincode { get; set; }
        [Column("weightunit_1")]
        [StringLength(255)]
        public string Weightunit1 { get; set; }
        [Column("apiusername")]
        [StringLength(255)]
        public string Apiusername { get; set; }
        [Column("country_2")]
        [StringLength(255)]
        public string Country2 { get; set; }
        [Column("email_1")]
        [StringLength(255)]
        public string Email1 { get; set; }
        [Column("hasbattery_1")]
        [StringLength(255)]
        public string Hasbattery1 { get; set; }
        [Column("country_1")]
        [StringLength(255)]
        public string Country1 { get; set; }
        [Column("dataversion")]
        public double? Dataversion { get; set; }
        [Column("pickuptype")]
        public double? Pickuptype { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("district")]
        [StringLength(255)]
        public string District { get; set; }
        [Column("isflammable")]
        [StringLength(255)]
        public string Isflammable { get; set; }
        [Column("requirelabel")]
        [StringLength(255)]
        public string Requirelabel { get; set; }
        [Column("weightunit")]
        [StringLength(255)]
        public string Weightunit { get; set; }
        [Column("payeremail")]
        [StringLength(255)]
        public string Payeremail { get; set; }
        [Column("declarevalue_1")]
        public double? Declarevalue1 { get; set; }
        [Column("streetaddress2")]
        [StringLength(255)]
        public string Streetaddress2 { get; set; }
        [Column("streetaddress1")]
        [StringLength(255)]
        public string Streetaddress1 { get; set; }
        [Column("streetaddress2_1")]
        [StringLength(255)]
        public string Streetaddress21 { get; set; }
        [Column("phone")]
        [StringLength(255)]
        public string Phone { get; set; }
        [Column("streetaddress2_2")]
        [StringLength(255)]
        public string Streetaddress22 { get; set; }
        [Column("paidwithvova")]
        [StringLength(255)]
        public string Paidwithvova { get; set; }
        [Column("height")]
        public double? Height { get; set; }
        [Column("ispowder")]
        [StringLength(255)]
        public string Ispowder { get; set; }
        [Column("countrycode")]
        [StringLength(255)]
        public string Countrycode { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
        [Column("vovaplatformid")]
        [StringLength(255)]
        public string Vovaplatformid { get; set; }
        [Column("hscode")]
        [StringLength(255)]
        public string Hscode { get; set; }
        [Column("quantity")]
        public double? Quantity { get; set; }
        [Column("iscreateflytorder")]
        [StringLength(255)]
        public string Iscreateflytorder { get; set; }
        [Column("istest")]
        [StringLength(255)]
        public string Istest { get; set; }
        [Column("priceunit")]
        [StringLength(255)]
        public string Priceunit { get; set; }
        [Column("company_1")]
        [StringLength(255)]
        public string Company1 { get; set; }
        [Column("hasmetal_1")]
        [StringLength(255)]
        public string Hasmetal1 { get; set; }
        [Column("width_1")]
        public double? Width1 { get; set; }
        [Column("hasliquid")]
        [StringLength(255)]
        public string Hasliquid { get; set; }
        [Column("zipcode_1")]
        [StringLength(255)]
        public string Zipcode1 { get; set; }
    }
}
