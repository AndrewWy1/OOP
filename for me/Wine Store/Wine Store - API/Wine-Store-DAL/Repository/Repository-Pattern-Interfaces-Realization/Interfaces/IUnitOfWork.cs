namespace Wine_Store_DAL.Repository.Repository_Pattern_Interfaces_Realization.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IBottles Bottles { get; }
        public void Commit();
    }
}
