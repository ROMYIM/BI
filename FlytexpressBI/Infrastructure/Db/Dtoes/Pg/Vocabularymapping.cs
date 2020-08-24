using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Vocabularymapping
    {
        public string Mappingword { get; set; }
        public DateTime? Operatetime { get; set; }
        public string Word { get; set; }
        public DateTime? Createtime { get; set; }
        public double? Createuserid { get; set; }
        public double? Operatorid { get; set; }
        public string Id { get; set; }
    }
}
