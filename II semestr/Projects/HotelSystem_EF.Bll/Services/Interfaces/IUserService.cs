using HotelSystem_EF.Bll.DTO.User;
using HotelSystem_EF.Dal.Models;

namespace HotelSystem_EF.Bll.Services.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAllAsync();

        Task<UserDTO> GetByIdAsync(int Id);

        Task<UserDTO> CreateAsync(PostUserDTO userDTO);

        Task<UserDTO> UpdateAsync(UserDTO userDTO);

        Task<UserDTO> DeleteAsync(int Id);
    }
}
