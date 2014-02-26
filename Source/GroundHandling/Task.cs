using System;

namespace GroundHandling
{
	public class Task
	{
		public Task ()
		{
            public string type { get; set; }
            public int timeReq { get; set; }
            public string skillReq { get; set; }
            public int priority { get; set; }
            public bool done { get; set; }
            public Team team { get; set; }
            public Flight flight { get; set; }
		}

		public int Delay(){
		}

		public int Done(){}

		public int AssignTeam(){}

	}
}

