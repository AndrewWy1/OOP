﻿namespace HotelSystem_EF.Dal.Models
{
    public class RoomAmenity
    {
        public int RoomId { get; set; }
        public Room Room { get; set; } = null!;

        public int AmenityId { get; set; }
        public Amenity Amenity { get; set; } = null!;
    }
}
