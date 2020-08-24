using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Airbatchorderdetail
    {
        public string Destinationcountry { get; set; }
        public DateTime? Sendtime { get; set; }
        public string Airbatchid { get; set; }
        public string Postingcountry { get; set; }
        public string Orderid { get; set; }
        public string Pkg { get; set; }
        public string Deliverytime { get; set; }
        public DateTime? Utccreatetime { get; set; }
        public DateTime? Receivetime { get; set; }
        public string Traceid { get; set; }
        public double? Dataversion { get; set; }
        public string Posttypeid { get; set; }
        public string Id { get; set; }
        public DateTime? Utcmodifytime { get; set; }
        public DateTime? Utccanceltime { get; set; }
    }
}
