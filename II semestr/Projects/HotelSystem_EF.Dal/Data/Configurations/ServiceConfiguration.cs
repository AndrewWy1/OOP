using HotelSystem_EF.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem_EF.Dal.Data.Configurations
{
    public class ServiceConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.HasKey(s => s.ServiceId);

            builder.Property(s => s.ServiceName)
                .HasMaxLength(75);

            builder.Property(s => s.Description)
                .HasMaxLength(250);
        }
    }
}
