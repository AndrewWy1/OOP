namespace HotelSystem_EF.Bll.DTO.Review
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        public double Rating { get; set; }

        public string? Comment { get; set; }

        public DateTime? ReviewDate { get; set; }

        public int UserId { get; set; }
    }
}
