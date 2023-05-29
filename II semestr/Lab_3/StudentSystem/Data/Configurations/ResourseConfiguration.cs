using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.Data.Model;
using static StudentSystem.Data.Model.Resource;

namespace StudentSystem.Data.Configurations
{
	public class ResourseConfiguration : IEntityTypeConfiguration<Resource>
	{
		public void Configure(EntityTypeBuilder<Resource> builder)
		{
			builder.HasKey(r => r.ResourceId);

			builder.Property(r => r.Name)
				   .IsRequired()
				   .HasMaxLength(50)
				   .IsUnicode(true);
			

			//connection
			builder.HasOne(r => r.Course)
				   .WithMany(c => c.Resources)
				   .HasForeignKey(r => r.CourseId);


			//seeding
			builder.HasData(new Resource
			{
				ResourceId = 1,
				Name = "Resource 1",
				Url = "http://example.com/resource1",
				ResourceType = ResourceTypes.Video,
				CourseId = 1
			}, new Resource
			{
				ResourceId = 2,
				Name = "Resource 2",
				Url = "http://example.com/resource2",
				ResourceType = ResourceTypes.Document,
				CourseId = 2
			}, new Resource
			{
				ResourceId = 3,
				Name = "Resource 3",
				Url = "http://example.com/resource3",
				ResourceType = ResourceTypes.Audio,
				CourseId = 2
			});
		}
	}
}
