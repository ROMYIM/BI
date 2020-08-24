using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Wishordercollection
    {
        public DateTime? Signtime { get; set; }
        public string Address { get; set; }
        public DateTime? Createtime { get; set; }
        public bool? Issign { get; set; }
        public string City { get; set; }
        public string Channelid { get; set; }
        public string Orderid { get; set; }
        public string Province { get; set; }
        public string Signer { get; set; }
        public DateTime? Utccreatetime { get; set; }
        public bool? Isdelete { get; set; }
        public string Traceid { get; set; }
        public double? Dataversion { get; set; }
        public string Id { get; set; }
        public string Posttypeid { get; set; }
        public DateTime? Utcmodifytime { get; set; }
        public DateTime? Utccanceltime { get; set; }
    }
}
