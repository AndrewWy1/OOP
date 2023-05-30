using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBetting.Data.Models
{
    public class Country
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryId { get; set; }
        [Required]
        public string Name { get; set; } = default!;


        //connections
        public ICollection<Town> Towns { get; set; } = new List<Town>();
    }
}
