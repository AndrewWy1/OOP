namespace HotelSystem_EF.Bll.DTO.BookingService
{
    public class BookingServiceDTO
    {
        //public int BookingId { get; set; }
        //public int ServiveId { get; set; }

        public string ServiseName { get; set; } = null!;

        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"Service: {ServiseName};";
        }
    }
}
