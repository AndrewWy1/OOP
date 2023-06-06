using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Dal.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(HotelSystemContext context) : base(context)
        { }

        public override async Task<int> CreateAsync(User user)
        {
            await _entity.AddAsync(user);

            return user.UserId;
        }
    }
}
