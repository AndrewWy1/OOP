using Microsoft.AspNetCore.Mvc;
using WebApplication1.Contracts;

namespace WebApplication1.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProductController : ControllerBase
	{
		private readonly IProductRepository _productRepository;

		public ProductController(IProductRepository productRepository)
		{
			_productRepository = productRepository;
		}
		[HttpGet]
		public async Task<IActionResult> GetAllProducts()
		{
			try
			{
				var products = _productRepository.GetAllProductsAsync();
				 return Ok(products);
			}
			catch(Exception ex)
			{
				 return StatusCode(500, ex.Message);
			}
		}
	}
}
