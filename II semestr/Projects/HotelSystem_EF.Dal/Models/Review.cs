using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelSystem_EF.Dal.Models
{
    public class Review
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReviewId { get; set; }

        [Required]
        public double Rating { get; set; }

        public string? Comment { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? ReviewDate { get; set; }


        //connections
        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
