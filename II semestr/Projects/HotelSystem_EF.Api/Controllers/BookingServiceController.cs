using HotelSystem_EF.Bll.DTO.BookingService;
using HotelSystem_EF.Bll.Services.Interfaces;
using HotelSystem_EF.Dal.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem_EF.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingServiceController : Controller
    {
        private readonly IBookingServiceService _bookingService;

        public BookingServiceController(IBookingServiceService bookingService)
        {
            _bookingService = bookingService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingServiceDTO>>> GetAllInstrumentsAsync()
        {
            try
            {
                var result = await _bookingService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{bookingId}/{serviceId}")]
        public async Task<ActionResult<BookingServiceDTO>> GetByIdAsync(int bookingId, int serviceId)
        {
            try
            {
                var result = await _bookingService.GetByIdAsync(bookingId, serviceId);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<BookingServiceDTO>> CreateAsync([FromBody] BookingServiceDTO bookingService)
        {
            try
            {
                var result = await _bookingService.CreateAsync(bookingService);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateAsync(BookingServiceDTO bookingService)
        {
            try
            {
                await _bookingService.UpdateAsync(bookingService);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{bookingId}/{serviceId}")]
        public async Task<ActionResult<BookingServiceDTO>> DeleteAsync(int bookingId, int serviceId)
        {
            try
            {
                await _bookingService.DeleteAsync(bookingId, serviceId);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
