using HotelSystem_EF.Bll.DTO.RoomAmenity;

namespace HotelSystem_EF.Bll.Services.Interfaces
{
    public interface IRoomAmenityService
    {
        Task<IEnumerable<RoomAmenityDTO>> GetAllAsync();

        Task<RoomAmenityDTO> GetByIdAsync(int Id);

        Task<RoomAmenityDTO> CreateAsync(PostRoomAmenityDTO roomAmenityDTO);

        Task<RoomAmenityDTO> UpdateAsync(RoomAmenityDTO roomAmenityDTO);

        Task<RoomAmenityDTO> DeleteAsync(int Id);
    }
}
