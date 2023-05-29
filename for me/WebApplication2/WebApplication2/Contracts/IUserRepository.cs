using WebApplication2.Entities;

namespace WebApplication2.Contracts
{
	public interface IUserRepository
	{
		public Task CreateAsync(User user);
		public Task DeleteAsync(int id);
		public Task<User> GetByIdAsync(int id);
		public Task<IEnumerable<User>> GetAllAsync();
		public Task Update(User user);
	}
}
