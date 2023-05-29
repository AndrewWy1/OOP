using WebApplication1.Entities;

namespace WebApplication1.Contracts
{
	public interface IProductRepository
	{
		public Task<IEnumerable<Product>> GetAllProductsAsync();
		public Task<Product> GetProductAsync(int id);
		public Task<int> PostProductAsync(Product product);
		public Task<bool> UpdateProductAsync(Product product);
		public Task<bool> DeleteProductAsync(int id);
	}
}
