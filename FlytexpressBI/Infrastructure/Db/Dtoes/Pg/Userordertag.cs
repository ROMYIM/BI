using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Userordertag
    {
        public DateTime? Creationtime { get; set; }
        public string Tagid { get; set; }
        public double? Tagtype { get; set; }
        public string Id { get; set; }
        public string Tagname { get; set; }
        public string Uaccount { get; set; }
    }
}
