using HotelSystem_EF.Dal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace HotelSystem_EF.Dal.Data.Configurations
{
    public class AmenityConfiguration : IEntityTypeConfiguration<Amenity>
    {
        public void Configure(EntityTypeBuilder<Amenity> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Name)
                .HasMaxLength(75);

            builder.Property(a => a.Description)
            .HasMaxLength(250);


            builder.HasData(
            new Amenity { Id = 1, Name = "Amenity 1", Description = "Description 1" },
            new Amenity { Id = 2, Name = "Amenity 2", Description = "Description 2" },
            new Amenity { Id = 3, Name = "Amenity 3", Description = "Description 3" },
            new Amenity { Id = 4, Name = "Amenity 4", Description = "Description 4" }
            );
        }
    }
}
