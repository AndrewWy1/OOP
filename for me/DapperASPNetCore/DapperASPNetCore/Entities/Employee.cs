using System.ComponentModel.DataAnnotations;

namespace DapperASPNetCore.Entities
{
	public class Employee
	{
		public int id { get; set; }
		public string name { get; set; }
		public int age { get; set; }
		public string position { get; set; }
		public int companyId { get; set; }
	}
}
