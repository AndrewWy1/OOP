using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelSystem_EF.Dal.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;


        //connections
        public ICollection<Review> Reviews { get; set; } = null!;

        public ICollection<Booking> Bookings { get; set; } = null!;

        public int RoomId { get; set; }
        public Room Room { get; set; } = null!;
    }
}
