using BStock.Models;
using Microsoft.EntityFrameworkCore;

namespace BStock.Data
{
    public class StockDbContext(DbContextOptions<StockDbContext> options) : DbContext(options)
    {
        public DbSet<Section> Sections => Set<Section>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Receipt> Receipts => Set<Receipt>();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Section>().HasData
            (
                new Section
                {
                    Id = 1,
                    SectionName = "Food"
                },
                new Section
                {
                    Id = 2,
                    SectionName = "Drinks"
                },
                new Section
                {
                    Id = 3,
                    SectionName = "Office Items"
                }
            );
            modelBuilder.Entity<Product>().HasData
            (
                new Product
                {
                    ProductId = 1,
                    ProductName = "Pizza",
                    Price = 20,
                    Notes = "",

                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "Salad",
                    Price = 10,
                    Notes = "",

                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "Bread",
                    Price = 5,
                    Notes = "",

                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "Water",
                    Price = 1,
                    Notes = "",

                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "Cola",
                    Price = 5,
                    Notes = "",

                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "Pepsi",
                    Price = 10,
                    Notes = "",

                },
                new Product
                {
                    ProductId = 7,
                    ProductName = "Inc Pen",
                    Price = 5,
                    Notes = "",

                },
                new Product
                {
                    ProductId = 8,
                    ProductName = "Stack of Paper",
                    Price = 10,
                    Notes = "",

                },
                new Product
                {
                    ProductId = 9,
                    ProductName = "Scissors",
                    Price = 10,
                    Notes = "",

                }

            );

        }
    }

}
