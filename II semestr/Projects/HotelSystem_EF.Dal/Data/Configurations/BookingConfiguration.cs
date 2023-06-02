using HotelSystem_EF.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem_EF.Dal.Data.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(b => b.BookingId);


            //connections
            builder.HasOne(b => b.Room)
                 .WithMany(r => r.Bookings)
                 .HasForeignKey(b => b.RoomId);

            builder.HasMany(b => b.Payments)
                .WithOne(p => p.Booking)
                .HasForeignKey(p => p.BookingId);
        }
    }
}
