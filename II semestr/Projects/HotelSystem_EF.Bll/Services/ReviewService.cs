using AutoMapper;
using HotelSystem_EF.Bll.DTO.Review;
using HotelSystem_EF.Bll.Services.Interfaces;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Bll.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ReviewService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<ReviewDTO>> GetAllAsync()
        {
            var result = await _uow.Review.GetAllAsync();
            return _mapper.Map<IEnumerable<Review>, IEnumerable<ReviewDTO>>(result);
        }


        public async Task<ReviewDTO> GetByIdAsync(int Id)
        {
            var result = await _uow.Review.GetByIdAsync(Id);

            return _mapper.Map<ReviewDTO>(result);
        }

        public async Task<ReviewDTO> CreateAsync(PostReviewDTO reviewDTO)
        {
            var result = await _uow.Review.CreateAsync(_mapper.Map<Review>(reviewDTO));

            return _mapper.Map<ReviewDTO>(result);
        }

        public async Task<ReviewDTO> UpdateAsync(ReviewDTO reviewDTO)
        {
            var result = await _uow.Review.UpdateAsync(_mapper.Map<Review>(reviewDTO));

            return _mapper.Map<ReviewDTO>(result);
        }

        public async Task<ReviewDTO> DeleteAsync(int Id)
        {
            var result = await _uow.Review.DeleteAsync(Id);

            return _mapper.Map<ReviewDTO>(result);
        }
    }
}
