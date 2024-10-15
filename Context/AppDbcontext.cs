using Microsoft.EntityFrameworkCore;
using site2024.Models;

namespace site2024.Context
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base (options) 
        {
                    
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplement> Supplements { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

       
    }
}
