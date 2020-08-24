using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Accountinfo
    {
        public string Ccode { get; set; }
        public string Account { get; set; }
        public string Isdeleted { get; set; }
        public string Operatorname { get; set; }
        public string Username { get; set; }
        public string Receivestationids { get; set; }
        public DateTime? Operatedate { get; set; }
        public double? Accounttype { get; set; }
        public string Currencyname { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public double? Userid { get; set; }
        public string Branchname { get; set; }
        public string Id { get; set; }
        public string Balance { get; set; }
    }
}
