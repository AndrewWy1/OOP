using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Data.Models
{
	public class Medicament
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int MedicamentId { get; set; }

		[Required]
		[MaxLength(50)]
		[Column(TypeName = "nvarchar")]
		public string? Name { get; set; }

		public ICollection<PatientMedicament> PatientMedicaments { get; set; } = new List<PatientMedicament>();
	}
}
