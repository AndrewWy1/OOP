using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBetting.Data.Models
{
    public class Color
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ColorId { get; set; }

        [Required]
        public string Name { get; set; } = default!;


        //connections
        public ICollection<Team> PrimaryColors { get; set; } = new List<Team>();
        public ICollection<Team> SecondaryColors { get; set; } = new List<Team>();
    }
}
