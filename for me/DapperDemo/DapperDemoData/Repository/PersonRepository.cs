using DapperDemoData.Data;
using DapperDemoData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemoData.Repository
{
	public class PersonRepository : IPersonRepository
	{

		private readonly IDataAccess _db;

		public PersonRepository(IDataAccess db)
		{
			_db = db;
		}

		public async Task<bool> AddPerson(Person person)
		{
			try
			{
				string query = "INSERT INTO Person (name, email)" +
					"VALUES(@name,@email)";

				await _db.SaveDate(query, new { name = person.name, email = person.email });
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public async Task<bool> DeletePerson(int id)
		{
			try
			{
				string query = "DELETE FROM Person " +
					"WHERE id = @ID";

				await _db.SaveDate(query, new {ID = id});
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public async Task<IEnumerable<Person>> GetPeople()
		{
			string query = "SELECT * FROM Person";

			var people =  await _db.GetData<Person, dynamic>(query, new { });
			return people;
		}

		public async Task<Person> GetPersonById(int id)
		{
			string query = "SELECT * FROM Person" +
				"WHERE id = @ID";

			var person = await _db.GetData<Person, dynamic>(query, new {ID = id });

			return person.FirstOrDefault();
		}

		public async Task<bool> UpdatePerson(Person person)
		{
			try
			{
				string query = "UPDATE Person " +
					"SET name = @Name, email = @Email" +
					"WHERE id = @ID";

				await _db.SaveDate(query, person);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
