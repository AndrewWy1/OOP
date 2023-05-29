using Dapper;
using DapperASPNetCore.Context;
using DapperASPNetCore.Contracts;
using DapperASPNetCore.Dto;
using DapperASPNetCore.Entities;
using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Xml.Linq;

namespace DapperASPNetCore.Repository
{
	public class CompanyRepository : ICompanyRepository
	{
		private readonly DapperContext _context;

		public CompanyRepository(DapperContext context)
		{
			_context = context;
		}

		public async Task<Company> CreateCompany(CompanyForCreationDto company)
		{
			string query = "INSERT INTO Company (Name, Address, Country)" +
				"VALUES (@name, @address, @country)" +
				"SELECT CAST(SCOPE_IDENTITY() as int)";

			var parameters = new DynamicParameters();
			parameters.Add("name", company.Name, DbType.String);
			parameters.Add("address", company.Address, DbType.String);
			parameters.Add("country", company.Country, DbType.String);

			using(var connection = _context.CreateConnection())
			{
				var id = await connection.QuerySingleAsync<int>(query, parameters);
				var createdCompany = new Company
				{
					Id = id,
					Name = company.Name,
					Address = company.Address,
					Country = company.Country,
				};
				return createdCompany;
			}
		}

		public async Task DeleteCompany(int id)
		{
			string query = "DELETE FROM Company WHERE Id = @id";

			using(IDbConnection connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, new { id }); 
			}
		}

		public async Task<IEnumerable<Company>> GetCompanies()
		{
			string query = "SELECT * FROM Company"; 

			using(var connection = _context.CreateConnection())
			{
				var companies = await connection.QueryAsync<Company>(query);
				return companies.ToList();
			}
		}

		public async Task<List<Company>> GetCompaniesEmployeesMultipleMapping()
		{
			string query = "SELECT * FROM Company JOIN Employee ON CompanyId = Company.Id";

			using(var connection = _context.CreateConnection())
			{
				var companyDict = new Dictionary<int, Company>();

				var companies = await connection.QueryAsync<Company, Employee, Company>(query, (company, employee) =>
				{
					if (!companyDict.TryGetValue(company.Id, out var currentCompany))
					{
						currentCompany = company;
						companyDict.Add(currentCompany.Id, currentCompany);
					}

					currentCompany.Employees.Add(employee);
					return currentCompany;
				});

				return companies.Distinct().ToList();
			}
		}

		public async Task<Company> GetCompanyByEmployeeId(int id)
		{
			string procedureName = "ShowCompanyForProvidedEmployeeId";

			var parameters = new DynamicParameters();
			parameters.Add("Id", id, DbType.Int32, ParameterDirection.Input);

			using(IDbConnection connection = _context.CreateConnection())
			{
				var company = await connection.QueryFirstOrDefaultAsync<Company>(procedureName, parameters, commandType: CommandType.StoredProcedure);

				return company;
			}


		}

		public async Task<Company> GetCompanyById(int id)
		{
			string query = "SELECT * FROM Company WHERE Id = @ID";

			using(IDbConnection connection = _context.CreateConnection())
			{
				return await connection.QueryFirstOrDefaultAsync<Company>(query, new {ID = id});
			}
		}

		public async Task<Company> GetCompanyEmployeesMultipleResult(int id)
		{
			var query = "SELECT * FROM Company WHERE Id = @Id;" +
				"SELECT * FROM Employee WHERE CompanyId = @Id";

			using (IDbConnection connection = _context.CreateConnection())
			{
				using (var multi = await connection.QueryMultipleAsync(query, new { id }))
				{
					var company = await multi.ReadSingleOrDefaultAsync<Company>();

					if (company != null)
						company.Employees = (await multi.ReadAsync<Employee>()).ToList();

					return company;
				}
			}
				
		}

		public async Task UpdateCompany(int id, CompanyForUpdateDto company)
		{
			var query = "UPDATE Company SET Name = @name, Address = @address, Country = @country WHERE Id = @id";

			var parameters = new DynamicParameters();
			parameters.Add("id", id, DbType.Int32);
			parameters.Add("name", company.Name, DbType.String);
			parameters.Add("address", company.Address, DbType.String);
			parameters.Add("country", company.Country, DbType.String);

			using(IDbConnection connection = _context.CreateConnection())
			{
				await connection.ExecuteAsync(query, parameters);
			}
		}
	}
}
