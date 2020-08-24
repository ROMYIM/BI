using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Weightingset
    {
        public DateTime? Operatedatetime { get; set; }
        public string Companyid { get; set; }
        public string Isdelete { get; set; }
        public double? Operateuserid { get; set; }
        public string Feesweight { get; set; }
        public string Serviceprescriptionweight { get; set; }
        public string Id { get; set; }
        public string Servicelevelweight { get; set; }
        public string Remark { get; set; }
    }
}
