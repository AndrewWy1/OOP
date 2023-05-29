using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSystem.Data.Model
{
	public class HomeworkSubmission
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int HomeworkId { get; set; }
		public string Content { get; set; } = null!;
		public ContentTypes ContentType { get; set; }
		public DateTime SubmissionTime { get; set; }


		//connections
		public int StudentId { get; set; }
		public Student Student { get; set; }

		public int CourseId { get; set; }
		public Course Course { get; set; }


		//enum
		public enum ContentTypes
		{
			Application,
			Pdf,
			Zip,
			Rar
		}
	}
}
