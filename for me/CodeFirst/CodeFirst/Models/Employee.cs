using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
	public class Employee
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long EmployeeId { get; set; }
		[Required]
		[MaxLength(25)]
		public string? FirstName { get; set; }
		[Required]
		[MaxLength(25)]
		public string? LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		[Required]
		[MaxLength(13)]
		public string? PhoneNumber { get; set; }
		[Required]
		[MaxLength(50)]
		public string? Email { get; set; }
	}
}