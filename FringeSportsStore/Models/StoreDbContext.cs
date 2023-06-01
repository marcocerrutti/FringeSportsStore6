using Microsoft.EntityFrameworkCore;

namespace FringeSportsStore.Models
{
    public class StoreDbContext: DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options)
        {
            
        }

        public DbSet<Product> Products  => Set<Product>();
    }
}
