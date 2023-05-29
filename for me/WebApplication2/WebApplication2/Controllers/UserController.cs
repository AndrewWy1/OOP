using Microsoft.AspNetCore.Mvc;
using WebApplication2.Contracts;

namespace WebApplication2.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class UserController : ControllerBase
	{
		private readonly IUserRepository _userRepository;

		public UserController(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}

		[HttpGet]
		public async Task<IActionResult> GetUsers()
		{
			var users = await _userRepository.GetAllAsync();
			return Ok(users);
		}

		[HttpGet("{id}", Name = "UserById")]
		public async Task<IActionResult> GetUserById(int id)
		{
			var company = await _userRepository.GetByIdAsync(id);
			if(company == null) { return NotFound(); }

			return Ok(company);
		}
	}
}
