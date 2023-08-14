using HotelSystem_EF.Bll.DTO.Amenity;
using HotelSystem_EF.Bll.DTO.User;
using HotelSystem_EF.Bll.Services.Interfaces;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem_EF.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService amenityService)
        {
            _userService = amenityService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetlAllUsersAsync()
        {
            try
            {
                var result = await _userService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex) { return StatusCode(500, ex.Message); }
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<UserDTO>> GetByIdAsync(int Id)
        {
            try
            {
                var result = await _userService.GetByIdAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<UserDTO>> CreateAsync([FromBody] PostUserDTO user)
        {
            try
            {
                var result = await _userService.CreateAsync(user);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UserDTO>> UpdateAsync([FromBody] UserDTO user)
        {
            try
            {
                var result = await _userService.UpdateAsync(user);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        public async Task<ActionResult<UserDTO>> DeleteAsync(int Id)
        {
            try
            {
                var result = await _userService.DeleteAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
