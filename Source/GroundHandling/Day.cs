using System;

namespace GroundHandling
{
	public class Day
	{
		public Day ()
		{
            public List<Team> teams { get; set; }
            public List<Flight> flights { get; set; }
            public DateTime day { get; set; }
		}

		public Flight AddFlight(){}

		public Flight RemoveFlight(){}

		public Team AddTeam(){}

		public Team RemoveTeam(){}


	}
}

