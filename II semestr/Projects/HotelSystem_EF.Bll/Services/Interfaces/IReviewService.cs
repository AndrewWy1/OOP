using HotelSystem_EF.Bll.DTO.Review;

namespace HotelSystem_EF.Bll.Services.Interfaces
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewDTO>> GetAllAsync();

        Task<ReviewDTO> GetByIdAsync(int Id);

        Task<ReviewDTO> CreateAsync(PostReviewDTO reviewDTO);

        Task<ReviewDTO> UpdateAsync(ReviewDTO reviewDTO);

        Task<ReviewDTO> DeleteAsync(int Id);
    }
}
