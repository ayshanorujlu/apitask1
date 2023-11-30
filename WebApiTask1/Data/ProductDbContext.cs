using Microsoft.EntityFrameworkCore;
using WebApiTask1.Entities;

namespace WebApiTask1.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext( DbContextOptions<ProductDbContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
