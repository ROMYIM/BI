using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg.Tongju
{
    [Table("TongjuUserMoneyRecord")]
    public class TongjuUserMoneyRecord
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string UAccount { get; set; }

        public double LeftMoney { get; set; }

        public DateTime UtcModifyTime { get; set; }
    }
}
