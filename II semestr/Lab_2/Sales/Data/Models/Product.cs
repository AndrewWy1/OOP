using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sales.Data.Models
{
	public class Product
	{
		[Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int ProductId { get; set; }

		[Required][MaxLength(50)][Column(TypeName = "nvarchar")]
		public string? Name { get; set; }

		[Required]
		public int Quantity { get; set; }

		[Required]
		public double Price { get; set;}

		public string Description { get; set; } = default!;


		//connections
		public ICollection<Sale> Sales { get; set; } = new List<Sale>();
	}
}
