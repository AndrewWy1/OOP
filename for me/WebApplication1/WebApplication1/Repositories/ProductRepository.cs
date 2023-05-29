using Dapper;
using Microsoft.Data.SqlClient;
using WebApplication1.Context;
using WebApplication1.Contracts;
using WebApplication1.Entities;

namespace WebApplication1.Repositories
{
	public class ProductRepository : IProductRepository
	{
		private readonly DapperContext _context;

		public ProductRepository(DapperContext context)
		{
			_context= context;
		}

		public async Task<IEnumerable<Product>> GetAllProductsAsync()
		{
			string query = "SELECT * FROM Products";

			using (var connection = _context.CreateConnection())
			{
				connection.Open();

				return await connection.QueryAsync<Product>(query);
			}
		}

		public async Task<Product> GetProductAsync(int id)
		{
			string query = "SELECT * FROM Products WHERE Id = @id";

			using (var connection = _context.CreateConnection())
			{
				connection.Open();

				return await connection.QuerySingleOrDefaultAsync<Product>(query, new { id });
			}
		}

		public async Task<int> PostProductAsync(Product product)
		{
			string query = @"INSERT INTO Products (Name, Price)
            VALUES (@Name, @Price)
            SELECT CAST(SCOPE_IDENTITY() AS INT)";

			using (var connection = _context.CreateConnection())
			{
				connection.Open();

				return await connection.ExecuteScalarAsync<int>(query, product);
			}
			
		}

		public async Task<bool> UpdateProductAsync(Product product)
		{
			const string query = @"UPDATE Products
            SET Name = @Name, Price = @Price
            WHERE Id = @Id";

			using (var connection = _context.CreateConnection())
			{
				connection.Open();

				var rowsAffected = await connection.ExecuteAsync(query, product);
				return rowsAffected > 0;
			}
		}

		public async Task<bool> DeleteProductAsync(int id)
		{
			string query = @"DELETE FROM Products WHERE Id = @id";

			using (var connection = _context.CreateConnection())
			{
				connection.Open();
				var rowsAffected = await connection.ExecuteAsync(query, new { id });
				return rowsAffected > 0;
			}
		}
	}
}
