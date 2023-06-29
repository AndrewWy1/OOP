namespace HotelSystem_EF.Bll.DTO.Payment
{
    public class PostPaymentDTO
    {
        public double Amount { get; set; }

        public DateTime PaymentDate { get; set; }

        public int BookingId { get; set; }
    }
}
