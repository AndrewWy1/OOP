namespace StudentSystem.Data.Model
{
	public class Student
	{
		public int StudentId { get; set; }
		public string Name { get; set; } = null!;
		public string? PhoneNumber { get; set; }
		public bool RegisteredOn { get; set; }
		public DateTime Birthday { get; set; }

	}
}
