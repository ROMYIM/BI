using Core.DataAnnotations.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("SalesRecordNumber")]
    [ChildrenTable(ParentTable = "OrderParent")]
    public class SalesRecordNumber
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeginKeyColumn]
        public string OrderId { get; set; }

        public int RecordNumber { get; set; }
    }
}
