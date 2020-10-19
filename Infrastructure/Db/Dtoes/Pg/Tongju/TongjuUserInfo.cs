using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Infrastructure.Db.Dtoes.Pg.Tongju
{
    [Table("TongjuUserInfo")]
    public class TongjuUserInfo
    {
        [Key]
        public string Id { get; set; }

        public string CnName { get; set; }

        public string EnName { get; set; }

        public int? SalesId { get; set; }

        public int? FuId { get; set; }
    }
}
