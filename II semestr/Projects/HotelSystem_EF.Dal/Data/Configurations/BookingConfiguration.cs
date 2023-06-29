using HotelSystem_EF.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HotelSystem_EF.Dal.Data.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(b => b.Id);


            //connections
            builder.HasOne(b => b.Room)
                 .WithMany(r => r.Bookings)
                 .HasForeignKey(b => b.RoomId);

            builder.HasMany(b => b.Payments)
                .WithOne(p => p.Booking)
                .HasForeignKey(p => p.BookingId);

            builder.HasData(
            new Booking { Id = 1, CheckInDate = new DateTime(2023, 5, 1), CheckOutDate = new DateTime(2023, 5, 7), UserId = 1, RoomId = 1 },
            new Booking { Id = 2, CheckInDate = new DateTime(2023, 6, 10), CheckOutDate = new DateTime(2023, 6, 15), UserId = 2, RoomId = 2 },
            new Booking { Id = 3, CheckInDate = new DateTime(2023, 7, 20), CheckOutDate = new DateTime(2023, 7, 25), UserId = 3, RoomId = 3},
            new Booking { Id = 4, CheckInDate = new DateTime(2023, 8, 5), CheckOutDate = new DateTime(2023, 8, 12), UserId = 4, RoomId = 4}
            );
        }
    }
}
