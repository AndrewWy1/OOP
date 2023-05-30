using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBetting.Data.Models
{
    public class Town
    {
        [Key] [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TownId { get; set; }
        [Required]
        public string Name { get; set; } = null!;

        //connections
        public ICollection<Team> Teams { get; set; } = new List<Team>();

        public int CountryId { get; set; }
        public Country Country { get; set; } = null!;
    }
}
