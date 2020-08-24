using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Userinfogroup
    {
        public string Id { get; set; }
        public string Gname { get; set; }
        public DateTime? Operatedate { get; set; }
        public string Userid { get; set; }
        public string Delflag { get; set; }
    }
}
