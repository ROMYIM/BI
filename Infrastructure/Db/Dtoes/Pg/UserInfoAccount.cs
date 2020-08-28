using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class UserInfoAccount
    {
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        public double? Uaccount { get; set; }
        [StringLength(255)]
        public string Uaid { get; set; }
    }
}
