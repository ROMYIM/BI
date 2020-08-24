using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Testmodel
    {
        public string Id { get; set; }
        public DateTime? Utccreatetime { get; set; }
        public DateTime? Utcmodifytime { get; set; }
        public DateTime? Utccanceltime { get; set; }
        public double? Dataversion { get; set; }
        public string Name { get; set; }
        public double? Type { get; set; }
        public double? Quantity { get; set; }
    }
}
