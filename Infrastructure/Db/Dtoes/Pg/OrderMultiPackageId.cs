using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("OrderMultiPackageId")]
    public class OrderMultiPackageId
    {
        [Key]
        public string Id { get; set; }

        public string MultiPackageId { get; set; }

        public string OrderId { get; set; }
    }
}
