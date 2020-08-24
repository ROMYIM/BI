using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Accountinfohistory
    {
        public string Operatename { get; set; }
        public string Operatorname { get; set; }
        public double? Userid { get; set; }
        public string Logcontent { get; set; }
        public DateTime? Operatedate { get; set; }
        public string Id { get; set; }
        public string Accountinfoid { get; set; }
    }
}
