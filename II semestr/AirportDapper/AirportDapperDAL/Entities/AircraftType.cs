using AirportDapperDAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDapperDAL.Entities
{
	internal class AircraftType : IEntity
	{
		public int id { get; set; }
		public string type_name { get; set; }

		public AircraftType(int id, string type_name)
		{
			this.id = id;
			this.type_name = type_name;
		}
	}
}
