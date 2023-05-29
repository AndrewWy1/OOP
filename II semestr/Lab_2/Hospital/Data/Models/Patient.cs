using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Data.Models
{
	public class Patient
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int PatientId { get; set; }

		[Required]
		[MaxLength(50)]
		[Column(TypeName = "nvarchar")]
		public string? FirstName { get; set; }

		[Required]
		[MaxLength(50)]
		[Column(TypeName = "nvarchar")]
		public string? LastName { get; set; }

		[Required]
		[MaxLength(250)]
		[Column(TypeName = "nvarchar")]
		public string? Address { get; set; }

		[Required]
		[MaxLength(80)]
		[Column(TypeName = "varchar")]
		public string? Email { get; set; }

		[Required]
		public bool HasInsurance { get; set; }

		public int DiagnoseId { get; set; }
		public Diagnose Diagnose { get; set; }

		public ICollection<Visitation> Visitations { get; set; } = new List<Visitation>();

		public ICollection<PatientMedicament> PatientMedicaments { get; set; } = new List<PatientMedicament>();
	}
}
