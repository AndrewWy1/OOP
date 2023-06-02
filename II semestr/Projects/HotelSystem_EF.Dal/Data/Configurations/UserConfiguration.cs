using HotelSystem_EF.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem_EF.Dal.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.UserId);

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
        }
    }
}
