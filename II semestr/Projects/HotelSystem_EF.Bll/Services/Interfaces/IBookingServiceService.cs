using HotelSystem_EF.Bll.DTO.BookingService;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Bll.Services.Interfaces
{
    public interface IBookingServiceService : IGenericTransitiveService<BookingServiceDTO>
    {
    }
}
