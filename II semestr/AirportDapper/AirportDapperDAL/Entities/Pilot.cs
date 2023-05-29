using AirportDapperDAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDapperDAL.Entities
{
	internal class Pilot : IEntity
	{
		public int id { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set;}
		public int age { get; set; }
		public double? rating { get; set; }

		public Pilot(int id, string first_name, string last_name, int age, double? rating)
		{
			this.id = id;
			this.first_name = first_name;
			this.last_name = last_name;
			this.age = age;
			this.rating = rating;
		}
	}
}
