using HotelSystem_EF.Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelSystem_EF.Dal.Data.Configurations
{
    public class AmenityConfiguration : IEntityTypeConfiguration<Amenity>
    {
        public void Configure(EntityTypeBuilder<Amenity> builder)
        {
            builder.HasKey(a => a.AmenityId);

            builder.Property(a => a.Name)
                .HasMaxLength(75);

            builder.Property(a => a.Description)
                .HasMaxLength(250);
        }
    }
}
