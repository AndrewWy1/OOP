using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem_EF.Dal.Repositories
{
    public class BookingServiceRepository : GenericTransitiveRepository<BookingService>, IBookingServiceRepository
    {
        public BookingServiceRepository(HotelSystemContext context) : base(context)
        { }

        public override async Task<IEnumerable<BookingService>> GetAllAsync()
        {
            return await _entities
                .Include(e => e.Booking)
                .Include(e => e.Service)
                .ToListAsync();
        }

        public override async Task<BookingService> GetByIdAsync(int firstId, int secondId)
        {
            return await _entities
                .Include(e => e.Booking)
                .Include(e => e.Service)
                .FirstOrDefaultAsync(e => e.BookingId == firstId && e.ServiveId == secondId);
        }
    }
}
