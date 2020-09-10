using Core.DataAnnotations.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("OrderApiOrderId")]
    [ChildrenTable(ParentTable = "OrderParent")]
    public class OrderApiOrderId
    {
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string ApiOrderId { get; set; }

        [ForeginKeyColumn]
        public string OrderId { get; set; }
    }
}
