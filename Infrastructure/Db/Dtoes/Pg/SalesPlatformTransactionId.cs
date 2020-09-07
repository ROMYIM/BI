using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("SalesPlatformTransactionId")]
    public class SalesPlatformTransactionId
    {
        [Key]
        public string Id { get; set; }

        public string TransactionId { get; set; }

        public string OrderId { get; set; }
    }
}
