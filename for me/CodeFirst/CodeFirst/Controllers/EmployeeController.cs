using CodeFirst.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using CodeFirst.Models;

namespace CodeFirst.Controllers
{
	[Route("api/employee")]
	[ApiController]
	public class EmployeeController : ControllerBase
	{
		private readonly IDataRepository<Employee> _dataReposiroty;

		public EmployeeController(IDataRepository<Employee> dataRepository)
		{
			_dataReposiroty = dataRepository;
		}

		[HttpGet]
		public IActionResult Get()
		{
			IEnumerable<Employee> employees = _dataReposiroty.GetAll();
			return Ok(employees);
		}

		[HttpGet("{id}", Name ="Get")]
		public IActionResult Get(long id)
		{
			Employee employee = _dataReposiroty.Get(id);

			if (employee is null)
				return NotFound("The employee couldn't be found");

			return Ok(employee);
		}

		[HttpPost]
		public IActionResult Post([FromBody] Employee employee)
		{
			if (employee is null)
				return BadRequest("Employee is null");

			_dataReposiroty.Add(employee);

			return CreatedAtRoute(
				"Get",
				new { id = employee.EmployeeId },
				employee
			);
		}

		[HttpPut("{id}")]
		public IActionResult Put(long id, [FromBody] Employee employee)
		{
			if (employee is null)
				return BadRequest("Employee is null");

			Employee employeeToUpdate = _dataReposiroty.Get(id);

			if (employeeToUpdate is null)
				return NotFound("The employee record couldn't be found");

			_dataReposiroty.Update(employeeToUpdate, employee);
			return NoContent();
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(long id)
		{
			Employee employee = _dataReposiroty.Get(id);
			if (employee is null)
				return NotFound("The employee record couldn't be found");

			_dataReposiroty.Delete(employee);
			return NoContent();
		}
	}
}
