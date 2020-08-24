using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Windowsservice
    {
        public string Creater { get; set; }
        public string Processname { get; set; }
        public string Description { get; set; }
        public DateTime? Createtime { get; set; }
        public DateTime? Lastruntime { get; set; }
        public string Enable { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
