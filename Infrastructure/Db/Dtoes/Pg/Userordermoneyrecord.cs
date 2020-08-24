using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Userordermoneyrecord
    {
        public double? Chargebackplatform { get; set; }
        public DateTime? Createdatetime { get; set; }
        public string Isdelete { get; set; }
        public string Uaccount { get; set; }
        public string Id { get; set; }
        public string Orderid { get; set; }
        public DateTime? Updatetime { get; set; }
    }
}
