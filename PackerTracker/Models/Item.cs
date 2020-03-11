using System.Collections.Generic;

namespace Packer.Models
{
    public class Tracker
    {
        public string TripType { get; set; } // type of trip (backpacking, skiing, etc.)
        public string Gear { get; set; }
        public string Destination { get; set; }
        public string Directions { get; set; }
        public int Id { get; }

        private static List<Tracker> _instances = new List<Tracker> {};

        public Tracker(string tripType, string gear, string destination, string directions)
        {
            TripType = tripType;
            Gear = gear;
            Destination = destination;
            Directions = directions;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Tracker> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Tracker Find(int searchId)
        {
            return _instances[searchId-1];
        }
    }
}