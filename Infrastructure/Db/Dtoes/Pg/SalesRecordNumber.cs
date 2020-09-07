using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("SalesRecordNumber")]
    public class SalesRecordNumber
    {
        [Key]
        public string Id { get; set; }

        public string OrderId { get; set; }

        public int RecordNumber { get; set; }
    }
}
