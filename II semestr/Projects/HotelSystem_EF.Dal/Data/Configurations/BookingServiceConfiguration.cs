using HotelSystem_EF.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HotelSystem_EF.Dal.Data.Configurations
{
    public class BookingServiceConfiguration : IEntityTypeConfiguration<BookingService>
    {
        public void Configure(EntityTypeBuilder<BookingService> builder)
        {
            builder.HasKey(bs => new { bs.BookingId, bs.ServiveId });

            //connections
            builder.HasOne(bs => bs.Service)
                .WithMany(s => s.BookingServices)
                .HasForeignKey(bs => bs.ServiveId);

            builder.HasOne(bs => bs.Booking)
                .WithMany(b => b.BookingServices)
                .HasForeignKey(bs => bs.BookingId);

            builder.HasData(
            new BookingService
            {
                Quantity = 2,
                ServiveId = 1,
                BookingId = 1
            },
            new BookingService
            {
                Quantity = 1,
                ServiveId = 2,
                BookingId = 2
            },
            new BookingService
            {
                Quantity = 3,
                ServiveId = 3,
                BookingId = 3
            },
            new BookingService
            {
                Quantity = 2,
                ServiveId = 4,
                BookingId = 4
            }
        );
        }
    }
}
