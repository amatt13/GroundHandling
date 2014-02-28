using System;

namespace GroundHandling
{
	public class Team
    {
        private static List<bool> idCounter = new List<bool>();
        //private bool updatingID;
        public int id { get; set; }
        public int timeToReady { get; set; }
        public List<Task> tasks { get; set; }
        public int flightID { get; set; }
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
        public Team(int _timeToReady)
            : this()
        { timeToReady = _timeToReady; }
        public Team(int _timeToReady, int _flightID)
            : this(_timeToReady)
        { flightID = _flightID; }

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

