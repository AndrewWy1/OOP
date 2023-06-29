using AutoMapper;
using HotelSystem_EF.Bll.DTO.BookingService;
using HotelSystem_EF.Bll.Services.Interfaces;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Bll.Services
{
    public class BookingServiceService : IBookingServiceService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public BookingServiceService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }

        public async Task<(int, int)?> CreateAsync(BookingServiceDTO entity)
        {
            var bookingService = _mapper.Map<BookingService>(entity);

            var id = await _uow.BookingService.CreateAsync(bookingService.BookingId, bookingService.ServiveId, bookingService);

            return id;
        }

        public async Task<IEnumerable<BookingServiceDTO>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<BookingService>, IEnumerable<BookingServiceDTO>>(await _uow.BookingService.GetAllAsync());
        }

        public async Task<BookingServiceDTO?> GetByIdAsync(int firstId, int secondId)
        {
            BookingService bookinfService = await _uow.BookingService.GetByIdAsync(firstId, secondId);

            BookingServiceDTO? bookingServiceDTO = null;

            if (bookinfService is not null)
                bookingServiceDTO = _mapper.Map<BookingServiceDTO>(bookinfService);

            return bookingServiceDTO;
        }

        public async Task UpdateAsync(BookingServiceDTO entity)
        {
            BookingService bookingService = _mapper.Map<BookingService>(entity);

            await _uow.BookingService.UpdateAsync(bookingService);
        }

        public async Task DeleteAsync(int firstId, int secondId)
        {
            var entity = await _uow.BookingService.GetByIdAsync(firstId, secondId);

            await _uow.BookingService.DeleteAsync(entity);
        }
    }
}
