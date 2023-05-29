using CodeFirst.Models.Repository;
using System.Linq;

namespace CodeFirst.Models.DataManager
{
	public class EmployeeManager : IDataRepository<Employee>
	{
		readonly EmployeeContext _employeeContext;

		public EmployeeManager(EmployeeContext context)
		{
			_employeeContext = context;
		}

		public IEnumerable<Employee> GetAll()
		{
			return _employeeContext.Employees.ToList();
		}

		public Employee Get(long Id)
		{
			return _employeeContext.Employees
				.FirstOrDefault(e => e.EmployeeId == Id);
		}

		public void Add(Employee entity)
		{
			_employeeContext.Employees.Add(entity);
			_employeeContext.SaveChanges();
		}

		public void Update(Employee entity, Employee newEntity)
		{
			entity.FirstName= newEntity.FirstName;
			entity.LastName= newEntity.LastName;
			entity.DateOfBirth= newEntity.DateOfBirth;
			entity.Email= newEntity.Email;
			entity.PhoneNumber= newEntity.PhoneNumber;

			_employeeContext.SaveChanges();
		}
		public void Delete(Employee entity)
		{
			_employeeContext.Employees.Remove(entity);
			_employeeContext.SaveChanges();
		}
	}
}
