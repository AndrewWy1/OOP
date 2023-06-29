using HotelSystem_EF.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HotelSystem_EF.Dal.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.FirstName)
                .HasMaxLength(25);

            builder.Property(u => u.LastName)
                .HasMaxLength(25);

            builder.Property(u => u.Email)
                .HasMaxLength(50);

            builder.Property(u => u.Username)
                .HasMaxLength(50);

            builder.Property(u =>u.Password)
                .HasMaxLength(32);


            //connections
            builder.HasMany(u => u.Reviews)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId);

            builder.HasMany(u => u.Bookings)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(u => u.Room)
                .WithOne(r => r.User)
                .HasForeignKey<Room>(r => r.UserId);


            builder.HasData(
            new User
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                Username = "johndoe",
                Password = "password1",
                RoomId = 1
            },
            new User
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                Username = "janesmith",
                Password = "password2",
                RoomId = 2
            },
            new User
            {
                Id = 3,
                FirstName = "Mike",
                LastName = "Johnson",
                Email = "mike.johnson@example.com",
                Username = "mikejohnson",
                Password = "password3",
                RoomId = 3
            },
            new User
            {
                Id = 4,
                FirstName = "Sarah",
                LastName = "Williams",
                Email = "sarah.williams@example.com",
                Username = "sarahwilliams",
                Password = "password4",
                RoomId = 4
            });
        }
    }
}
