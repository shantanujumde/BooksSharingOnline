using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BooksSharingOnlineAPI.Models
{
    public class CartModelContext : DbContext
    {
        public CartModelContext(DbContextOptions<CartModelContext> options) : base(options)
        {

        }
        public DbSet<CartModel> CartModels { get; set; }
    }
}
