using HotelSystem_EF.Bll.DTO.Amenity;

namespace HotelSystem_EF.Bll.Services.Interfaces
{
    public interface IAmenityService
    {
        Task<IEnumerable<AmenityDTO>> GetAllAsync();

        Task<AmenityDTO> GetByIdAsync(int Id);

        Task<AmenityDTO> CreateAsync(PostAmenityDTO amenityDTO);

        Task<AmenityDTO> UpdateAsync(AmenityDTO amenityDTO);

        Task<AmenityDTO> DeleteAsync(int Id);

    }
}
