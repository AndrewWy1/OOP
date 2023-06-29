using HotelSystem_EF.Bll.DTO.Room;
using HotelSystem_EF.Bll.DTO.Service;

namespace HotelSystem_EF.Bll.Services.Interfaces
{
    public interface IRoomService
    {
        Task<IEnumerable<RoomDTO>> GetAllAsync();

        Task<RoomDTO> GetByIdAsync(int Id);

        Task<RoomDTO> CreateAsync(PostRoomDTO roomDTO);

        Task<RoomDTO> UpdateAsync(RoomDTO roomDTO);

        Task<RoomDTO> DeleteAsync(int Id);
    }
}
