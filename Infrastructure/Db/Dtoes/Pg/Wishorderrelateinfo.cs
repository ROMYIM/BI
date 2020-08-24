using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Wishorderrelateinfo
    {
        public DateTime? Utccreatetime { get; set; }
        public string Actualuaccount { get; set; }
        public string Uaccount { get; set; }
        public string Traceid { get; set; }
        public double? Dataversion { get; set; }
        public bool? Isbangdingoffline { get; set; }
        public string Platformorderid { get; set; }
        public string Id { get; set; }
        public string Orderid { get; set; }
        public DateTime? Utcmodifytime { get; set; }
        public bool? Isonlinepaied { get; set; }
        public DateTime? Utccanceltime { get; set; }
    }
}
