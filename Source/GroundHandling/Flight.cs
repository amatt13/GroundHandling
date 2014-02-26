using System;

namespace GroundHandling
{
	public class Flight
	{
        private static List<bool> idCounter = new List<bool>();
        public int id { get; set; }
        public DateTime eta { get; set; }
        public int estGHTime { get; set; }
        public int timeToTO { get; set; }
        public List<Task> tasks { get; set; }
        public int teamID { get; set; }
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
        public Flight(DateTime _eta, int _estGHTime, int _timeToTO, int _teamID) : this(_eta, _estGHTime, _timeToTO)
            {teamID=_teamID;}



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

