using BStock.Models;
using Microsoft.EntityFrameworkCore;

namespace BStock.Data
{
    public class StockDbContext(DbContextOptions<StockDbContext> options) : DbContext(options)
    {
        public DbSet<Section> Sections => Set<Section>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Receipt> Receipts => Set<Receipt>();
        public DbSet<ReceiptProduct> ReceiptProducts => Set<ReceiptProduct>();
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
                    Id = 1,
                    ProductName = "Pizza",
                    Price = 20,
                    Notes = "",

                },
                new Product
                {
                    Id = 2,
                    ProductName = "Salad",
                    Price = 10,
                    Notes = "",

                },
                new Product
                {
                    Id = 3,
                    ProductName = "Bread",
                    Price = 5,
                    Notes = "",

                },
                new Product
                {
                    Id = 4,
                    ProductName = "Water",
                    Price = 1,
                    Notes = "",

                },
                new Product
                {
                    Id = 5,
                    ProductName = "Cola",
                    Price = 5,
                    Notes = "",

                },
                new Product
                {
                    Id = 6,
                    ProductName = "Pepsi",
                    Price = 10,
                    Notes = "",

                },
                new Product
                {
                    Id = 7,
                    ProductName = "Inc Pen",
                    Price = 5,
                    Notes = "",

                },
                new Product
                {
                    Id = 8,
                    ProductName = "Stack of Paper",
                    Price = 10,
                    Notes = "",

                },
                new Product
                {
                    Id = 9,
                    ProductName = "Scissors",
                    Price = 10,
                    Notes = "",

                }

            );

        }
    }

}
