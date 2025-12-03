using F25W13BlazorWithEf.Models;
using Microsoft.EntityFrameworkCore;

namespace F25W13BlazorWithEf.Data
{
    public class AppDbContext : DbContext
    {
        // constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }

        // entity sets
        public DbSet<Product> Products { get; set; }

        // data seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Laptop", Price = 1000 },
                new Product { Id = 2, Name = "Mobile", Price = 1500 },
                new Product { Id = 3, Name = "Tablet", Price = 500 }
            );
        }
    }
}
