using FootballBetting.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FootballBetting.Data.Configurations
{
    public class BetConfiguration : IEntityTypeConfiguration<Bet>
    {
        public void Configure(EntityTypeBuilder<Bet> builder)
        {
            builder.HasOne(b => b.User)
                   .WithMany(u => u.Bets)
                   .HasForeignKey(b => b.UserId);

            builder.HasOne(b => b.Game)
                   .WithMany(g => g.Bets)
                   .HasForeignKey(b => b.GameId);
        }
    }
}
