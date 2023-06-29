using HotelSystem_EF.Bll.DTO.Booking;

namespace HotelSystem_EF.Bll.Services.Interfaces
{
    public interface IBookingServices
    {
        Task<IEnumerable<BookingDTO>> GetAllAsync();

        Task<BookingDTO> GetByIdAsync(int Id);

        Task<BookingDTO> CreateAsync(PostBookingDTO bookingDTO);

        Task<BookingDTO> UpdateAsync(BookingDTO bookingDTO);

        Task<BookingDTO> DeleteAsync(int Id);
    }
}
