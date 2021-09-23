using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BooksSharingOnlineAPI.Models
{
    public class BookModel
    {
        [Key]
        public int BookId { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string BookName { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string AuthorName { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string BookUrl { get; set; }

        [Column(TypeName = "nvarchar(1000)")]
        public string FrontPageUrl { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Price { get; set; }


    }
}
