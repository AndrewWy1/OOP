using Microsoft.AspNetCore.Mvc;
using Wine_Store_DAL.Entities;
using Wine_Store_DAL.Repository.Repository_Pattern_Interfaces_Realization.Interfaces;

namespace Wine_Store_API.Controllers
{
    [ApiController]
    [Route("api/bottles")]
    public class BottlesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;
        public BottlesController(IUnitOfWork unitOfWork, ILogger<BottlesController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Bottles>>> GetInformation()
        {
            try
            {
                IEnumerable<Bottles> result = await _unitOfWork.Bottles.GetInformation();
                _unitOfWork.Commit();
                _logger.LogInformation($"Received all events from the database! {this.GetType().Name} model!");
                return Ok(result);

            }
            catch (Exception exception)
            {
                _logger.LogError($"The transaction failed. An error occurred in the {this.GetType().Name} model!");
                return StatusCode(StatusCodes.Status500InternalServerError, exception);
            }
        }

        [HttpGet("Id")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var result = await _unitOfWork.Bottles.GetById(id);
                _unitOfWork.Commit();

                if (result == null)
                {
                    _logger.LogInformation($"The model with Id: {id} was not found in the database!");
                    return NotFound();
                }
                else
                {
                    _logger.LogInformation($"Received an event from the database!");
                    return Ok(result);
                }
            }
            catch (Exception exception)
            {
                _logger.LogError($"The transaction failed. An error occurred in the {this.GetType().Name} model!");
                return StatusCode(StatusCodes.Status500InternalServerError, exception);
            }
        }

        [HttpPost]
        public async Task<IActionResult> InsertEntity(Bottles bottles)
        {
            try
            {
                if (bottles == null)
                {
                    _logger.LogInformation($"We got empty json from client side");
                    return BadRequest($"The event object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogInformation($"We received incorrect json from the client side");
                    return BadRequest("The event object is invalid");
                }

                await _unitOfWork.Bottles.InsertEntity(bottles);
                _unitOfWork.Commit();

                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception exception)
            {
                _logger.LogError($"The transaction failed. An error occurred in the {this.GetType().Name} model!");
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpDelete("Id")]
        public async Task<IActionResult> DeleteEntity(int id)
        {
            try
            {
                var result = await _unitOfWork.Bottles.GetById(id);
                if (result == null)
                {
                    _logger.LogInformation($"The model with Id: {id} was not found in the database!");
                    return NotFound();
                }

                await _unitOfWork.Bottles.DeleteEntity(id);
                _unitOfWork.Commit();
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception exception)
            {
                _logger.LogError($"The transaction failed. An error occurred in the {this.GetType().Name} model!");
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }

        [HttpPut("Id")]
        public async Task<IActionResult> Update_Entity(int id, Bottles bottles)
        {
            try
            {
                if (bottles == null)
                {
                    _logger.LogInformation($"We got empty json from client side");
                    return BadRequest($"The event object is null");
                }

                if (!ModelState.IsValid)
                {
                    _logger.LogInformation($"We received incorrect json from the client side");
                    return BadRequest("The event object is invalid");
                }

                var result = await _unitOfWork.Bottles.GetById(id);

                if (result == null)
                {
                    _logger.LogInformation($"The model with Id: {id} was not found in the database!");
                    return NotFound();
                }

                await _unitOfWork.Bottles.UpdateEntity(bottles);
                _unitOfWork.Commit();
                return StatusCode(StatusCodes.Status204NoContent);

            }
            catch (Exception exception)
            {
                _logger.LogError($"The transaction failed. An error occurred in the {this.GetType().Name} model!");
                return StatusCode(StatusCodes.Status500InternalServerError, exception.Message);
            }
        }
    }
}
