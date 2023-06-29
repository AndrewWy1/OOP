using AutoMapper;
using HotelSystem_EF.Bll.DTO.Amenity;
using HotelSystem_EF.Bll.DTO.User;
using HotelSystem_EF.Bll.Services.Interfaces;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;

namespace HotelSystem_EF.Bll.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<UserDTO>> GetAllAsync()
        {
            var result = await _uow.User.GetAllAsync();
            return _mapper.Map<IEnumerable<User>, IEnumerable<UserDTO>>(result);
        }


        public async Task<UserDTO> GetByIdAsync(int Id)
        {
            var result = await _uow.User.GetByIdAsync(Id);

            return _mapper.Map<UserDTO>(result);
        }

        public async Task<UserDTO> CreateAsync(PostUserDTO userDTO)
        {
            var result = await _uow.User.CreateAsync(_mapper.Map<User>(userDTO));

            return _mapper.Map<UserDTO>(result);
        }

        public async Task<UserDTO> UpdateAsync(UserDTO userDTO)
        {
            var result = await _uow.User.UpdateAsync(_mapper.Map<User>(userDTO));

            return _mapper.Map<UserDTO>(result);
        }

        public async Task<UserDTO> DeleteAsync(int Id)
        {
            var result = await _uow.User.DeleteAsync(Id);

            return _mapper.Map<UserDTO>(result);
        }
    }
}
