using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    [System.ComponentModel.DataAnnotations.Schema.Table("OrderApiOrderId")]
    public class OrderApiOrderId
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string Id { get; set; }

        public string ApiOrderId { get; set; }

        public string OrderId { get; set; }
    }
}
