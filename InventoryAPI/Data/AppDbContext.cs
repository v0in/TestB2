using Microsoft.EntityFrameworkCore;
using InventoryAPI.Models;

namespace InventoryAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<StockRecord> StockRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ensure ProductId + WarehouseId is unique in StockRecord
            modelBuilder.Entity<StockRecord>()
                .HasIndex(sr => new { sr.ProductId, sr.WarehouseId })
                .IsUnique();
            // Cascading delete for StockRecords when a Warehouse is deleted
            modelBuilder.Entity<StockRecord>()
                .HasOne(sr => sr.Warehouse)
                .WithMany()
                .HasForeignKey(sr => sr.WarehouseId)
                .OnDelete(DeleteBehavior.Cascade); 
            // Cascading delete for StockRecords when a Product is deleted
            modelBuilder.Entity<StockRecord>()
                .HasOne(sr => sr.Product)
                .WithMany()
                .HasForeignKey(sr => sr.ProductId)
                .OnDelete(DeleteBehavior.Cascade); 
            // Define relationships
            modelBuilder.Entity<StockRecord>()
                .HasOne(sr => sr.Product)
                .WithMany()
                .HasForeignKey(sr => sr.ProductId);

            modelBuilder.Entity<StockRecord>()
                .HasOne(sr => sr.Warehouse)
                .WithMany()
                .HasForeignKey(sr => sr.WarehouseId);

            // Add dummy data
            modelBuilder.Entity<Product>().HasData(GenerateProducts());
            modelBuilder.Entity<Warehouse>().HasData(GenerateWarehouses());
            modelBuilder.Entity<StockRecord>().HasData(GenerateStockRecords());
        }

        // Helper methods to generate dummy data
        private static List<Product> GenerateProducts()
        {
            return Enumerable.Range(1, 100)
                .Select(i => new Product { Id = i, Name = $"Product {i}" })
                .ToList(); // Static names
        }

        private static List<Warehouse> GenerateWarehouses()
        {
            return Enumerable.Range(1, 10)
                .Select(i => new Warehouse { Id = i, Name = $"Warehouse {i}" })
                .ToList();
        }

        private static List<StockRecord> GenerateStockRecords()
        {
            var records = new List<StockRecord>();
            int recordId = 1;

            // Assign each product to 2 warehouses in a fixed pattern
            for (int productId = 1; productId <= 100; productId++)
            {
                // Warehouse assignment logic (deterministic)
                int warehouse1Id = (productId % 10) + 1; // Cycles through warehouses 1-10
                int warehouse2Id = ((productId + 5) % 10) + 1; // Offset by 5 to avoid duplicates

                // Quantity based on product ID (deterministic)
                int quantity1 = (productId * 10) % 100;
                int quantity2 = (productId * 20) % 100;

                records.Add(new StockRecord
                {
                    Id = recordId++,
                    ProductId = productId,
                    WarehouseId = warehouse1Id,
                    Quantity = quantity1 > 0 ? quantity1 : 10 // Ensure non-zero
                });

                records.Add(new StockRecord
                {
                    Id = recordId++,
                    ProductId = productId,
                    WarehouseId = warehouse2Id,
                    Quantity = quantity2 > 0 ? quantity2 : 10
                });
            }
            return records;
        }

    }
}
