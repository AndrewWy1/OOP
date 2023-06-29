using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelSystem_EF.Dal.Models
{
    public class Booking : ModelBase
    {

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set;}


        //connecion
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int RoomId { get; set; }
        public Room Room { get; set; } = null!;

        public ICollection<BookingService> BookingServices { get; set; } = new List<BookingService>();

        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
