using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Dal.Repositories
{
    public class ServiceRepository : GenericRepository<Service>, IServiceRepository
    {
        public ServiceRepository(HotelSystemContext context) : base(context)
        { }
        public override async Task<int> CreateAsync(Service service)
        {
            await _entity.AddAsync(service);

            return service.ServiceId;
        }

    }
}
