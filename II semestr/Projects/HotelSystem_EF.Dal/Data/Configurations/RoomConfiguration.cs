using HotelSystem_EF.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HotelSystem_EF.Dal.Data.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.RoomType)
            .HasMaxLength(50);


            builder.HasData(
            new Room
            {
                Id = 1,
                RoomNumber = 101,
                RoomType = "Standard",
                Price = 100.00,
                UserId = 1
            },
            new Room
            {
                Id = 2,
                RoomNumber = 102,
                RoomType = "Deluxe",
                Price = 150.00,
                UserId = 2
            },
            new Room
            {
                Id = 3,
                RoomNumber = 201,
                RoomType = "Standard",
                Price = 100.00,
                UserId = 3
            },
            new Room
            {
                Id = 4,
                RoomNumber = 202,
                RoomType = "Deluxe",
                Price = 150.00,
                UserId = 4
            });
        }
    }
}
