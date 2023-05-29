using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Data.Models 
{
	public class Diagnose
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int DiagnoseId { get; set; }

		[Required]
		[StringLength(50)]
		[Column(TypeName = "nvarchar")]
		public string? Name { get; set; }

		[MaxLength(250)]
		[Column(TypeName = "nvarchar")]
		public string? Comments { get; set; }

		[Required]
		public ICollection<Patient> Patients { get; set; }

	}
}



