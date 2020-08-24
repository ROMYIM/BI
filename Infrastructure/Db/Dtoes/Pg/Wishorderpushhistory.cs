using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Wishorderpushhistory
    {
        public bool? Issuccess { get; set; }
        public DateTime? Operatetime { get; set; }
        public string Apiorderid { get; set; }
        public string Traceid { get; set; }
        public string Id { get; set; }
        public string Orderid { get; set; }
        public string Remark { get; set; }
    }
}
