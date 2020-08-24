using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Userperiodbillrecord
    {
        public string Havearrearagerecord { get; set; }
        public string Md5code { get; set; }
        public DateTime? Periodupdatetime { get; set; }
        public string Isoverdatetime { get; set; }
        public string Uaccount { get; set; }
        public string Periodkey { get; set; }
        public string Currencycode { get; set; }
        public string Repaysettlementperiodleftmoney { get; set; }
        public string Postingmoney { get; set; }
        public DateTime? Settlementbegintime { get; set; }
        public DateTime? Periodcreatetime { get; set; }
        public DateTime? Balanceendtime { get; set; }
        public string Repaysettlementperiodmoney { get; set; }
        public string Isgeneral { get; set; }
        public DateTime? Settlementendtime { get; set; }
        public DateTime? Createtime { get; set; }
        public string Settlementperiodmoney { get; set; }
        public string Currencyname { get; set; }
        public DateTime? Operatetime { get; set; }
        public double? Balancecycletype { get; set; }
        public double? Balancedays { get; set; }
        public string Beginbalance { get; set; }
        public double? Creditdays { get; set; }
        public string Id { get; set; }
        public string Ishandled { get; set; }
    }
}
