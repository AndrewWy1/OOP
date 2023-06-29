using HotelSystem_EF.Bll.DTO.RoomAmenity;
using HotelSystem_EF.Bll.DTO.Service;
using HotelSystem_EF.Bll.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem_EF.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomAmenityController : Controller
    {
        private readonly IRoomAmenityService _roomAmenityService;

        public RoomAmenityController(IRoomAmenityService roomAmenityService)
        {
            _roomAmenityService = roomAmenityService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomAmenityDTO>>> GetAllInstrumentsAsync()
        {
            try
            {
                var result = await _roomAmenityService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex) { return StatusCode(500, ex.Message); }
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<RoomAmenityDTO>> GetByIdAsync(int Id)
        {
            try
            {
                var result = await _roomAmenityService.GetByIdAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<RoomAmenityDTO>> CreateAsync([FromBody] PostRoomAmenityDTO roomAmenity)
        {
            try
            {
                var result = await _roomAmenityService.CreateAsync(roomAmenity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<RoomAmenityDTO>> UpdateAsync([FromBody] RoomAmenityDTO roomAmenity)
        {
            try
            {
                var result = await _roomAmenityService.UpdateAsync(roomAmenity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<RoomAmenityDTO>> DeleteAsync(int Id)
        {
            try
            {
                var result = await _roomAmenityService.DeleteAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
