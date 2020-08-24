using System;
using System.Collections.Generic;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class UserInResource
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Resources { get; set; }
    }
}
