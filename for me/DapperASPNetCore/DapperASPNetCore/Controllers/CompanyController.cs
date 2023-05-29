using DapperASPNetCore.Contracts;
using DapperASPNetCore.Dto;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DapperASPNetCore.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CompanyController : ControllerBase
	{
		private readonly ICompanyRepository _companyRepository;

		public CompanyController(ICompanyRepository companyRepository)
		{
			_companyRepository = companyRepository;
		}



		// GET: api/<CompanyController>
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var companies = await _companyRepository.GetCompanies();
			return Ok(companies);
		}

		// GET api/<CompanyController>/5
		[HttpGet("{id}", Name = "CompanyById")]
		public async Task<IActionResult> GetById(int id)
		{
			var company = await _companyRepository.GetCompanyById(id);

			if (company is null)
				return NotFound();

			return Ok(company);
		}

		// POST api/<CompanyController>
		[HttpPost]
		public async Task<IActionResult> Post(CompanyForCreationDto company)
		{
			try
			{
				var createdCompany = await _companyRepository.CreateCompany(company);
				return CreatedAtRoute("CompanyById", new { id = createdCompany.Id }, createdCompany);
			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		// PUT api/<CompanyController>/5
		[HttpPut("{id}")]
		public async Task<IActionResult> Put(int id, CompanyForUpdateDto company)
		{
			try
			{
				var DBCompany = await _companyRepository.GetCompanyById(id);

				if(DBCompany is null)
					return NotFound();

				await _companyRepository.UpdateCompany(id, company);
				return NoContent();
			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		// DELETE api/<CompanyController>/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			try
			{
				var DBCompany = await _companyRepository.GetCompanyById(id);
				if(DBCompany is null)
					return NotFound();

				await _companyRepository.DeleteCompany(id);
				return NoContent();
			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("ByEmployeeId/{id}")]
		public async Task<IActionResult> GetCompanyForEmployee(int id)
		{
			try
			{
				var company = await _companyRepository.GetCompanyByEmployeeId(id);

				if(company is null)
					return NotFound();

				return Ok(company);
			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("{id}/MultipleResult")]
		public async Task<IActionResult> GetCompanyEmployeesMultipleResult(int id)
		{
			try
			{
				var company = await _companyRepository.GetCompanyEmployeesMultipleResult(id);
				if (company is null)
					return NotFound();

				return Ok(company);
			}
			catch (Exception ex)
			{
				return StatusCode(500, ex.Message);
			}
		}

		[HttpGet("MultipleMapping")]
		public async Task<IActionResult> GetCompaniesEmployeesMultipleMapping()
		{
			try
			{
				var company = await _companyRepository.GetCompaniesEmployeesMultipleMapping();
				return Ok(company);
			}
			catch (Exception ex)
			{
				//log error
				return StatusCode(500, ex.Message);
			}
		}
	}
}
