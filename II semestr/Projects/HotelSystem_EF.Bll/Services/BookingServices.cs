using AutoMapper;
using HotelSystem_EF.Bll.DTO.Booking;
using HotelSystem_EF.Bll.Services.Interfaces;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Bll.Services
{
    public class BookingServices : IBookingServices
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public BookingServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<BookingDTO>> GetAllAsync()
        {
            var result = await _uow.Booking.GetAllAsync();
            return _mapper.Map<IEnumerable<Booking>, IEnumerable<BookingDTO>>(result);
        }


        public async Task<BookingDTO> GetByIdAsync(int Id)
        {
            var result = await _uow.Booking.GetByIdAsync(Id);

            return _mapper.Map<BookingDTO>(result);
        }

        public async Task<BookingDTO> CreateAsync(PostBookingDTO bookingDTO)
        {
            var result = await _uow.Booking.CreateAsync(_mapper.Map<Booking>(bookingDTO));

            return _mapper.Map<BookingDTO>(result);
        }

        public async Task<BookingDTO> UpdateAsync(BookingDTO bookingDTO)
        {
            var result = await _uow.Booking.UpdateAsync(_mapper.Map<Booking>(bookingDTO));

            return _mapper.Map<BookingDTO>(result);
        }

        public async Task<BookingDTO> DeleteAsync(int Id)
        {
            var result = await _uow.Booking.DeleteAsync(Id);

            return _mapper.Map<BookingDTO>(result);
        }
    }
}
