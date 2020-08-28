using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("userverification")]
    public partial class Userverification
    {
        [Column("userid")]
        [StringLength(255)]
        public string Userid { get; set; }
        [Column("username")]
        [StringLength(255)]
        public string Username { get; set; }
        [Column("longitudelatitude")]
        [StringLength(255)]
        public string Longitudelatitude { get; set; }
        [Column("pictureattachs", TypeName = "json")]
        public string Pictureattachs { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("operatetime")]
        public DateTime? Operatetime { get; set; }
    }
}
