using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.Data.Model;

namespace StudentSystem.Data.Configurations
{
	public class CourseConfiguration: IEntityTypeConfiguration<Course>
	{
		public void Configure(EntityTypeBuilder<Course> builder)
		{
			builder.HasKey(c => c.CourseId);

			builder.Property(c => c.Name)
				.IsRequired()
				.HasMaxLength(80)
				.IsUnicode(true);

			builder.Property(c => c.Description).IsUnicode(true);
			builder.Property(c => c.StartDate).IsRequired();
			builder.Property(c => c.EndDate).IsRequired();


			//seeding
			builder.HasData(new Course
			{
				CourseId = 1,
				Name = "Course 1",
				Description = "Description 1",
				StartDate = DateTime.Now,
				EndDate = DateTime.Now.AddDays(7),
				Price = 9.99
			}, new Course
			{
				CourseId = 2,
				Name = "Course 2",
				Description = "Description 2",
				StartDate = DateTime.Now,
				EndDate = DateTime.Now.AddDays(14),
				Price = 19.99
			}, new Course
			{
				CourseId = 3,
				Name = "Course 3",
				Description = null,
				StartDate = DateTime.Now,
				EndDate = DateTime.Now.AddDays(21),
				Price = 29.99
			});

		}
	}
}
