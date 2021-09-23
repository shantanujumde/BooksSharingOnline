using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BooksSharingOnlineAPI.Models
{
    public class CartModel
    {
        [Key]
        public int CartId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string UserId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string BookId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Ratings { get; set; }
    }
}
