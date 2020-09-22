using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("SopId")]
    public class SopId 
    {
        [Key]
        [Column("Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("OpId")]
        public string OpId { get; set; }

        [Column("UserMoneyRecordId")]
        public string UserMoneyRecordId { get; set; }
    }
}
