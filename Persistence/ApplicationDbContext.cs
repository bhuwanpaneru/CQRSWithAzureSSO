using CQRSWithAzureSSO.Domain;

using Microsoft.EntityFrameworkCore;

namespace CQRSWithAzureSSO.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }

}
