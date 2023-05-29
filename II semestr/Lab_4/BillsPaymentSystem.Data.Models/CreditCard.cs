using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillsPaymentSystem.Data.Models
{
	public class CreditCard
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CreditCardId { get; set; }

		[Required]
		public double Limit { get; set; }

		[Required]
		public double ModeyOwed { get; set; }

		[Required]
		public double LimitLeft { get => Limit - ModeyOwed; }

		[Required]
		public DateTime ExparationDate { get; set; }


		//connection
		public PaymentMethod PaymentMethod { get; set; } = default!;
	}
}
