using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Userinfoidentity
    {
        public string Id { get; set; }
        public string Identityno { get; set; }
        public string Identityname { get; set; }
        public string Identitytype { get; set; }
        public DateTime? Operatetime { get; set; }
    }
}
