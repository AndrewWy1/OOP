using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBetting.Data.Models
{
    public class Bet
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BetId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Prediction { get; set; } = null!;
        [Required]
        public DateTime DateTime { get; set; }


        //connection
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int GameId { get; set; }
        public Game Game { get; set; } = null!;
    }
}
