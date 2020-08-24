using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Zipcoderule
    {
        public DateTime? Utccreatetime { get; set; }
        public string Zipdigit { get; set; }
        public string Zipregular { get; set; }
        public string Creationtime { get; set; }
        public double? Dataversion { get; set; }
        public string Id { get; set; }
        public string Countrycode { get; set; }
        public DateTime? Utcmodifytime { get; set; }
        public DateTime? Utccanceltime { get; set; }
    }
}
