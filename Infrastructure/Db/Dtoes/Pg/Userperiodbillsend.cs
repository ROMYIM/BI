using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Userperiodbillsend
    {
        public string Billsendbody { get; set; }
        public string Toemails { get; set; }
        public DateTime? Createtime { get; set; }
        public string Billid { get; set; }
        public string Periodid { get; set; }
        public string Id { get; set; }
        public string Billsendsubject { get; set; }
    }
}
