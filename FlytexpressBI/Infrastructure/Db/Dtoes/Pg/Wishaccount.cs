using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Wishaccount
    {
        public string Wishname { get; set; }
        public string Createtime { get; set; }
        public string Tokenenable { get; set; }
        public string Uiid { get; set; }
        public string Uaccount { get; set; }
        public string Enabled { get; set; }
        public string Wishid { get; set; }
        public double? Totalcount { get; set; }
        public string Lastdownloadtime { get; set; }
        public string Refreshtoken { get; set; }
        public string Accesstoken { get; set; }
        public string Clientsecret { get; set; }
        public string Tokenexpire { get; set; }
        public string Clientid { get; set; }
        public string Id { get; set; }
    }
}
