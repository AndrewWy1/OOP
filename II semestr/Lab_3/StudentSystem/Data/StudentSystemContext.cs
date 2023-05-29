using Microsoft.EntityFrameworkCore;
using StudentSystem.Data.Model;

namespace StudentSystem.Data
{
	public class StudentSystemContext : DbContext
	{
		public StudentSystemContext(DbContextOptions<StudentSystemContext> options) : base(options) 
		{ }

		public DbSet<Course> Courses { get; set; }
		public DbSet<Student> Students { get; set; }
		public DbSet<Resource> Resources { get; set; }
		public DbSet<HomeworkSubmission> HomeworkSubmissions { get; set;}
		public DbSet<StudentCourse> StudentCourses { get; set;}

	}
}
