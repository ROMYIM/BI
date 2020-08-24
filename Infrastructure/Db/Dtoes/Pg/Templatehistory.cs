using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Templatehistory
    {
        public string Operator { get; set; }
        public string Xmltemplate { get; set; }
        public DateTime? Time { get; set; }
        public double? Id { get; set; }
        public string Originjsontemplate { get; set; }
        public string Reason { get; set; }
        public double? Templateid { get; set; }
        public string Name { get; set; }
    }
}
