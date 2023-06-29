using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HotelSystem_EF.Dal.Models
{
    public class Amenity : ModelBase
    {
        [Required]
        public string Name { get; set; } = null!;

        public string? Description { get; set; }


        //connctions
        public ICollection<RoomAmenity> RoomAmenities { get; set; } = null!;
    }
}
