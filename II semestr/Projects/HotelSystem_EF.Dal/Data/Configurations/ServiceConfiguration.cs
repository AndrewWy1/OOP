using HotelSystem_EF.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HotelSystem_EF.Dal.Data.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.ServiceName)
                .HasMaxLength(75);

            builder.Property(s => s.Description)
            .HasMaxLength(250);


            builder.HasData(
            new Service
            {
                Id = 1,
                ServiceName = "Service 1",
                Description = "Description 1",
                Price = 10.99
            },
            new Service
            {
                Id = 2,
                ServiceName = "Service 2",
                Description = "Description 2",
                Price = 15.99
            },
            new Service
            {
                Id = 3,
                ServiceName = "Service 3",
                Description = "Description 3",
                Price = 20.99
            },
            new Service
            {
                Id = 4,
                ServiceName = "Service 4",
                Description = "Description 4",
                Price = 25.99
            }
        );

        }
    }
}
