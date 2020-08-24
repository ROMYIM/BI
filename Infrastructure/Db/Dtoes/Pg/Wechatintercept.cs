using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Wechatintercept
    {
        public string Operator { get; set; }
        public string Wechattime { get; set; }
        public double? State { get; set; }
        public DateTime? Createtime { get; set; }
        public string Id { get; set; }
        public string Code { get; set; }
        public string Reason { get; set; }
        public string Wechatname { get; set; }
    }
}
