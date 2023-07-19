

using Microsoft.EntityFrameworkCore;
using Products.Models;

namespace Products.Data
{
	public class ProductsDbContext : DbContext
    {
        public ProductsDbContext(DbContextOptions<ProductsDbContext> options): base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}

