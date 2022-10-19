using CoreBuisness;
using Microsoft.EntityFrameworkCore;

namespace Plugins.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "name", Description = "desc" },
                new Category { CategoryId = 2, Name = "name2", Description = "desc2" },
                new Category { CategoryId = 3, Name = "name3", Description = "desc3" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, CategoryId = 1, Name = "Bread", Quantity = 100, Price = 1.99 },
                new Product { ProductId = 2, CategoryId = 2, Name = "Cola 1l", Quantity = 25, Price = 0.99 },
                new Product { ProductId = 3, CategoryId = 2, Name = "Cola 0.5l", Quantity = 25, Price = 0.99 },
                new Product { ProductId = 4, CategoryId = 3, Name = "Knife", Quantity = 2, Price = 7.99 },
                new Product { ProductId = 5, CategoryId = 3, Name = "Axe", Quantity = 2, Price = 7.99 }
                );
        }

    }
}
