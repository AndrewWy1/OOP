using AutoMapper;
using HotelSystem_EF.Bll.DTO.Amenity;
using HotelSystem_EF.Bll.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HotelSystem_EF.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AmenityController : Controller
    {
        private readonly IAmenityService _amenityService;

        public AmenityController(IAmenityService amenityService)
        {
            _amenityService = amenityService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmenityDTO>>> GetAllInstrumentsAsync()
        {
            try
            {
                var result = await _amenityService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<AmenityDTO>> GetByIdAsync(int Id)
        {
            try
            {
                var result = await _amenityService.GetByIdAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                 return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<AmenityDTO>> CreateAsync([FromBody] PostAmenityDTO amenity)
        {
            try
            {
                var result = await _amenityService.CreateAsync(amenity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<AmenityDTO>> UpdateAsync([FromBody] AmenityDTO amenity)
        {
            try
            {
                var result = await _amenityService.UpdateAsync(amenity);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<AmenityDTO>> DeleteAsync(int Id)
        {
            try
            {
                var result = await _amenityService.DeleteAsync(Id);
                return Ok(result);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
