using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railway.Model
{
    public class Station
    {
        public string Name { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public Path PathToNextStation { get; set; }
        public Path PathToPreviousStation { get; set; }

        public Station()  { }

        public Station(string name, double longitude, double latitude, Path pathToNextStation, Path pathToPreviousStation)
        {
            Name = name;
            Longitude = longitude;
            Latitude = latitude;
            PathToNextStation = pathToNextStation;
            PathToPreviousStation = pathToPreviousStation;
        }

        public override string ToString()
        {
            return "Name: " + Name;
        }

        public Station(string name, double longitude, double latitude)
        {
            Name = name;
            Longitude = longitude;
            Latitude = latitude;
        }
    }
}
