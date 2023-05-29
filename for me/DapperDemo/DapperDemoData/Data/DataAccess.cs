using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
namespace DapperDemoData.Data
{
	 public class DataAccess : IDataAccess
	 {
		private readonly IConfiguration _configuration;

		public DataAccess(IConfiguration configuration)
		{
			_configuration = configuration;
		}

		//will return list of type T
		public async Task<IEnumerable<T>> GetData<T, P>(string query, P parameters, string connectionId = "default")
		{
			using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));

			return await connection.QueryAsync<T>(query, parameters);
		}

		//will not return anything 
		public async Task SaveDate<P>(string query, P parameters, string connectionId = "default")
		{
			using IDbConnection connection = new SqlConnection(_configuration.GetConnectionString(connectionId));

			await connection.ExecuteAsync(query, parameters);

		}
	}
}
