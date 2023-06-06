using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace HotelSystem_EF.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmenityController : ControllerBase 
    {
    
        private IUnitOfWork _uof { get; set; }

        public AmenityController(IUnitOfWork uof)
        {
            _uof= uof;
        }

        // GET: api/<AmenityController>
        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            var ametity = await _uof.Amenity.GetAllAsync();

            return Ok(ametity);
        }

        // GET api/<AmenityController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetbyIdAsync(int id)
        {
            try
            {
                return Ok(await _uof.Amenity.GetByIdAsync(id));
            }
            catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // POST api/<AmenityController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] Amenity amenity)
        {
            try
            {
                await _uof.Amenity.CreateAsync(amenity);
                await _uof.SaveChangesAsync();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<AmenityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AmenityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
