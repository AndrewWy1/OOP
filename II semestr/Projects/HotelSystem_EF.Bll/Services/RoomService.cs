using AutoMapper;
using HotelSystem_EF.Bll.DTO.Amenity;
using HotelSystem_EF.Bll.DTO.Room;
using HotelSystem_EF.Bll.DTO.Service;
using HotelSystem_EF.Bll.Services.Interfaces;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Bll.Services
{
    public class RoomService : IRoomService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public RoomService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<RoomDTO>> GetAllAsync()
        {
            var result = await _uow.Room.GetAllAsync();
            return _mapper.Map<IEnumerable<Room>, IEnumerable<RoomDTO>>(result);
        }


        public async Task<RoomDTO> GetByIdAsync(int Id)
        {
            var result = await _uow.Room.GetByIdAsync(Id);

            return _mapper.Map<RoomDTO>(result);
        }

        public async Task<RoomDTO> CreateAsync(PostRoomDTO roomDTO)
        {
            var result = await _uow.Room.CreateAsync(_mapper.Map<Room>(roomDTO));

            return _mapper.Map<RoomDTO>(result);
        }

        public async Task<RoomDTO> UpdateAsync(RoomDTO roomDTO)
        {
            var result = await _uow.Room.UpdateAsync(_mapper.Map<Room>(roomDTO));

            return _mapper.Map<RoomDTO>(result);
        }

        public async Task<RoomDTO> DeleteAsync(int Id)
        {
            var result = await _uow.Service.DeleteAsync(Id);

            return _mapper.Map<RoomDTO>(result);
        }
    }
}