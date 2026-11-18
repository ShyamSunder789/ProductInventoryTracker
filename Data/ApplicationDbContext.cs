using Microsoft.EntityFrameworkCore;
using ProductInventoryTracker.Models;

namespace ProductInventoryTracker.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
