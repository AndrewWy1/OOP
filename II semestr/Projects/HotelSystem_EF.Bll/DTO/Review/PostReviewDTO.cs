namespace HotelSystem_EF.Bll.DTO.Review
{
    public class PostReviewDTO
    {
        public double Rating { get; set; }

        public string? Comment { get; set; }

        public DateTime? ReviewDate { get; set; }

        public int UserId { get; set; }
    }
}
