using BillsPaymentSystem.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Runtime.Intrinsics.X86;

namespace BillsPaymentSystem.Data.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.HasKey(u => u.UserId);

			builder.Property(u => u.FirstName)
				   .HasMaxLength(50)
				   .IsUnicode(true);

			builder.Property(u => u.LastName)
				   .HasMaxLength(50)
				   .IsUnicode(true);

			builder.Property(u => u.Email)
				   .HasMaxLength(80)
				   .IsUnicode(false);

			builder.Property(u => u.Password)
				   .HasMaxLength(25)
				   .IsUnicode(false);


			//seeding
			builder.HasData( new User
			{
				UserId = 1,
				FirstName = "John",
				LastName = "Doe",
				Email = "johndoe@example.com",
				Password = "password123"
			}, new User
			{
				UserId = 2,
				FirstName = "Jane",
				LastName = "Smith",
				Email = "janesmith@example.com",
				Password = "qwerty"
			}, new User
			{
				UserId = 3,
				FirstName = "Alice",
				LastName = "Johnson",
				Email = "alicejohnson@example.com",
				Password = "pass1234"
			});
		}
	}
}
