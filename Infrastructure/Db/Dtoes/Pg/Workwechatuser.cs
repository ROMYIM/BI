using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Workwechatuser
    {
        public string Id { get; set; }
        public string Openid { get; set; }
        public double? Userid { get; set; }
        public DateTime? Createtime { get; set; }
    }
}
