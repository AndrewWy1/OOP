using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDapperDAL.Contracts
{
	internal interface IEntityParser<TEntity>  where TEntity : IEntity 
	{
		IEnumerable<string> Properties { get; }
	}
}
