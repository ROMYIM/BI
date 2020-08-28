using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Db.Dtoes.Pg
{
    public partial class UserInResource
    {
        [Key]
        [Column("_id")]
        [StringLength(255)]
        public string Id { get; set; }
        [StringLength(255)]
        public string UserId { get; set; }
        [Column(TypeName = "json")]
        public string Resources { get; set; }
    }
}
