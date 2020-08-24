using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Abroadquestiontype
    {
        public DateTime? Operatetime { get; set; }
        public double? Questionsection { get; set; }
        public string Description { get; set; }
        public double? Creatorid { get; set; }
        public DateTime? Createtime { get; set; }
        public double? Operatorid { get; set; }
        public string Id { get; set; }
        public string Code { get; set; }
    }
}
