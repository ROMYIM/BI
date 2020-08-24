using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Userperiodbilllog
    {
        public DateTime? Operatetime { get; set; }
        public string Operatename { get; set; }
        public string Operatorname { get; set; }
        public string Periodid { get; set; }
        public string Id { get; set; }
        public string Operatelog { get; set; }
    }
}
