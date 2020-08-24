using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Airbatchfile
    {
        public string Extension { get; set; }
        public string Filekey { get; set; }
        public string Id { get; set; }
        public string Airbatchid { get; set; }
        public DateTime? Createtime { get; set; }
        public string Filename { get; set; }
    }
}
