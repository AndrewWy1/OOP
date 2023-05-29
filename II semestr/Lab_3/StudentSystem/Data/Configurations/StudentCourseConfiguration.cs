using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.Data.Model;

namespace StudentSystem.Data.Configurations
{
	public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
	{
		public void Configure(EntityTypeBuilder<StudentCourse> builder)
		{
			builder.HasKey(sc => new { sc.StudentId, sc.CourseId });

			builder.HasOne(sc => sc.Student)
				   .WithMany(s => s.StudentCourses)
				   .HasForeignKey(sc => sc.StudentId);

			builder.HasOne(sc => sc.Course)
				   .WithMany(c => c.StudentCourses)
				   .HasForeignKey(sc => sc.CourseId);


			//seeding
			builder.HasData(new StudentCourse
			{
				StudentId = 1,
				CourseId = 1
			}, new StudentCourse
			{
				StudentId = 2,
				CourseId = 1
			}, new StudentCourse
			{
				StudentId = 3,
				CourseId = 2
			});
		}
	}
}
