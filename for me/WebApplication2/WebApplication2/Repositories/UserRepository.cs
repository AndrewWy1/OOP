using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using WebApplication2.Contracts;
using WebApplication2.Entities;

namespace WebApplication2.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly string _connectionString;

		public UserRepository(string connectionString)
		{
			_connectionString = connectionString;
		}

		public async Task CreateAsync(User user)
		{
			string query = "INSERT INTO User(name, age) " +
						   "VALUES(@name, @age)";
			using(IDbConnection connection = new SqlConnection(_connectionString))
			{
				 connection.Execute(query, user);
			}
		}

		public async Task DeleteAsync(int id)
		{
			string query = "DELETE FROM User " +
					"WHERE user_id = @id";

			using (IDbConnection connection = new SqlConnection(_connectionString))
			{
				connection.Execute(query, id);
			}
		}

		public async Task<IEnumerable<User>> GetAllAsync()
		{
			string query = "SELECT * FROM User";

			using (IDbConnection connection = new SqlConnection(_connectionString))
			{
				return connection.Query<User>(query).ToList();
			}
		}

		public async Task<User> GetByIdAsync(int id)
		{
			string query = "SELECT * FROM User " +
				"WHERE user_id = @id";

			using(IDbConnection connection = new SqlConnection(_connectionString))
			{
				return connection.QuerySingleOrDefault(query, new { id });
			}
		}

		public async Task Update(User user)
		{
			string query = "UPDATE User" +
				"SET name = @name age = @age" +
				"WHERE user_id = @id";

			using (IDbConnection connection = new SqlConnection(_connectionString))
			{
				connection.Execute(query, user);
			}
		}
	}
}
