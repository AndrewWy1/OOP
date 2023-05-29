using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models
{
	public class EmployeeContext : DbContext
	{
		public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) 
		{ }

		public DbSet<Employee> Employees { get; set;}


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Employee>().HasData(new Employee
			{
				EmployeeId = 1,
				FirstName = "Uncle",
				LastName = "Bob",
				Email = "uncle.bob@gmail.com",
				DateOfBirth = new DateTime(1979, 04, 25),
				PhoneNumber = "999-888-7777"
			}, new Employee
			{
				EmployeeId = 2,
				FirstName = "Jan",
				LastName = "Kirsten",
				Email = "jan.kricten@gmail.com",
				DateOfBirth = new DateTime(1981, 04, 25),
				PhoneNumber = "111-222-3333"
			});
		}
	}
}
