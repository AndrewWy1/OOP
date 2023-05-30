using FootballBetting.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootballBetting.Data.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasOne(g => g.HomeTeam)
                   .WithMany(t => t.HomeGames)
                   .HasForeignKey(g => g.HomeTeamId)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(g => g.AwayTeam)
                   .WithMany(t => t.AwayGames)
                   .HasForeignKey(g => g.AwayTeamId)
                   .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
