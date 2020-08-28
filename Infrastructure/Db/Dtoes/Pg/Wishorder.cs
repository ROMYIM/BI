using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("wishorder")]
    public partial class Wishorder
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("shippingdetail", TypeName = "json")]
        public string Shippingdetail { get; set; }
        [Column("laseupdated")]
        [StringLength(255)]
        public string Laseupdated { get; set; }
        [Column("ordertime")]
        public DateTime? Ordertime { get; set; }
        [Column("quantity")]
        public double? Quantity { get; set; }
        [Column("color")]
        [StringLength(255)]
        public string Color { get; set; }
        [Column("price")]
        [StringLength(255)]
        public string Price { get; set; }
        [Column("variantid")]
        [StringLength(255)]
        public string Variantid { get; set; }
        [Column("cost")]
        [StringLength(255)]
        public string Cost { get; set; }
        [Column("shippingcost")]
        [StringLength(255)]
        public string Shippingcost { get; set; }
        [Column("hourstofulfill")]
        [StringLength(255)]
        public string Hourstofulfill { get; set; }
        [Column("productimageurl")]
        [StringLength(255)]
        public string Productimageurl { get; set; }
        [Column("size")]
        [StringLength(255)]
        public string Size { get; set; }
        [Column("sku")]
        [StringLength(255)]
        public string Sku { get; set; }
        [Column("ordertotal")]
        [StringLength(255)]
        public string Ordertotal { get; set; }
        [Column("productid")]
        [StringLength(255)]
        public string Productid { get; set; }
        [Column("shipping")]
        [StringLength(255)]
        public string Shipping { get; set; }
        [Column("orderid")]
        [StringLength(255)]
        public string Orderid { get; set; }
        [Column("state")]
        [StringLength(255)]
        public string State { get; set; }
        [Column("daystofulfill")]
        [StringLength(255)]
        public string Daystofulfill { get; set; }
        [Column("productname")]
        [StringLength(255)]
        public string Productname { get; set; }
        [Column("transactionid")]
        [StringLength(255)]
        public string Transactionid { get; set; }
        [Column("buyerid")]
        [StringLength(255)]
        public string Buyerid { get; set; }
        [Column("trackingnumber")]
        [StringLength(255)]
        public string Trackingnumber { get; set; }
        [Column("shopid")]
        [StringLength(255)]
        public string Shopid { get; set; }
        [Column("downloadtime")]
        public DateTime? Downloadtime { get; set; }
        [Column("isdownload")]
        public bool? Isdownload { get; set; }
    }
}
