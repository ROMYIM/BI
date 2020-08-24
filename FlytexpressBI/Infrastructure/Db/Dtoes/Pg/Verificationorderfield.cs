using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Verificationorderfield
    {
        public string Isdefault { get; set; }
        public string Names { get; set; }
        public double? Moduletype { get; set; }
        public double? Filetype { get; set; }
        public double? Resourcetype { get; set; }
        public string Id { get; set; }
        public string Annotation { get; set; }
    }
}
