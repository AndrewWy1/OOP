using BillsPaymentSystem.Data.Configurations;
using BillsPaymentSystem.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BillsPaymentSystem.Data
{
	public class BillsPaymentSystemContext : DbContext
	{
		public BillsPaymentSystemContext(DbContextOptions<BillsPaymentSystemContext> options) : base(options) { }

		DbSet<User> Users { get; set; }
		DbSet<CreditCard> CreditCards { get; set;}
		DbSet<BankAccount> BankAccounts { get; set; }
		DbSet<PaymentMethod> PaymentMethods { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UserConfiguration());
			modelBuilder.ApplyConfiguration(new BankAccountConfiguration());
			modelBuilder.ApplyConfiguration(new CreditCartConfiguration());
			modelBuilder.ApplyConfiguration(new PaymentMethodConfiguration());
		}
	}
}
