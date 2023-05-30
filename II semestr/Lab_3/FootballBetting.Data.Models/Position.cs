using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBetting.Data.Models
{
    public class Position
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PositionId { get; set; }
        [Required]
        public string Name { get; set; } = default!;


        //connection
        public ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
