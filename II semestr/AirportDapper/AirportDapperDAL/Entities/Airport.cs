using AirportDapperDAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDapperDAL.Entities
{
	internal class Airport : IEntity
	{
		public int id { get; set; }
		public string airport_name { get; set; }
		public string country { get; set; }

		public Airport(int id, string airport_name, string country)
		{
			this.id = id;
			this.airport_name = airport_name;
			this.country = country;
		}
	}
}
