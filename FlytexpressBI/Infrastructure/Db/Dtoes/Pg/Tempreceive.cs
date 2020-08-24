using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Tempreceive
    {
        public double? Auid { get; set; }
        public bool? Delflag { get; set; }
        public bool? Trflag { get; set; }
        public double? Userid { get; set; }
        public string Uiid { get; set; }
        public DateTime? Createdatetime { get; set; }
        public DateTime? Operatedate { get; set; }
        public double? Creator { get; set; }
        public string Id { get; set; }
        public DateTime? Enddate { get; set; }
        public DateTime? Begindate { get; set; }
        public string Remark { get; set; }
    }
}
