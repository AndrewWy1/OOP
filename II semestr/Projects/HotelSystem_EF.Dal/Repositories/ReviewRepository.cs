using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Dal.Repositories
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(HotelSystemContext context) : base(context)
        { }

        public override async Task<int> CreateAsync(Review review)
        {
            await _entity.AddAsync(review);

            return review.ReviewId;
        }
    }
}
