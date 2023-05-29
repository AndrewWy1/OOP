namespace StudentSystem.Data.Model
{
	public class Course
	{
		public int CourseId { get; set; }
		public string Name { get; set; } = null!;
		public string? Description { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public double Price { get; set; }

	}
}
