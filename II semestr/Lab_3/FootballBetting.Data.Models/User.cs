using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballBetting.Data.Models
{
    public class User
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string Password { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public decimal Balance { get; set; }


        //connection
        public ICollection<Bet> Bets { get; set; } = new List<Bet>();
    }
}
