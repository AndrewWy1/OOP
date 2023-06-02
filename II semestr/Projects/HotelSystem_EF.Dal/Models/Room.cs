using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelSystem_EF.Dal.Models
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoomId { get; set; }

        [Required]
        public int RoomNumber { get; set; }

        [Required]
        public string RoomType { get; set; } = null!;

        [Required]
        public double Price { get; set; }


        //connections
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        public ICollection<RoomAmenity> RoomAmenities { get;set; } = new List<RoomAmenity>();
    }
}
