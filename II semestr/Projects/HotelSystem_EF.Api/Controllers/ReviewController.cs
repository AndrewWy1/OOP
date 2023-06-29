using HotelSystem_EF.Bll.DTO.Amenity;
using HotelSystem_EF.Bll.DTO.Review;
using HotelSystem_EF.Bll.Services.Interfaces;
using HotelSystem_EF.Dal.Repositories.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem_EF.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ReviewDTO>>> GetAllInstrumentsAsync()
        {
            try
            {
                var result = await _reviewService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ReviewDTO>> GetByIdAsync(int Id)
        {
            try
            {
                var result = await _reviewService.GetByIdAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ReviewDTO>> CreateAsync([FromBody] PostReviewDTO review)
        {
            try
            {
                var result = await _reviewService.CreateAsync(review);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ReviewDTO>> UpdateAsync([FromBody] ReviewDTO review)
        {
            try
            {
                var result = await _reviewService.UpdateAsync(review);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<ReviewDTO>> DeleteAsync(int Id)
        {
            try
            {
                var result = await _reviewService.DeleteAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
