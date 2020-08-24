using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Userverification
    {
        public string Userid { get; set; }
        public string Username { get; set; }
        public string Longitudelatitude { get; set; }
        public string Pictureattachs { get; set; }
        public string Id { get; set; }
        public DateTime? Operatetime { get; set; }
    }
}
