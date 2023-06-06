using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Dal.Repositories
{
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(HotelSystemContext context) : base(context)
        { }

        public override async Task<int> CreateAsync(Room room)
        {
            await _entity.AddAsync(room);

            return room.RoomId;
        }
    }
}
