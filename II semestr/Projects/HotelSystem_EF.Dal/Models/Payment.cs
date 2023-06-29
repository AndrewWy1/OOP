using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelSystem_EF.Dal.Models
{
    public class Payment : ModelBase
    {
        [Required]
        public double Amount { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }


        //connection
        public int BookingId { get; set; }
        public Booking Booking { get; set; } = null!;
    }
}
