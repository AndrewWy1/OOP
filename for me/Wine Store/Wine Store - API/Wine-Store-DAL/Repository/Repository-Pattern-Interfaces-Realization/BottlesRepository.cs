using System.Data;
using Microsoft.Data.SqlClient;
using Wine_Store_DAL.Entities;
using Wine_Store_DAL.Repository.Repository_Pattern_Interfaces_Realization.Interfaces;

namespace Wine_Store_DAL.Repository.Repository_Pattern_Interfaces_Realization
{
    public class BottlesRepository : RepositoryBase<Bottles>, IBottles
    {
        public BottlesRepository(SqlConnection connection, IDbTransaction transaction) : base(connection, transaction, "Bottles")
        {
        }
    }
}
