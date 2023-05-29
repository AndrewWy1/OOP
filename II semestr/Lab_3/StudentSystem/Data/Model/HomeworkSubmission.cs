namespace StudentSystem.Data.Model
{
	public class HomeworkSubmission
	{
		public int HomeworkId { get; set; }
		public string Content { get; set; } = null!;
		public ContentTypes ContentType { get; set; }
		public DateTime SubmissionTime { get; set; }


		public enum ContentTypes
		{
			Application,
			Pdf,
			Zip,
			Rar
		}
	}
}
