using BillsPaymentSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillsPaymentSystem.Data.Configurations
{
	public class CreditCartConfiguration : IEntityTypeConfiguration<CreditCard>
	{
		public void Configure(EntityTypeBuilder<CreditCard> builder)
		{
			builder.HasKey(cc => cc.CreditCardId);

			builder.Ignore(cc => cc.LimitLeft);

			builder.HasOne(cc => cc.PaymentMethod)
					.WithOne(pm => pm.CreditCard)
					.HasForeignKey<PaymentMethod>(pm => pm.CreditCardId);


			//seeding
			builder.HasData( new CreditCard
			{
				CreditCardId = 1,
				Limit = 5000.0,
				ModeyOwed = 2500.0,
				ExparationDate = DateTime.Now.AddYears(3)
			}, new CreditCard
			{
				CreditCardId = 2,
				Limit = 10000.0,
				ModeyOwed = 500.0,
				ExparationDate = DateTime.Now.AddYears(2)
			}, new CreditCard
			{
				CreditCardId = 3,
				Limit = 2000.0,
				ModeyOwed = 0.0,
				ExparationDate = DateTime.Now.AddYears(4)
			});
		}
	}
}
