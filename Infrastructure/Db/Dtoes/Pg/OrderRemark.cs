using Core.DataAnnotations.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("OrderRemark")]
    [ChildrenTable(ParentTable = "OrderParent")]
    public class OrderRemark
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Remark { get; set; }

        [ForeginKeyColumn]
        public string OrderId { get; set; }
    }
}
