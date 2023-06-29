using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Dal.Repositories
{
    public class RoomAmenityRepository : GenericRepository<RoomAmenity>, IRoomAmenityRepository
    {
        public RoomAmenityRepository(HotelSystemContext context) : base(context)
        { }

    }
}
