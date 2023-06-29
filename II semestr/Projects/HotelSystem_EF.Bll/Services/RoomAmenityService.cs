using AutoMapper;
using HotelSystem_EF.Bll.DTO.RoomAmenity;
using HotelSystem_EF.Bll.Services.Interfaces;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Bll.Services
{
    public class RoomAmenityService : IRoomAmenityService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public RoomAmenityService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<RoomAmenityDTO>> GetAllAsync()
        {
            var result = await _uow.RoomAmenity.GetAllAsync();
            return _mapper.Map<IEnumerable<RoomAmenity>, IEnumerable<RoomAmenityDTO>>(result);
        }


        public async Task<RoomAmenityDTO> GetByIdAsync(int Id)
        {
            var result = await _uow.RoomAmenity.GetByIdAsync(Id);

            return _mapper.Map<RoomAmenityDTO>(result);
        }

        public async Task<RoomAmenityDTO> CreateAsync(PostRoomAmenityDTO roomAmenityDTO)
        {
            var result = await _uow.RoomAmenity.CreateAsync(_mapper.Map<RoomAmenity>(roomAmenityDTO));

            return _mapper.Map<RoomAmenityDTO>(result);
        }

        public async Task<RoomAmenityDTO> UpdateAsync(RoomAmenityDTO roomAmenityDTO)
        {
            var result = await _uow.RoomAmenity.UpdateAsync(_mapper.Map<RoomAmenity>(roomAmenityDTO));

            return _mapper.Map<RoomAmenityDTO>(result);
        }

        public async Task<RoomAmenityDTO> DeleteAsync(int Id)
        {
            var result = await _uow.RoomAmenity.DeleteAsync(Id);

            return _mapper.Map<RoomAmenityDTO>(result);
        }
    }
}
