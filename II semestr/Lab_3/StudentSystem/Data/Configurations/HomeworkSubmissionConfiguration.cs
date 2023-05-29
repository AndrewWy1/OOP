using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.Data.Model;
using static StudentSystem.Data.Model.HomeworkSubmission;

namespace StudentSystem.Data.Configurations
{
	public class HomeworkSubmissionConfiguration : IEntityTypeConfiguration<HomeworkSubmission>
	{
		public void Configure(EntityTypeBuilder<HomeworkSubmission> builder)
		{
			builder.HasKey(hs => hs.HomeworkId);

			builder.Property(hs => hs.Content)
				   .IsRequired()
				   .IsUnicode(false);

			builder.Property(hs => hs.ContentType).IsRequired();
			builder.Property(hs => hs.SubmissionTime).IsRequired();


			//connection
			builder.HasOne(hs => hs.Student)
				   .WithMany(s => s.HomeworkSubmissions)
				   .HasForeignKey(hs => hs.StudentId);

			builder.HasOne(hs => hs.Course)
				   .WithMany(c => c.HomeworkSubmissions)
				   .HasForeignKey(hs => hs.CourseId);


			//seeding
			builder.HasData(new HomeworkSubmission
			{
				HomeworkId = 1,
				Content = "Homework content 1",
				ContentType = ContentTypes.Application,
				SubmissionTime = DateTime.Now,
				StudentId = 1,
				CourseId = 1
			}, new HomeworkSubmission
			{
				HomeworkId = 2,
				Content = "Homework content 2",
				ContentType = ContentTypes.Pdf,
				SubmissionTime = DateTime.Now,
				StudentId = 2,
				CourseId = 1
			}, new HomeworkSubmission
			{
				HomeworkId = 3,
				Content = "Homework content 3",
				ContentType = ContentTypes.Zip,
				SubmissionTime = DateTime.Now,
				StudentId = 3,
				CourseId = 2
			});
		}
	}
}
