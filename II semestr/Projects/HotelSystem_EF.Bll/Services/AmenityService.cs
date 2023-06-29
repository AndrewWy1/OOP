using AutoMapper;
using HotelSystem_EF.Bll.DTO.Amenity;
using HotelSystem_EF.Bll.Services.Interfaces;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Bll.Services
{
    public class AmenityService : IAmenityService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public AmenityService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<AmenityDTO>> GetAllAsync()
        {
            var result = await _uow.Amenity.GetAllAsync();
            return _mapper.Map<IEnumerable<Amenity>, IEnumerable<AmenityDTO>>(result);
        }


        public async Task<AmenityDTO> GetByIdAsync(int Id)
        {
            var result = await _uow.Amenity.GetByIdAsync(Id);

            return _mapper.Map<AmenityDTO>(result);
        }

        public async Task<AmenityDTO> CreateAsync(PostAmenityDTO amenityDTO)
        {
            var result = await _uow.Amenity.CreateAsync(_mapper.Map<Amenity>(amenityDTO));

            return _mapper.Map<AmenityDTO>(result);
        }

        public async Task<AmenityDTO> UpdateAsync(AmenityDTO amenityDTO)
        {
            var result = await _uow.Amenity.UpdateAsync(_mapper.Map<Amenity>(amenityDTO));

            return _mapper.Map<AmenityDTO>(result);
        }

        public async Task<AmenityDTO> DeleteAsync(int Id)
        {
            var result = await _uow.Amenity.DeleteAsync(Id);

            return _mapper.Map<AmenityDTO>(result);
        }
    }
}
