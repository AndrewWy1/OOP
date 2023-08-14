using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem_EF.Dal.Repositories.IRepositories
{
    public interface IGenericTransitiveReposetory<TEntity> where TEntity : class
    {
        Task<(int, int)> CreateAsync(int firstId, int secondId, TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int firstId, int secondId);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
    }
}
