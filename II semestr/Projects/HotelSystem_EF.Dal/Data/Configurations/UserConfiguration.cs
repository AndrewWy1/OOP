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
                Id = "1",
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                UserName = "User1",
                PasswordHash = "1111",
                RoomId = 1
            },
            new User
            {
                Id = "2",
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                UserName = "User2",
                PasswordHash = "2222",
                RoomId = 2
            },
            new User
            {
                Id = "3",
                FirstName = "Mike",
                LastName = "Johnson",
                Email = "mike.johnson@example.com",
                UserName = "User3",
                PasswordHash = "3333",
                RoomId = 3
            },
            new User
            {
                Id = "4",
                FirstName = "Sarah",
                LastName = "Williams",
                Email = "sarah.williams@example.com",
                UserName = "User4",
                PasswordHash = "4444",
                RoomId = 4
            });
        }
    }
}
