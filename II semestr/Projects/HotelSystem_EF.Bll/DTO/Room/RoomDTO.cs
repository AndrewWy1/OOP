namespace HotelSystem_EF.Bll.DTO.Room
{
    public class RoomDTO
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }

        public string RoomType { get; set; } = null!;

        public double Price { get; set; }

        public int UserId { get; set; }
    }
}
