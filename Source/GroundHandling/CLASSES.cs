using System;
using System.Collections.Generic;

namespace GroundHandlingClasses
{
	public class Day
	{
        public List<Team> teams { get; set; }
        public List<Flight> flights { get; set; }
        public DateTime day { get; set; }
		/*public Day ()
		{
            
		}

		public Flight AddFlight(){}

		public Flight RemoveFlight(){}

		public Team AddTeam(){}

		public Team RemoveTeam(){}*/


	}

    public class Task
	{
        public int id { get; set; }
        public string type { get; set; }
        public double timeReq { get; set { timeReq = value + team.timeToReady; } } //in minutes
        public DateTime estFinished { get; set { estFinished = flight.eta.AddMinutes(timeReq); } }
        public string skillReq { get; set; }
        public int priority { get; set; }
        public bool done { get; set; }
        public Team team 
        { 
            get { return team; } 
            set 
            { 
                team = value;
                team.tasks.Add(this);
            } 
        }
        public Flight flight 
        { 
            get { return flight; } 
            set 
            { 
                flight = value;
                flight.tasks.Add(this);
            } 
        }
        
		
        /*public Task ()
		{
            
		}

		public int Delay(){
		}

		public int Done(){}

		public int AssignTeam(){}*/
	}
    
	public class Skill
	{
        bool cleaning { get; set; }
        bool fueling { get; set; }
        bool luggage { get; set; }
		/*public Skill ()
		{
            
		}*/
	}

    public class Flight
	{
        private static List<bool> idCounter = new List<bool>();
        public int id { get; set; }
        public DateTime eta { get; set; }
        public int estGHTime { get; set; }
        public int timeToTO { get; set; }
        public List<Task> tasks { get; set; }
        public int delay { get { return delay; } set { delay = Convert.ToInt32(eta) + estGHTime - timeToTO; } }

        public Flight() 
        {
            int nextID = getAvailableID();
            if (nextID == -1)
            {
                id = idCounter.Count;
                idCounter.Add(true);
            }
        }
        public Flight(DateTime _eta) : this()
            {eta=_eta;}
        public Flight(DateTime _eta, int _estGHTime) : this(_eta)
            {estGHTime=_estGHTime;}
        public Flight(DateTime _eta, int _estGHTime, int _timeToTO) : this(_eta, _estGHTime)
            {timeToTO=_timeToTO;}

        private int getAvailableID()
        {
            for (int i = 0; i < idCounter.Count; i++)
            {
                if (idCounter[i] == false)
                    return i;
            }
            return -1;
        }
    }

    public class Team
    {
        private static List<bool> idCounter = new List<bool>();
        public int id { get; set; }
        public double timeToReady { get; set; } //in minutes NOTE: SKAL LAVES SMART GET, SÅ DU GET'ER I FORHOLD TIL DEN TID TASKEN _KAN_ PÅBEGYNDES
        public List<Task> tasks { get; set; }
		public Skill skills;

        public Team()
        {
            int nextID = getAvailableID();
            if (nextID == -1)
            {
                id = idCounter.Count;
                idCounter.Add(true);
            }
        }
        public Team(int _timeToReady) : this()
            { timeToReady = _timeToReady; }

        private int getAvailableID()
        {
            for (int i = 0; i < idCounter.Count; i++)
            {
                if (idCounter[i] == false)
                    return i;
            }
            return -1;
        }
    }
}
