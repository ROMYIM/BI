using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Tempprintrule
    {
        public string Description { get; set; }
        public string Targetchannelid { get; set; }
        public string Customer { get; set; }
        public double? Creatorid { get; set; }
        public DateTime? Createtime { get; set; }
        public double? Operatorid { get; set; }
        public string Countrys { get; set; }
        public DateTime? Operatetime { get; set; }
        public string Originalchannelids { get; set; }
        public string Id { get; set; }
        public string Isgettargettracknumber { get; set; }
        public string Rulename { get; set; }
    }
}
