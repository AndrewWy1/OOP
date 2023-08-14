using HotelSystem_EF.Dal.Data;
using HotelSystem_EF.Dal.Models;
using HotelSystem_EF.Dal.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HotelSystem_EF.Dal.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly HotelSystemContext _context;
        private readonly DbSet<TEntity> _entity;

        public GenericRepository(HotelSystemContext context)
        {
            _context = context;
            _entity = context.Set<TEntity>();
        }


        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entity.AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int Id)
        {
            var entity = await _entity.AsNoTracking().FirstOrDefaultAsync(x => x.Id == Id);

            if (entity is null)
                throw new Exception("Result is null");

            return entity;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            await _entity.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> DeleteAsync(int Id)
        {
            var entity = await _entity.AsNoTracking().FirstOrDefaultAsync(x => x.Id == Id);

            if (entity is null)
                throw new Exception("Result is null");

            _entity.Remove(entity);

            await _context.SaveChangesAsync();

            return entity;

        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var oldEntity = await _entity.AsNoTracking().FirstOrDefaultAsync(x => x.Id == entity.Id);

            if (oldEntity is null)
                throw new Exception("Result not found");

            _entity.Update(entity);

            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
