using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Abroadquestionlmportlog
    {
        public string Id { get; set; }
        public string Operatename { get; set; }
        public string Operatorname { get; set; }
        public double? Selfreportcount { get; set; }
        public string Isselfreport { get; set; }
        public string Content { get; set; }
        public double? Importcount { get; set; }
        public double? Operatorid { get; set; }
        public double? Errorcount { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
