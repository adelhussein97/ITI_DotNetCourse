using Domains;
using Microsoft.EntityFrameworkCore;

namespace ECommerceDbContext
{
    public class ECommerce_DbContext : DbContext
    {
        // Dependancy Injection call base 
        public ECommerce_DbContext(DbContextOptions<ECommerce_DbContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product_Image> Product_Images { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
