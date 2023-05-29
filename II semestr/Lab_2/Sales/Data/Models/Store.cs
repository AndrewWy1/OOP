using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sales.Data.Models
{
	public class Store
	{
		[Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int StroeId { get; set; }

		[Required][MaxLength(80)][Column(TypeName = "nvarchar")]
		public string? Name { get; set; }

		//connections
		public ICollection<Sale> Sales { get; set; } = new List<Sale>();
	}
}
