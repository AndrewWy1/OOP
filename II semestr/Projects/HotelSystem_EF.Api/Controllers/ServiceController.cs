using HotelSystem_EF.Bll.DTO.Amenity;
using HotelSystem_EF.Bll.DTO.Service;
using HotelSystem_EF.Bll.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem_EF.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceDTO>>> GetAllInstrumentsAsync()
        {
            try
            {
                var result = await _serviceService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex) { return StatusCode(500, ex.Message); }
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ServiceDTO>> GetByIdAsync(int Id)
        {
            try
            {
                var result = await _serviceService.GetByIdAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ServiceDTO>> CreateAsync([FromBody] PostServiceDTO service)
        {
            try
            {
                var result = await _serviceService.CreateAsync(service);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ServiceDTO>> UpdateAsync([FromBody] ServiceDTO service)
        {
            try
            {
                var result = await _serviceService.UpdateAsync(service);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<ServiceDTO>> DeleteAsync(int Id)
        {
            try
            {
                var result = await _serviceService.DeleteAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
