using System.Linq.Expressions;

namespace HotelSystem_EF.Dal.Repositories.IRepositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity?> GetByIdAsync(int id);

        Task<int> CreateAsync(TEntity entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(TEntity entity);
    }
}
