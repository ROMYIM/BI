using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Userorderpreparemoneyrecord
    {
        public string Md5code { get; set; }
        public DateTime? Createdatetime { get; set; }
        public string Isdelete { get; set; }
        public string Uaccount { get; set; }
        public double? Feestype { get; set; }
        public string Id { get; set; }
        public string Orderid { get; set; }
        public DateTime? Updatetime { get; set; }
    }
}
