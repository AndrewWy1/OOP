using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem_EF.Dal.Repositories
{
    public class GenericTransitiveRepository<TEntity> :
       IGenericTransitiveReposetory<TEntity> where TEntity : class
    {
        protected readonly HotelSystemContext _context;
        protected readonly DbSet<TEntity> _entities;

        public GenericTransitiveRepository(HotelSystemContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }

        public virtual async Task<(int, int)> CreateAsync(int firstId, int secondId, TEntity entity)
        {
            await _entities.AddAsync(entity);
            return (firstId, secondId);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public virtual async Task<TEntity> GetByIdAsync(int firstId, int secondId)
        {
            return await _entities.FindAsync(firstId, secondId);
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                _entities.Update(entity);
                _context.SaveChanges();
            });
        }

        public virtual async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                _entities.Update(entity);
                _context.SaveChanges();
            });
        }
    }
}
