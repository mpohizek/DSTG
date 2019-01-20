using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Connection
    {
        public int Distance { get; set; }
        public Road Road { get; set; }

        public Connection(string name, int distance)
        {
            Distance = distance;
            Road = new Road(name);
        }
        public Connection(Road road, int distance)
        {
            Distance = distance;
            Road = road;
        }
    }

    class Road
    {
        public string Name { get; set; }

        //popis cesta kojima ima pristup
        public List<Connection> ConnectingRoads { get; set; }
        //parking sekcija kojoj ima pristup
        public ParkingSection PSection { get; set; }


        public Road Parent { get; set; }
        public bool Final { get; set; }
        //Privremena oznaka = -1
        public static readonly int NULL_MARKING = -1;
        public int Marking { get; set; }

        public Road()
        {
        }
        public Road(string name)
        {
            Name = name;
            ConnectingRoads = new List<Connection>();
        }

        public Road(string name, int marking, bool final)
        {
            Final = final;
            Name = name;
            Marking = marking;
        }
    }
}
