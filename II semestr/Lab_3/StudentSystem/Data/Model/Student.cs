using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Data.Model
{
	public class Student
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int StudentId { get; set; }
		public string Name { get; set; } = null!;
		public string? PhoneNumber { get; set; }
		public bool RegisteredOn { get; set; }
		public DateTime Birthday { get; set; }


		//connections
		public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

		public ICollection<HomeworkSubmission> HomeworkSubmissions { get; set;} = new List<HomeworkSubmission>();

	}
}
