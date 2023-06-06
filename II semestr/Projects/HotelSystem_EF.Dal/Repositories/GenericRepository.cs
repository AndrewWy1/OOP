using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HotelSystem_EF.Dal.Repositories
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly HotelSystemContext _context;
        protected readonly DbSet<TEntity> _entity;

        public GenericRepository(HotelSystemContext context)
        {
            _context = context;
            _entity = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entity.ToListAsync();
        }

        public virtual async Task<TEntity?> GetByIdAsync(int id)
        {
            var entity =  await _entity.FindAsync(id);

            if (entity is null)
                throw new Exception();

            return entity;
        }

        public abstract Task<int> CreateAsync(TEntity entity);

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);

            if(entity is null)
                throw new Exception();

            await Task.Run(() => _entity.Remove(entity));
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => _entity.Update(entity));
        }
           
    }
}
