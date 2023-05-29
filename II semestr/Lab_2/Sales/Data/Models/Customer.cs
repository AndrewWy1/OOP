using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sales.Data.Models
{
	public class Customer
	{
		[Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CustomerId { get; set; }

		[Required][MaxLength(100)][Column(TypeName = "nvarchar")]
		public string? Name { get; set; }

		[Required][MaxLength(80)][Column(TypeName ="varchar")]
		public string? Email { get; set; }

		[Required][MaxLength(16)]
		public string? CreditCardNumber { get; set; }


		//connections
		public ICollection<Sale> Sales { get; set; } = new List<Sale>();
	}
}
