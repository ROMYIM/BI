using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Tableidcounter
    {
        public DateTime? Operatetime { get; set; }
        public string Maxquantities { get; set; }
        public string Countertype { get; set; }
        public string Id { get; set; }
        public string Staticsdate { get; set; }
    }
}
