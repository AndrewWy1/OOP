using FootballBetting.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootballBetting.Data.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder) 
        {
            builder.HasOne(t => t.PrimaryKitColor)
                   .WithMany(c => c.PrimaryColors)
                   .HasForeignKey(c => c.PrimaryKitColorId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(t => t.SecondaryKitColor)
                   .WithMany(c => c.SecondaryColors)
                   .HasForeignKey(c => c.SecondaryKitColorId)
                   .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne(t => t.Town)
                   .WithMany(t => t.Teams)
                   .HasForeignKey( t => t.TownId);
        }
    }
}
