using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("wishaccount")]
    public partial class Wishaccount
    {
        [Column("wishname")]
        [StringLength(255)]
        public string Wishname { get; set; }
        [Column("createtime")]
        [StringLength(255)]
        public string Createtime { get; set; }
        [Column("tokenenable")]
        [StringLength(255)]
        public string Tokenenable { get; set; }
        [Column("uiid")]
        [StringLength(255)]
        public string Uiid { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
        [Column("enabled")]
        [StringLength(255)]
        public string Enabled { get; set; }
        [Column("wishid")]
        [StringLength(255)]
        public string Wishid { get; set; }
        [Column("totalcount")]
        public double? Totalcount { get; set; }
        [Column("lastdownloadtime")]
        [StringLength(255)]
        public string Lastdownloadtime { get; set; }
        [Column("refreshtoken")]
        [StringLength(255)]
        public string Refreshtoken { get; set; }
        [Column("accesstoken")]
        [StringLength(255)]
        public string Accesstoken { get; set; }
        [Column("clientsecret")]
        [StringLength(255)]
        public string Clientsecret { get; set; }
        [Column("tokenexpire")]
        [StringLength(255)]
        public string Tokenexpire { get; set; }
        [Column("clientid")]
        [StringLength(255)]
        public string Clientid { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
    }
}
