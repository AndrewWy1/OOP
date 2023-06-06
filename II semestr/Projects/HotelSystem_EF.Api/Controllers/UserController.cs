using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem_EF.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUnitOfWork _uow {get; set;}

        public UserController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<ActionResult> GetAllAsync()
        {
            var ametity = await _uow.User.GetAllAsync();

            return Ok(ametity);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetbyIdAsync(int id)
        {
            try
            {
                return Ok(await _uow.User.GetByIdAsync(id));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult> PostAsync([FromBody] User user)
        {
            try
            {
                await _uow.User.CreateAsync(user);
                await _uow.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody] User newUser)
        {
            if(newUser.FirstName is null || newUser.LastName is null || newUser.Username is null || newUser.Email is null)
            {
                return BadRequest();
            }

            var oldUser = await _uow.User.GetByIdAsync(newUser.UserId);

            if(oldUser != null)
            {
                return NotFound();
            }

            await _uow.User.UpdateAsync(newUser);
            return Ok();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
