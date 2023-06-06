using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Dal.Repositories
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(HotelSystemContext context) : base(context)
        { }

        public override async Task<int> CreateAsync(Booking booking)
        {
            await _entity.AddAsync(booking);

            return booking.BookingId;
        }
    }
}
