namespace HotelSystem_EF.Bll.DTO.Amenity
{
    public class AmenityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string? Description { get; set; }
    }
}
