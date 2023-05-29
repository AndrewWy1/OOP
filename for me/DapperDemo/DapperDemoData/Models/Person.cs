using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemoData.Models
{
	public class Person
	{
		public int id { get; set; }

		[Required] //The parameter is mandatory
		public string name { get; set; }

		[Required]//The parameter is mandatory
		public string email { get; set; }
	}
}
