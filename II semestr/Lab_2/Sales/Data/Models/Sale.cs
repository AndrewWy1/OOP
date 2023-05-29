using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sales.Data.Models
{
	public class Sale
	{
		[Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int SaleId { get; set; }

		[Required]
		public DateTime Date { get; set; }


		//connections
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }

		public int ProductId { get; set; }
		public Product Product { get; set; }

		public int StoreId { get; set; }
		public Store Store { get; set;}
	}
}
