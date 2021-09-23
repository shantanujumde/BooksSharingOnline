using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BooksSharingOnlineAPI.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string UserName { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }
        [Column(TypeName = "nvarchar(500)")]
        public string Address { get; set; }
    }
}
