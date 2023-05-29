using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillsPaymentSystem.Data.Models
{
	public class PaymentMethod
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required] 
		public Types Type { get; set; }


		//connections
		public int UserId { get; set; }
		public User User { get; set; }

		public int? CreditCardId { get; set; }
		public CreditCard? CreditCard { get; set; } = default!;

		public int? BankAccountId { get; set; }
		public BankAccount? BankAccount { get; set; } = default!;


		//enum
		public enum Types { 
			BankAccount,
			CreditCard
		}

	}
}
