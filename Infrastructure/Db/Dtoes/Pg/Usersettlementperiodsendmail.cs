using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Usersettlementperiodsendmail
    {
        public string Eobjecttype { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string Cpid { get; set; }
        public string Uaccount { get; set; }
        public string Title { get; set; }
        public string Id { get; set; }
        public DateTime? Createdate { get; set; }
    }
}
