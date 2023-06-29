using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelSystem_EF.Dal.Models
{
    public class BookingService
    {
        //connection
        [Key]
        public int BookingId { get; set; }
        public Booking Booking { get; set; } = null!;

        [Key]
        public int ServiveId { get; set; }
        public Service Service { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }
    }
}
