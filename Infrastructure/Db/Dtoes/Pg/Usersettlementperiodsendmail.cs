using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("usersettlementperiodsendmail")]
    public partial class Usersettlementperiodsendmail
    {
        [Column("eobjecttype")]
        [StringLength(255)]
        public string Eobjecttype { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("message")]
        [StringLength(255)]
        public string Message { get; set; }
        [Column("cpid")]
        [StringLength(255)]
        public string Cpid { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
        [Column("title")]
        [StringLength(255)]
        public string Title { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("createdate")]
        public DateTime? Createdate { get; set; }
    }
}
