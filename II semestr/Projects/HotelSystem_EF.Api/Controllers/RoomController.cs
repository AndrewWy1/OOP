using HotelSystem_EF.Bll.DTO.Amenity;
using HotelSystem_EF.Bll.DTO.Room;
using HotelSystem_EF.Bll.DTO.RoomAmenity;
using HotelSystem_EF.Bll.DTO.Service;
using HotelSystem_EF.Bll.Services;
using HotelSystem_EF.Bll.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem_EF.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
             _roomService = roomService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomDTO>>> GetAllInstrumentsAsync()
        {
            try
            {
                var result = await _roomService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex) { return StatusCode(500, ex.Message); }
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<RoomDTO>> GetByIdAsync(int Id)
        {
            try
            {
                var result = await _roomService.GetByIdAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<RoomDTO>> CreateAsync([FromBody] PostRoomDTO room)
        {
            try
            {
                var result = await _roomService.CreateAsync(room);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<RoomDTO>> UpdateAsync([FromBody] RoomDTO room)
        {
            try
            {
                var result = await _roomService.UpdateAsync(room);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<RoomDTO>> DeleteAsync(int Id)
        {
            try
            {
                var result = await _roomService.DeleteAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
