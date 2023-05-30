using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBetting.Data.Models
{
    public class Game
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GameId { get; set; }
        [Required]
        public int HomeTeamGoals { get; set; }
        [Required]
        public int AwayTeamGoals { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public decimal HomeTeamBetRate { get; set; }
        [Required]
        public decimal AwayTeamBetRate { get; set; }
        [Required]
        public decimal DrawBetRate { get; set; }
        [Required]
        public bool Result { get; set; }


        //connection
        public ICollection<Bet> Bets { get; set; } = new List<Bet>();

        public ICollection<PlayerStatistics> PlayerStatistics { get; set; } = new List<PlayerStatistics>();

        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; } = null!;

        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; } = null!;
    }
}
