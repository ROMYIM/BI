using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class Zipcode
    {
        public string Startzip { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Id { get; set; }
        public string Alphatwo { get; set; }
        public string Endzip { get; set; }
        public string Alphathress { get; set; }
    }
}
