using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("accountinfo")]
    public partial class Accountinfo
    {
        [Column("ccode")]
        [StringLength(255)]
        public string Ccode { get; set; }
        [Column("account")]
        [StringLength(255)]
        public string Account { get; set; }
        [Column("isdeleted")]
        [StringLength(255)]
        public string Isdeleted { get; set; }
        [Column("operatorname")]
        [StringLength(255)]
        public string Operatorname { get; set; }
        [Column("username")]
        [StringLength(255)]
        public string Username { get; set; }
        [Column("receivestationids", TypeName = "json")]
        public string Receivestationids { get; set; }
        [Column("operatedate")]
        public DateTime? Operatedate { get; set; }
        [Column("accounttype")]
        public double? Accounttype { get; set; }
        [Column("currencyname")]
        [StringLength(255)]
        public string Currencyname { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [Column("remark")]
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("userid")]
        public double? Userid { get; set; }
        [Column("branchname")]
        [StringLength(255)]
        public string Branchname { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("balance")]
        [StringLength(255)]
        public string Balance { get; set; }
    }
}
