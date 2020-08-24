using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Tempprintorderhistory
    {
        public string Operatename { get; set; }
        public string Operatorname { get; set; }
        public string Newchanneltraceid { get; set; }
        public DateTime? Createtime { get; set; }
        public string Oldchanneltraceid { get; set; }
        public string Id { get; set; }
        public string Orderid { get; set; }
        public string Tracknumber { get; set; }
    }
}
