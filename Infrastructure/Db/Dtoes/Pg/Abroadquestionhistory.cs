using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Abroadquestionhistory
    {
        public string Id { get; set; }
        public string Operatename { get; set; }
        public string Operatorname { get; set; }
        public string Content { get; set; }
        public string Statename { get; set; }
        public string Quentionid { get; set; }
        public DateTime? Operatedate { get; set; }
    }
}
