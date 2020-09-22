using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("PeriodMoney")]
    public class PeriodMoney
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string PeriodKey { get; set; }

        public double Money { get; set; }

        public string UserMoneyRecordId { get; set; }
    }
}
