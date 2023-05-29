namespace DapperDemoData.Data
{
	public interface IDataAccess
	{
		public Task<IEnumerable<T>> GetData<T, P>(string query, P parameters, string connectionId = "default");

		public Task SaveDate<P>(string query, P parameters, string connectionId = "default");

	}
}