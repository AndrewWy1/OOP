using Microsoft.EntityFrameworkCore;
using FootballBetting.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootballBetting.Data.Configurations
{
    public class PlayerStatisticsConfiguration : IEntityTypeConfiguration<PlayerStatistics>
    {
        public void Configure(EntityTypeBuilder<PlayerStatistics> builder) 
        {
            builder.HasKey(ps => new { ps.PlayerId, ps.GameId });

            builder.HasOne(ps => ps.Game)
                   .WithMany(g => g.PlayerStatistics)
                   .HasForeignKey(ps => ps.GameId);

            builder.HasOne(ps => ps.Player)
                  .WithMany(p => p.PlayerStatistics)
                  .HasForeignKey(ps => ps.PlayerId);
        }
    }
}
