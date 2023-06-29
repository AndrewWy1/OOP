namespace HotelSystem_EF.Bll.DTO.Payment
{
    public class PaymentDTO
    {
        public int Id { get; set; }
        public double Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public int BookingId { get; set; }
    }
}
