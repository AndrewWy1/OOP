using AutoMapper;
using HotelSystem_EF.Bll.DTO.Amenity;
using HotelSystem_EF.Bll.DTO.Service;
using HotelSystem_EF.Bll.Services.Interfaces;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Bll.Services
{
    public class ServiceService : IServiceService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ServiceService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<ServiceDTO>> GetAllAsync()
        {
            var result = await _uow.Service.GetAllAsync();
            return _mapper.Map<IEnumerable<Service>, IEnumerable<ServiceDTO>>(result);
        }


        public async Task<ServiceDTO> GetByIdAsync(int Id)
        {
            var result = await _uow.Service.GetByIdAsync(Id);

            return _mapper.Map<ServiceDTO>(result);
        }

        public async Task<ServiceDTO> CreateAsync(PostServiceDTO serviceDTO)
        {
            var result = await _uow.Service.CreateAsync(_mapper.Map<Service>(serviceDTO));

            return _mapper.Map<ServiceDTO>(result);
        }

        public async Task<ServiceDTO> UpdateAsync(ServiceDTO serviceDTO)
        {
            var result = await _uow.Service.UpdateAsync(_mapper.Map<Service>(serviceDTO));

            return _mapper.Map<ServiceDTO>(result);
        }

        public async Task<ServiceDTO> DeleteAsync(int Id)
        {
            var result = await _uow.Service.DeleteAsync(Id);

            return _mapper.Map<ServiceDTO>(result);
        }
    }
}
