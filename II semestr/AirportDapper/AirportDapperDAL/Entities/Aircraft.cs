using AirportDapperDAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDapperDAL.Entities
{
	internal class Aircraft : IEntity
	{
		public int id { get; set; }
		public string manufacture { get; set; }
		public string model { get; set; }
		public int year { get; set; }
		public int? flight_hours { get; set; }
		public char condition { get; set; }
		public int aircraft_type_id { get; set; }
		
		public Aircraft(int id, string manufacture, string model, int year, int? flight_hours, char condition, int aircraft_type_id)
		{
			this.id = id;
			this.manufacture = manufacture;
			this.model = model;
			this.year = year;
			this.flight_hours= flight_hours;
			this.condition = condition;
			this.aircraft_type_id = aircraft_type_id;
		}
	}
}
