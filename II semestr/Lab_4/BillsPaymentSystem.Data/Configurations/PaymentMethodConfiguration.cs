using BillsPaymentSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BillsPaymentSystem.Data.Configurations
{
	public class PaymentMethodConfiguration : IEntityTypeConfiguration<PaymentMethod>
	{
		public void Configure(EntityTypeBuilder<PaymentMethod> builder) 
		{
			builder.HasKey(pm => pm.Id);

			builder
			   .ToTable(pm => pm.HasCheckConstraint(
					   "CK_BankAccountId_AND_CreditCardId_Empty",
					   "(([BankAccountId] IS NULL) AND ([CreditCardId] IS NOT NULL)) OR (([BankAccountId] IS NOT NULL) AND ([CreditCardId] IS NULL))"
				   ));


			//seeding
			builder.HasData( new PaymentMethod()
			{
				Id = 1,
				Type = PaymentMethod.Types.BankAccount,
				UserId = 1,
				CreditCardId = 3,
				BankAccountId = null
			}, new PaymentMethod()
			{
				Id = 2,
				Type = PaymentMethod.Types.CreditCard,
				UserId = 2,
				CreditCardId = null,
				BankAccountId = 2
			}, new PaymentMethod()
			{
				Id = 3,
				Type = PaymentMethod.Types.CreditCard,
				UserId = 3,
				CreditCardId = 2,
				BankAccountId = null
			});
		}

	}
}
