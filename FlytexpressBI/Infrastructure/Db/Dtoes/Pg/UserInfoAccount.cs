using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class UserInfoAccount
    {
        public string Id { get; set; }
        public double? Uaccount { get; set; }
        public string Uaid { get; set; }
    }
}
