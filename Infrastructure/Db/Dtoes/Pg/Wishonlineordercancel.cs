using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Wishonlineordercancel
    {
        public DateTime? Utccreatetime { get; set; }
        public string Apikey { get; set; }
        public string Cancelreason { get; set; }
        public double? Dataversion { get; set; }
        public string Id { get; set; }
        public string Logisticsordercode { get; set; }
        public DateTime? Utcmodifytime { get; set; }
        public string Trackingid { get; set; }
        public double? Carrytype { get; set; }
        public DateTime? Utccanceltime { get; set; }
    }
}
