using HotelSystem_EF.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HotelSystem_EF.Dal.Data.Configurations
{
    public class RoomAmenityConfiguration : IEntityTypeConfiguration<RoomAmenity>
    {
        public void Configure(EntityTypeBuilder<RoomAmenity> builder)
        {
            builder.HasKey(ra => ra.Id);


            //connections
            builder.HasOne(ra => ra.Room)
                .WithMany(r => r.RoomAmenities)
                .HasForeignKey(ra => ra.RoomId);

            builder.HasOne(ra => ra.Amenity)
                .WithMany(a => a.RoomAmenities)
                .HasForeignKey(r => r.AmenityId);


            builder.HasData(
            new RoomAmenity
            {
                Id = 1,
                RoomId = 1,
                AmenityId = 1
            },
            new RoomAmenity
            {
                Id = 2,
                RoomId = 2,
                AmenityId = 2
            },
            new RoomAmenity
            {
                Id = 3,
                RoomId = 3,
                AmenityId = 3
            },
            new RoomAmenity
            {
                Id = 4,
                RoomId = 4,
                AmenityId = 4
            }
        );
        }
    }
}
