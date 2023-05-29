using System.Data;
using Wine_Store_DAL.Repository.Repository_Pattern_Interfaces_Realization.Interfaces;

namespace Wine_Store_DAL.Repository.Repository_Pattern_Interfaces_Realization
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbTransaction _transaction;
        public IBottles Bottles { get; }
        public UnitOfWork(IDbTransaction transaction, IBottles bottles)
        {
            _transaction = transaction;
            Bottles = bottles;
        }
        public void Dispose()
        {
            _transaction.Connection?.Close();
            _transaction.Connection?.Dispose();
            _transaction.Dispose();
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch (Exception exception)
            {
                _transaction.Rollback();
                Console.WriteLine(exception);
            }
        }
    }
}
