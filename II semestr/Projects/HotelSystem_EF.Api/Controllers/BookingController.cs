using HotelSystem_EF.Bll.DTO.Booking;
using HotelSystem_EF.Bll.DTO.BookingService;
using HotelSystem_EF.Bll.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem_EF.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : Controller
    {
        private readonly IBookingServices _booking;

        public BookingController(IBookingServices booking)
        {
            _booking = booking;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingDTO>>> GetAllInstrumentsAsync()
        {
            try
            {
                var result = await _booking.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<BookingDTO>> GetByIdAsync(int Id)
        {
            try
            {
                var result = await _booking.GetByIdAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

        [HttpPost]
        public async Task<ActionResult<BookingDTO>> CreateAsync([FromBody] PostBookingDTO bookng)
        {
            try
            {
                var result = await _booking.CreateAsync(bookng);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<BookingDTO>> UpdateAsync([FromBody] BookingDTO bookng)
        {
            try
            {
                var result = await _booking.UpdateAsync(bookng);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<BookingDTO>> DeleteAsync(int Id)
        {
            try
            {
                var result = await _booking.DeleteAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
