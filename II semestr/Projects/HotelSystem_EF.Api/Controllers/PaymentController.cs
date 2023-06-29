using HotelSystem_EF.Bll.DTO.Payment;
using HotelSystem_EF.Bll.DTO.Review;
using HotelSystem_EF.Bll.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HotelSystem_EF.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : Controller
    {
        private readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentDTO>>> GetAllInstrumentsAsync()
        {
            try
            {
                var result = await _paymentService.GetAllAsync();
                return Ok(result);
            }
            catch (Exception ex) 
            {
                return StatusCode(500, ex.Message); 
            }
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<PaymentDTO>> GetByIdAsync(int Id)
        {
            try
            {
                var result = await _paymentService.GetByIdAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<PaymentDTO>> CreateAsync([FromBody] PostPaymentDTO payment)
        {
            try
            {
                var result = await _paymentService.CreateAsync(payment);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PaymentDTO>> UpdateAsync([FromBody] PaymentDTO payment)
        {
            try
            {
                var result = await _paymentService.UpdateAsync(payment);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<PaymentDTO>> DeleteAsync(int Id)
        {
            try
            {
                var result = await _paymentService.DeleteAsync(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
