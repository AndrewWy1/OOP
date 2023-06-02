using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelSystem_EF.Dal.Models
{
    public class BookingService
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingServiceId { get; set; }

        [Required]
        public int Quantity { get; set; }


        //connection
        public int ServiveId { get; set; }
        public Service Service { get; set; } = null!;

        public int BookingId { get; set; }
        public Booking Booking { get; set; } = null!;
    }
}
