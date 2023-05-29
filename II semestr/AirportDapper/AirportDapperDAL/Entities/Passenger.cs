using AirportDapperDAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDapperDAL.Entities
{
	internal class Passenger : IEntity
	{
		public int id { get; set; }
		public string full_name { get; set; }
		public string email { get; set; }

		public Passenger(int id, string full_name, string email)
		{
			this.id = id;
			this.full_name = full_name;
			this.email = email;
		}
	}
}
