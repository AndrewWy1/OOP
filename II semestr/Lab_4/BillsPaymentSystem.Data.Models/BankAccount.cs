using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BillsPaymentSystem.Data.Models
{
	public class BankAccount
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int BankAccountId { get; set; }

		[Required]
		public double Balance { get; set; }

		[Required]
		public string BankName { get; set; } = null!;

		[Required]
		public string SWIFTCode { get; set; } = null!;


		//connection
		public PaymentMethod PaymentMethod { get; set; } = default!;
	}
}
