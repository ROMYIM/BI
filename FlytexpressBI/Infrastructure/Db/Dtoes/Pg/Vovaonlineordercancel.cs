using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Vovaonlineordercancel
    {
        public DateTime? Utccreatetime { get; set; }
        public string Apikey { get; set; }
        public string Cancelreason { get; set; }
        public string Vovapostordersn { get; set; }
        public string Apiusername { get; set; }
        public double? Dataversion { get; set; }
        public string Id { get; set; }
        public string Logisticstrackingnumber { get; set; }
        public DateTime? Utcmodifytime { get; set; }
        public string Timestamp { get; set; }
        public DateTime? Utccanceltime { get; set; }
    }
}
