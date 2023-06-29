namespace HotelSystem_EF.Bll.DTO.Service
{
    public class PostServiceDTO
    {
        public string ServiceName { get; set; } = null!;
        public string? Description { get; set; }
        public double Price { get; set; }
    }
}
