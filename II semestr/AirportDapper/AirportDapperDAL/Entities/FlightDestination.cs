using AirportDapperDAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirportDapperDAL.Entities
{
	internal class FlightDestination : IEntity
	{
		public int id { get; set; }
		public int airport_id { get; set; }
		public DateTime start { get; set; }
		public int aircraft_id { get; set; }
		public int passenger_id { get; set; }
		public double ticket_price { get; set; }

		public FlightDestination(int id, int airport_id, DateTime start, int aircraft_id, int passenger_id, double ticket_price)
		{
			this.id = id;
			this.airport_id = airport_id;
			this.start = start;
			this.aircraft_id = aircraft_id;
			this.passenger_id = passenger_id;
			this.ticket_price = ticket_price;
		}
	}
}