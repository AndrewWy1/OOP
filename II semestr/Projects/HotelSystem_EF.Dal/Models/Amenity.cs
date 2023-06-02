using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelSystem_EF.Dal.Models
{
    public class Amenity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AmenityId { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }


        //connction
        public ICollection<RoomAmenity> RoomAmenities { get; set; } = new List<RoomAmenity>();
    }
}
