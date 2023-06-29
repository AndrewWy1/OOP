using HotelSystem_EF.Bll.DTO.Service;

namespace HotelSystem_EF.Bll.Services.Interfaces
{
    public interface IServiceService
    {
        Task<IEnumerable<ServiceDTO>> GetAllAsync();

        Task<ServiceDTO> GetByIdAsync(int Id);

        Task<ServiceDTO> CreateAsync(PostServiceDTO serviceDTO);

        Task<ServiceDTO> UpdateAsync(ServiceDTO serviceDTO);

        Task<ServiceDTO> DeleteAsync(int Id);
    }
}
