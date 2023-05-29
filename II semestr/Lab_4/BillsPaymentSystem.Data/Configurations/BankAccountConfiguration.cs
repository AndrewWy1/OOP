using BillsPaymentSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Runtime.Intrinsics.X86;

namespace BillsPaymentSystem.Data.Configurations
{
	public class BankAccountConfiguration : IEntityTypeConfiguration<BankAccount>
	{
		public void Configure(EntityTypeBuilder<BankAccount> builder)
		{
			builder.HasKey(ba => ba.BankAccountId);

			builder.Property(ba => ba.BankName)
				   .HasMaxLength(50)
				   .IsUnicode(true);

			builder.Property(ba => ba.SWIFTCode)
				   .HasMaxLength(20)
				   .IsUnicode(false);


			//connecion
			builder.HasOne(ba => ba.PaymentMethod)
				   .WithOne(pm => pm.BankAccount)
				   .HasForeignKey<PaymentMethod>(pm => pm.BankAccountId);


			//seeding
			builder.HasData(new BankAccount
			{
				BankAccountId = 1,
				Balance = 1000.0,
				BankName = "Bank of Example",
				SWIFTCode = "EXMPUS1234"
			}, new BankAccount
			{
				BankAccountId = 2,
				Balance = 2000.0,
				BankName = "Example Bank",
				SWIFTCode = "EXBNK5678"
			}, new BankAccount
			{

				BankAccountId = 3,
				Balance = 3000.0,
				BankName = "Banking Institution",
				SWIFTCode = "BNKINST9102"
			});
		}
	}
}
