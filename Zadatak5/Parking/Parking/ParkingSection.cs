using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    //Prema zadatku predstavlja sekcije parkirališta u kojima se nalaze parkirališna mjesta
    //(C1, D1, E1, ...)
    class ParkingSection
    {
        //true ako smjer putovanja kroz sekciju ide od shopping centra prema dolje
        public bool Downward { get; set; }
        public string Name { get; set; }
        public int MaxParkingSpots { get; set; }
        public List<int> FreeSpots { get; set; }
        public Road FromRoad { get; set; }
        public Road ToRoad { get; set; }
        public int ClosestDistToStore { get; set; }
        public int ClosestDistFromEntry { get; set; }

        public ParkingSection(string name, bool down, int maxpark, Road from, Road to)
        {
            FreeSpots = new List<int>();
            Name = name;
            Downward = down;
            MaxParkingSpots = maxpark;
            FromRoad = from;
            ToRoad = to;
        }
    }
}
