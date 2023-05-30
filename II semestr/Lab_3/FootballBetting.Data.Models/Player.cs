using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBetting.Data.Models
{
    public class Player
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlayerId { get; set; }
        [Required]
        public string Name { get; set; } = default!;
        [Required]
        public int SquadNumber { get; set; }
        [Required]
        public bool IsInjured { get; set; }

        //connections
        public ICollection<PlayerStatistics> PlayerStatistics { get; set; } = new List<PlayerStatistics>();

        public int PositionId { get; set; }
        public Position Position { get; set; } = null!;

        public int TeamId { get; set; }
        public Team Team { get; set; } = null!;
    }
}
