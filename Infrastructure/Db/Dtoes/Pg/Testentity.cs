using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("testentity")]
    public partial class Testentity
    {
        [Column("cardnumber")]
        [StringLength(255)]
        public string Cardnumber { get; set; }
        [Column("email")]
        [StringLength(255)]
        public string Email { get; set; }
        [Column("address")]
        [StringLength(255)]
        public string Address { get; set; }
        [Column("enname")]
        [StringLength(255)]
        public string Enname { get; set; }
        [Column("opendate")]
        [StringLength(255)]
        public string Opendate { get; set; }
        [Column("uiid")]
        [StringLength(255)]
        public string Uiid { get; set; }
        [Column("token")]
        [StringLength(255)]
        public string Token { get; set; }
        [Column("fuid")]
        [StringLength(255)]
        public string Fuid { get; set; }
        [Column("zhname")]
        [StringLength(255)]
        public string Zhname { get; set; }
        [Column("rid")]
        [StringLength(255)]
        public string Rid { get; set; }
        [Column("name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Column("remark")]
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("uid")]
        [StringLength(255)]
        public string Uid { get; set; }
        [Column("groups")]
        [StringLength(255)]
        public string Groups { get; set; }
        [Column("phone")]
        [StringLength(255)]
        public string Phone { get; set; }
        [Column("msnqq")]
        [StringLength(255)]
        public string Msnqq { get; set; }
        [Column("tokenexpiretime")]
        public DateTime? Tokenexpiretime { get; set; }
        [Column("receiveid")]
        [StringLength(255)]
        public string Receiveid { get; set; }
        [Column("creditrating")]
        public double? Creditrating { get; set; }
        [Column("idctid")]
        [StringLength(255)]
        public string Idctid { get; set; }
        [Column("linkman")]
        [StringLength(255)]
        public string Linkman { get; set; }
        [Column("operatedate")]
        public DateTime? Operatedate { get; set; }
        [Column("stateflag")]
        public double? Stateflag { get; set; }
        public double? Ctid { get; set; }
        [Column("mobile")]
        [StringLength(255)]
        public string Mobile { get; set; }
        [Column("passwd")]
        [StringLength(255)]
        public string Passwd { get; set; }
        [Column("puaccount")]
        [StringLength(255)]
        public string Puaccount { get; set; }
        [Column("cardfilename")]
        [StringLength(255)]
        public string Cardfilename { get; set; }
        [Column("userid")]
        public double? Userid { get; set; }
        [Column("utype")]
        public double? Utype { get; set; }
        [Column("cname")]
        [StringLength(255)]
        public string Cname { get; set; }
        [Column("id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("regtime")]
        public DateTime? Regtime { get; set; }
        [Column("_id")]
        [StringLength(255)]
        public string Id1 { get; set; }
        [Column("fax")]
        [StringLength(255)]
        public string Fax { get; set; }
        [Column("cid")]
        [StringLength(255)]
        public string Cid { get; set; }
    }
}
