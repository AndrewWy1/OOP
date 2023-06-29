using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem_EF.Bll.Services.Interfaces
{
    public interface IGenericTransitiveService <TEntity> where TEntity : class
    {
        Task<(int, int)?> CreateAsync(TEntity entity);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity?> GetByIdAsync(int firstId, int secondId);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(int firstId, int secondId);
    }
}
