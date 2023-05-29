using Wine_Store_DAL.Base_Entity;

namespace Wine_Store_DAL.Repository.Repository_Pattern_Interfaces_Realization.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : Entity
    {
        public Task<IEnumerable<TEntity>> GetInformation();
        public Task<TEntity> GetById(int id);
        public Task InsertEntity(TEntity entity);
        public Task UpdateEntity(TEntity entity);
        public Task DeleteEntity(int id);
    }
}
