using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Data.Model
{
	public class Course
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int CourseId { get; set; }
		public string Name { get; set; } = null!;
		public string? Description { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public double Price { get; set; }


		//connections
		public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

		public ICollection<HomeworkSubmission> HomeworkSubmissions { get; set; } = new List<HomeworkSubmission>();

		public ICollection<Resource> Resources { get; set; } = new List<Resource>();

	}
}
