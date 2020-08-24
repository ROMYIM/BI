using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Usernotificationrecord
    {
        public string Hasread { get; set; }
        public string Pushed { get; set; }
        public string Noticeid { get; set; }
        public DateTime? Readtime { get; set; }
        public string Id1 { get; set; }
        public string Uaccount { get; set; }
        public string Id { get; set; }
    }
}
