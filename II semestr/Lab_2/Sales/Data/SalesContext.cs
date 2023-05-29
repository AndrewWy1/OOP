using Microsoft.EntityFrameworkCore;
using Sales.Data.Models;

namespace Sales.Data
{
	public class SalesContext : DbContext
	{
		public SalesContext(DbContextOptions options) : base(options) { }

		public DbSet<Customer> Customers { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Store> Stores { get; set; }
		public DbSet<Sale> Sales { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Sale>()
						.HasOne(s => s.Customer)
						.WithMany(c => c.Sales) 
						.HasForeignKey(s => s.CustomerId);

			modelBuilder.Entity<Sale>()
						.HasOne(s => s.Product)
						.WithMany(p => p.Sales)
						.HasForeignKey(s => s.ProductId);

			modelBuilder.Entity<Sale>()
						.HasOne(s => s.Store)
						.WithMany(s => s.Sales)
						.HasForeignKey(s => s.StoreId);

			modelBuilder.Entity<Product>()
						.Property(p => p.Description)
						.HasDefaultValue("No Description");

			modelBuilder.Entity<Sale>()
						.Property(s => s.Date)
						.HasDefaultValueSql("getdate()");
		}
	}
}
