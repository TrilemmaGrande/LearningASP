using Microsoft.EntityFrameworkCore;

namespace Beispiel.Sportsstore.Models
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public StoreDbContext(DbContextOptions<StoreDbContext> opts) : base(opts)
        {
            
        }
    }
}
