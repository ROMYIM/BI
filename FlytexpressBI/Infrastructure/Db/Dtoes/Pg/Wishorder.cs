using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Wishorder
    {
        public string Id { get; set; }
        public string Shippingdetail { get; set; }
        public string Laseupdated { get; set; }
        public DateTime? Ordertime { get; set; }
        public double? Quantity { get; set; }
        public string Color { get; set; }
        public string Price { get; set; }
        public string Variantid { get; set; }
        public string Cost { get; set; }
        public string Shippingcost { get; set; }
        public string Hourstofulfill { get; set; }
        public string Productimageurl { get; set; }
        public string Size { get; set; }
        public string Sku { get; set; }
        public string Ordertotal { get; set; }
        public string Productid { get; set; }
        public string Shipping { get; set; }
        public string Orderid { get; set; }
        public string State { get; set; }
        public string Daystofulfill { get; set; }
        public string Productname { get; set; }
        public string Transactionid { get; set; }
        public string Buyerid { get; set; }
        public string Trackingnumber { get; set; }
        public string Shopid { get; set; }
        public DateTime? Downloadtime { get; set; }
        public bool? Isdownload { get; set; }
    }
}
