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
		public double MoneyOwed { get; private set; }

		[Required]
		public double LimitLeft { get => Limit - MoneyOwed; }

		[Required]
		public DateTime ExparationDate { get; set; }


		//connection
		public PaymentMethod PaymentMethod { get; set; } = null!;


        public bool Withdraw(double amount)
        {
            if (LimitLeft <= amount)
            {
                MoneyOwed += amount;
                return true;
            }
            else
                return false;
        }
        public bool Diposit(double amount)
        {
            if (LimitLeft < amount)
                return false;
            else
            {
                MoneyOwed -= amount;
                return true;
            }
        }
    }
}
