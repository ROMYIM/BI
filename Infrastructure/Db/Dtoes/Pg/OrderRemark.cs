using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("OrderRemark")]
    public class OrderRemark
    {
        [Key]
        public string Id { get; set; }

        public string Remark { get; set; }

        public string OrderId { get; set; }
    }
}
