using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentSystem.Data.Model;

namespace StudentSystem.Data.Configurations
{
	public class StudentConfiguration : IEntityTypeConfiguration<Student>
	{
		public void Configure(EntityTypeBuilder<Student> builder)
		{
			builder.HasKey(s => s.StudentId);

			builder.Property(s => s.Name)
				   .IsRequired()
				   .IsUnicode(true)
				   .HasMaxLength(100);

			builder.Property(s => s.PhoneNumber)
				   .IsUnicode(false)
				   .HasMaxLength(10)
				   .IsFixedLength();

			builder.Property(s => s.RegisteredOn).IsRequired();


			//seeding
			builder.HasData(new Student
			{
				StudentId = 1,
				Name = "John Doe",
				PhoneNumber = "1234567890",
				RegisteredOn = true,
				Birthday = new DateTime(2000, 1, 1)
			}, new Student
			{
				StudentId = 2,
				Name = "Jane Smith",
				PhoneNumber = null,
				RegisteredOn = false,
				Birthday = new DateTime(1995, 5, 10)
			}, new Student
			{
				StudentId = 3,
				Name = "Bob Johnson",
				PhoneNumber = "9876543210",
				RegisteredOn = true,
				Birthday = new DateTime(1998, 12, 15)
			});
		}
	}
}
