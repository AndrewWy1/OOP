namespace HotelSystem_EF.Bll.DTO.Booking
{
    public class BookingDTO
    {
        public int Id { get; set; }
        public DateTime CheckInDate { get; set; }

        public DateTime CheckOutDate { get; set; }

        public int UserId { get; set; }

        public int RoomId { get; set; }
    }
}
