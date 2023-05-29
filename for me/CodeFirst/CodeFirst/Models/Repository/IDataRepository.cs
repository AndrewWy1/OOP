namespace CodeFirst.Models.Repository
{
	public interface IDataRepository<TEntity>
	{
		IEnumerable<TEntity> GetAll();
		TEntity Get(long Id);
		void Add(TEntity entity);
		void Update(TEntity entity, TEntity newEntity);
		void Delete(TEntity entity);
	}
}
