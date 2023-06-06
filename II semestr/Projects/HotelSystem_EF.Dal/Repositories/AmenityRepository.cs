using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Dal.Repositories
{
    public class AmenityRepository : GenericRepository<Amenity>, IAmenityRepository
    {
        public AmenityRepository(HotelSystemContext context) : base(context) 
        { }

        public override async Task<int> CreateAsync(Amenity amenity)
        {
            await _entity.AddAsync(amenity);

            return amenity.AmenityId;
        }

    }
}
