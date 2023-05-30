using System.ComponentModel.DataAnnotations;

namespace FootballBetting.Data.Models
{
    public class PlayerStatistics
    {
        //connections
        public int GameId { get; set; }
        public Game Game { get; set; } = default!;
        public int PlayerId { get; set; }
        public Player Player { get; set; } = default!;

        [Required]
        public int ScoredGoals { get; set; }
        [Required]
        public bool Assists { get; set; }
        [Required]
        public decimal MinutesPlayed { get; set; }
    }
}
