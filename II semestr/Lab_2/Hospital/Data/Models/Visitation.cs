using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Data.Models
{
	public class Visitation
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int VisitationId { get; set; }

		[Required]
		public DateTime Date { get; set; }

		[MaxLength(250)]
		[Column(TypeName = "nvarchar")]
		public string? Comments { get; set; }


		public int DoctorId { get; set; }
		public Doctor Doctor { get; set; }

		public int PatientId { get; set; }
		public Patient Patient { get; set; }
	}
}
