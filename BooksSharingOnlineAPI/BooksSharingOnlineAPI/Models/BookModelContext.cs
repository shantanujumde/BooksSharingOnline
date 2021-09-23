using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BooksSharingOnlineAPI.Models
{
    public class BookModelContext:DbContext
    {
        public BookModelContext(DbContextOptions<BookModelContext>options):base (options)
        {
                
        }
        public DbSet<BookModel> BookModels { get; set; }
    }
}
