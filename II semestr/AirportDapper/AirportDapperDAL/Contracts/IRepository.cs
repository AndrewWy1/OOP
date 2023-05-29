using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDapperDAL.Contracts
{
	internal interface IRepository <TEntity> where TEntity : IEntity
	{
		public Task<IEnumerable<TEntity>> GetAllAsync();
		public Task<TEntity> GetAsync(int id);
		public Task InsertAsync(TEntity entity);
		public Task UpdateAsync(int id, TEntity entity);
		public Task DeleteAsync(int id);
	}
}
