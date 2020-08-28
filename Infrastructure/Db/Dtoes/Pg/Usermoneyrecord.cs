using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    [Table("usermoneyrecord")]
    public partial class Usermoneyrecord
    {
        [Column("ccode")]
        [StringLength(255)]
        public string Ccode { get; set; }
        [Column("buserid")]
        [StringLength(255)]
        public string Buserid { get; set; }
        [Column("rechagetype")]
        public int Rechagetype { get; set; }
        [Column("tranceid")]
        [StringLength(255)]
        public string Tranceid { get; set; }
        [Column("costptid")]
        [StringLength(255)]
        public string Costptid { get; set; }
        [Column("costmoney")]
        [StringLength(255)]
        public string Costmoney { get; set; }
        [Column("uaccount")]
        [StringLength(255)]
        public string Uaccount { get; set; }
        [Column("depositplatform")]
        public int Depositplatform { get; set; }
        [Column("aubalancedate")]
        [StringLength(255)]
        public string Aubalancedate { get; set; }
        [Column("rid")]
        [StringLength(255)]
        public string Rid { get; set; }
        [Column("balancedate")]
        [StringLength(255)]
        public string Balancedate { get; set; }
        [Column("hedginggroup")]
        [StringLength(255)]
        public string Hedginggroup { get; set; }
        [Column("remark")]
        [StringLength(255)]
        public string Remark { get; set; }
        [Column("istate")]
        public int Istate { get; set; }
        [Column("uid")]
        [StringLength(255)]
        public string Uid { get; set; }
        [Column("utccreatetime")]
        public DateTime Utccreatetime { get; set; }
        [Column("chargebackplatform")]
        public int Chargebackplatform { get; set; }
        //[Column("sopids")]
        //[StringLength(255)]
        //public string Sopids { get; set; }
        [Column("umoney")]
        public double Umoney { get; set; }
        [Column("deducttype")]
        public int Deducttype { get; set; }
        [Column("feestype")]
        public int Feestype { get; set; }
        [Column("ordercount")]
        public double Ordercount { get; set; }
        [Column("ioflag")]
        public int Ioflag { get; set; }
        [Column("synmongoflag")]
        [StringLength(255)]
        public bool Synmongoflag { get; set; }
        [Column("hedgingflag")]
        public int Hedgingflag { get; set; }
        [Column("utccanceltime")]
        public DateTime Utccanceltime { get; set; }
        [Column("bauserid")]
        [StringLength(255)]
        public string Bauserid { get; set; }
        [Column("leftmoney")]
        public double Leftmoney { get; set; }
        [Column("balancecycle")]
        [StringLength(255)]
        public string Balancecycle { get; set; }
        [Column("ciid")]
        [StringLength(255)]
        public string Ciid { get; set; }
        [Column("operatedate")]
        public DateTime Operatedate { get; set; }
        [Column("orderid")]
        [StringLength(255)]
        public string Orderid { get; set; }

        //[Column("userfeesclassitemslist")]
        //public string Userfeesclassitemslist { get; set; }

        [Column("weight")]
        [StringLength(255)]
        public string Weight { get; set; }
        [Column("dan")]
        [StringLength(255)]
        public string Dan { get; set; }

        //[Column("costposttypefeesclassitemslist")]
        //public string Costposttypefeesclassitemslist { get; set; }

        [Column("fsname")]
        [StringLength(255)]
        public string Fsname { get; set; }
        [Column("userid")]
        public int Userid { get; set; }
        [Column("transno")]
        [StringLength(255)]
        public string Transno { get; set; }
        [Column("costposttypename")]
        [StringLength(255)]
        public string Costposttypename { get; set; }

        [Column("ptid")]
        [StringLength(255)]
        public string Ptid { get; set; }
        [Key]
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [Column("utcmodifytime")]
        public DateTime Utcmodifytime { get; set; }
        [Column("hedgingid")]
        [StringLength(255)]
        public string Hedgingid { get; set; }
        [Column("posttypename")]
        [StringLength(255)]
        public string Posttypename { get; set; }
    }
}
