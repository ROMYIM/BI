using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Abroadquestionimportlogselfreport
    {
        public string Id { get; set; }
        public DateTime? Createdate { get; set; }
        public string Logid { get; set; }
        public string Reportdata { get; set; }
    }
}
