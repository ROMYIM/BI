using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Verificationorderrule
    {
        public string Id { get; set; }
        public string Rulename { get; set; }
        public string Conditions { get; set; }
        public string Optrnodes { get; set; }
        public string Countries { get; set; }
        public string Posttypes { get; set; }
        public string Uiids { get; set; }
        public double? Priority { get; set; }
        public string OperateId { get; set; }
        public DateTime? Operatetime { get; set; }
        public string Operatetype { get; set; }
        public string Id1 { get; set; }
    }
}
