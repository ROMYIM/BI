using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Accountuaccounthistory
    {
        public string Accountinfoname { get; set; }
        public string Operatorname { get; set; }
        public string Content { get; set; }
        public DateTime? Operatedate { get; set; }
        public string Id { get; set; }
        public string Accountinfoid { get; set; }
        public string Uaccount { get; set; }
    }
}
