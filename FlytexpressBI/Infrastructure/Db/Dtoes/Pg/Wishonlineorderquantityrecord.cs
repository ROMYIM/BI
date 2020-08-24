using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Wishonlineorderquantityrecord
    {
        public DateTime? Utccreatetime { get; set; }
        public string Recorddate { get; set; }
        public double? Quantity { get; set; }
        public double? Dataversion { get; set; }
        public string Id { get; set; }
        public DateTime? Utcmodifytime { get; set; }
        public DateTime? Utccanceltime { get; set; }
    }
}
