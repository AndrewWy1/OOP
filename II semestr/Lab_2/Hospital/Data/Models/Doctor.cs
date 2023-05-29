using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Data.Models
{
	public class Doctor
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int DoctorId { get; set; }

		[Required]
		[MaxLength(50)]
		public string? FirstName { get; set; }

		[Required]
		[MaxLength(50)]
		public string? LastName { get; set; }

		[Required]
		[MaxLength(100)]
		public string? Specialty { get; set; }

		public ICollection<Visitation> Visitations { get; set; } = new List<Visitation>();
	}
}
