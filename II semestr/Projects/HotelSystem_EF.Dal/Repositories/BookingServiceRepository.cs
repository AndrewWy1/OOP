using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Dal.Repositories
{
    public class BookingServiceRepository : GenericRepository<BookingService>, IBookingServiceRepository
    {
        public BookingServiceRepository(HotelSystemContext context) : base(context)
        { }

        public override async Task<int> CreateAsync(BookingService bookingService)
        {
            await _entity.AddAsync(bookingService);

            return bookingService.BookingServiceId;
        }
    }
}
