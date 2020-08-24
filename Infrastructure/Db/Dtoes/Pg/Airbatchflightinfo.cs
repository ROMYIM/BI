using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Airbatchflightinfo
    {
        public string Status { get; set; }
        public double? Serialno { get; set; }
        public string Destinationcity { get; set; }
        public string Departurecity { get; set; }
        public string Batchno { get; set; }
        public string Batchweight { get; set; }
        public string Remark { get; set; }
        public string Station { get; set; }
        public string Airlinemark { get; set; }
        public string Totalweight { get; set; }
        public DateTime? Utccreatetime { get; set; }
        public string Eventtime { get; set; }
        public DateTime? Collecttime { get; set; }
        public string Flightnumber { get; set; }
        public double? Isdelete { get; set; }
        public string Quantities { get; set; }
        public string Id { get; set; }
    }
}
