using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Usermoneylogs
    {
        public string Id { get; set; }
        public string Computername { get; set; }
        public string Objectid { get; set; }
        public double? Times { get; set; }
        public string Message { get; set; }
        public DateTime? Createdate { get; set; }
        public string Remark { get; set; }
        public string Serviceip { get; set; }
    }
}
