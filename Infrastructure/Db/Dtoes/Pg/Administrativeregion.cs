using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Administrativeregion
    {
        public string Countryid { get; set; }
        public DateTime? Operatetime { get; set; }
        public string Distrcttown { get; set; }
        public string City { get; set; }
        public double? Operatorid { get; set; }
        public string Id { get; set; }
        public string Province { get; set; }
    }
}
