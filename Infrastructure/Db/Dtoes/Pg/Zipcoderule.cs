using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("zipcoderule")]
    public partial class Zipcoderule
    {
        [Column("utccreatetime")]
        public DateTime? Utccreatetime { get; set; }
        [Column("zipdigit")]
        [StringLength(255)]
        public string Zipdigit { get; set; }
        [Column("zipregular")]
        [StringLength(255)]
        public string Zipregular { get; set; }
        [Column("creationtime", TypeName = "json")]
        public string Creationtime { get; set; }
        [Column("dataversion")]
        public double? Dataversion { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("countrycode")]
        [StringLength(255)]
        public string Countrycode { get; set; }
        [Column("utcmodifytime")]
        public DateTime? Utcmodifytime { get; set; }
        [Column("utccanceltime")]
        public DateTime? Utccanceltime { get; set; }
    }
}
