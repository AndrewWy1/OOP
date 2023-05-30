using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBetting.Data.Models
{
    public class Team
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TeamId { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string LogoUrl { get; set; } = null!;
        [Required]
        public string Initials { get; set; } = null!;
        [Required]
        public decimal Budget { get; set; }


        //connections
        public int PrimaryKitColorId { get; set; }
        public Color PrimaryKitColor { get; set; } = null!;

        public int SecondaryKitColorId { get; set; }
        public Color SecondaryKitColor { get; set; } = null!;

        public int TownId { get; set; }
        public Town Town { get; set; } = null!;

        public ICollection<Player> Players { get; set; } = new HashSet<Player>();
        public ICollection<Game> HomeGames { get; set; } = new List<Game>();
        public ICollection<Game> AwayGames { get; set; } = new List<Game>();
    }

}
