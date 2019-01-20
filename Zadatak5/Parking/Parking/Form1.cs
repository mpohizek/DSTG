using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class Form1 : Form
    {
        private List<Road> AllRoads { get; set; }
        private List<ParkingSection> AllPSections { get; set; }
        private List<ParkingSection> FreePSpacesSections { get; set; }
        private Road Start { get; set; }
        private Road Be1 { get; set; }
        private Road Be2 { get; set; }
        private Road Be3 { get; set; }
        private Road Be4 { get; set; }

        public Form1()
        {
            InitializeComponent();
            AllRoads = new List<Road>();
            AllPSections = new List<ParkingSection>();
            FreePSpacesSections = new List<ParkingSection>();
            //road and segments initialisation
            InitRoadsAndSegments();

            CalcDistToAllRoads(Start);
        }

        private List<Road> ShortestDistance(List<Road> shortestDist)
        {
            Road temp;
            foreach (Road road in AllRoads)
            {
                temp = shortestDist.Find(x => x.Name.ToLower().Equals(road.Name.ToLower()));
                if (temp != null)
                {
                    if (temp.Marking > road.Marking)
                    {
                        temp.Marking = road.Marking;
                    }
                }
                else
                {
                    shortestDist.Add(temp);
                }
            }
            return shortestDist;
        }
        private void btnPronadiMjesto_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //tražimo sektor s najbližim parkirnim mjestom
            ParkingSection closestSection = FindClosestSection();

            if (closestSection == null)
                return;
            CalcDistToAllRoads(Start);


            Road temp = closestSection.FromRoad;
            if (closestSection.Downward)
            {
                lblUdaljenostDoMjesta.Text = temp.Marking + closestSection.FreeSpots.Min()*2 + " m";
            }
            else
            {
                lblUdaljenostDoMjesta.Text = temp.Marking + 
                    (closestSection.MaxParkingSpots - closestSection.FreeSpots.Min()+ 1)*2 + " m";
            }

            textBox1.AppendText(temp.Name + " " + temp.Marking);
            textBox1.AppendText(Environment.NewLine);
            while (temp.Parent != null)
            {
                temp = temp.Parent;
                textBox1.AppendText(temp.Name + " " + temp.Marking);
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private ParkingSection FindClosestSection()
        {
            FreePSpacesSections = FreePSpacesSections.OrderBy(x => x.ClosestDistToStore +
                x.FreeSpots.Min() * 2).ToList();
            if (FreePSpacesSections.Count > 0)
                return FreePSpacesSections[0];
            else
                return null;
        }

        private void CalcDistToAllRoads(Road start)
        {
            List<Road> Visited = new List<Road>();
            List<Road> WithTempMarkings = new List<Road>();
            foreach (Road road in AllRoads)
            {
                road.Marking = Road.NULL_MARKING;
                road.Parent = null;
                road.Final = false;
            }

            Road current = start;
            current.Marking = 0;
            WithTempMarkings.Add(current);
            
            while (WithTempMarkings.Count > 0)
            {
                current.Final = true;
                Visited.Add(current);
                WithTempMarkings.RemoveAt(0);


                foreach (Connection connecting in current.ConnectingRoads)
                {
                    //sve susjedne ceste s privremenom oznakom
                    if(connecting.Road.Marking == Road.NULL_MARKING)
                    {
                        connecting.Road.Marking = current.Marking + connecting.Distance;
                        WithTempMarkings.Add(connecting.Road);
                        if (current.ConnectingRoads.Contains(connecting)) 
                            connecting.Road.Parent = current;
                    }
                    else
                    {
                        if(current.Marking + connecting.Distance < connecting.Road.Marking)
                        {
                            connecting.Road.Marking = current.Marking + connecting.Distance;
                            if (current.ConnectingRoads.Contains(connecting))
                                connecting.Road.Parent = current;
                        }
                    }
                }
                WithTempMarkings = WithTempMarkings.OrderBy(x => x.Marking).ToList();
                if(WithTempMarkings.Count > 0)
                {
                    Road temp = WithTempMarkings[0];
                    current = temp;
                }
            }

        }
        

        private void InitRoadsAndSegments()
        {
            //Roads
            //A
            Road a1 = new Road("A1");
            Start = a1;
            AllRoads.Add(Start);

            Road a2 = new Road("A2");
            AllRoads.Add(a2);
            Road a3 = new Road("A3");
            AllRoads.Add(a3);
            Road a4 = new Road("A4");
            AllRoads.Add(a4);
            //P
            Road p1 = new Road("P1");
            AllRoads.Add(p1);
            Road p2 = new Road("P2");
            AllRoads.Add(p2);
            Road p3 = new Road("P3");
            AllRoads.Add(p3);
            Road p4 = new Road("P4");
            AllRoads.Add(p4);

            //L
            Road l1 = new Road("L1");
            AllRoads.Add(l1);
            Road l2 = new Road("L2");
            AllRoads.Add(l2);
            Road l3 = new Road("L3");
            AllRoads.Add(l3);
            Road l4 = new Road("L4");
            AllRoads.Add(l4);

            //B
            Road b1 = new Road("B1");
            AllRoads.Add(b1);
            Be1 = b1;
            Road b2 = new Road("B2");
            AllRoads.Add(b2);
            Be2 = b2;
            Road b3 = new Road("B3");
            AllRoads.Add(b3);
            Be3 = b3;
            Road b4 = new Road("B4");
            AllRoads.Add(b4);
            Be4 = b4;

            //CONNECTIONS
            //A
            a1.ConnectingRoads.Add(new Connection(p1, 15));
            a1.ConnectingRoads.Add(new Connection(a2, 10));


            a2.ConnectingRoads.Add(new Connection(a1,10));
            a2.ConnectingRoads.Add(new Connection(a3,10));

            a3.ConnectingRoads.Add(new Connection(a2,10));
            a3.ConnectingRoads.Add(new Connection(p3,15));
            a3.ConnectingRoads.Add(new Connection(a4,10));

            a4.ConnectingRoads.Add(new Connection(a3,10));

            //P
            p1.ConnectingRoads.Add(new Connection(l1,30));
            p1.ConnectingRoads.Add(new Connection(p2,10));

            p2.ConnectingRoads.Add(new Connection(p3,10));
            p2.ConnectingRoads.Add(new Connection(a2,15));

            p3.ConnectingRoads.Add(new Connection(l3,30));
            p3.ConnectingRoads.Add(new Connection(p4,10));

            p4.ConnectingRoads.Add(new Connection(a4,15));

            //L
            l1.ConnectingRoads.Add(new Connection(b1, 20));

            l2.ConnectingRoads.Add(new Connection(p2, 30));
            l2.ConnectingRoads.Add(new Connection(l1,10));

            l3.ConnectingRoads.Add(new Connection(l2, 10));
            l3.ConnectingRoads.Add(new Connection(b3, 20));

            l4.ConnectingRoads.Add(new Connection(p4, 30));
            l4.ConnectingRoads.Add(new Connection(l3, 10));

            //B
            b1.ConnectingRoads.Add(new Connection(b2, 10));

            b2.ConnectingRoads.Add(new Connection(b1, 10));
            b2.ConnectingRoads.Add(new Connection(l2, 20));
            b2.ConnectingRoads.Add(new Connection(b3, 10));

            b3.ConnectingRoads.Add(new Connection(b2, 10));
            b3.ConnectingRoads.Add(new Connection(b4, 10));

            b4.ConnectingRoads.Add(new Connection(b3, 10));
            b4.ConnectingRoads.Add(new Connection(l4, 20));


            //SECTIONS
            //C
            ParkingSection temp = new ParkingSection("C1", false, 10, l1, b1);
            AllPSections.Add(temp);
            l1.PSection = temp;
            temp.FromRoad = l1;
            temp.ToRoad = b1;
            temp.ClosestDistToStore = 0;
            temp = new ParkingSection("C2", false, 16, p1, l1);
            AllPSections.Add(temp);
            temp.FromRoad = p1;
            p1.PSection = temp;
            temp.ToRoad = l1;
            temp.ClosestDistToStore = 20;
            temp = new ParkingSection("C3", false, 7, a1, p1);
            AllPSections.Add(temp);
            a1.PSection = temp;
            temp.FromRoad = a1;
            temp.ToRoad = p1;
            temp.ClosestDistToStore = 50;

            //D
            temp = new ParkingSection("D1", true, 10, l2, b2);
            AllPSections.Add(temp);
            b2.PSection = temp;
            temp.FromRoad = b3;
            temp.ToRoad = l2;
            temp.ClosestDistToStore = 0;
            temp = new ParkingSection("D2", true, 16, p2, l2);
            AllPSections.Add(temp);
            l2.PSection = temp;
            temp.FromRoad = l2;
            temp.ToRoad = p2;
            temp.ClosestDistToStore = 20;
            temp = new ParkingSection("D3", true, 7, a2, p2);
            AllPSections.Add(temp);
            p2.PSection = temp;
            temp.FromRoad = p2;
            temp.ToRoad = a2;
            temp.ClosestDistToStore = 50;

            //E
            temp = new ParkingSection("E1", false, 10, l3, b3);
            AllPSections.Add(temp);
            l3.PSection = temp;
            temp.FromRoad = l3;
            temp.ToRoad = b3;
            temp.ClosestDistToStore = 0;
            temp = new ParkingSection("E2", false, 16, p3, l3);
            AllPSections.Add(temp);
            p3.PSection = temp;
            temp.FromRoad = p3;
            temp.ToRoad = l3;
            temp.ClosestDistToStore = 20;
            temp = new ParkingSection("E3", false, 7, a3, p3);
            AllPSections.Add(temp);
            a3.PSection = temp;
            temp.FromRoad = a3;
            temp.ToRoad = p3;
            temp.ClosestDistToStore = 50;

            //F
            temp = new ParkingSection("F1", true, 10, l4, b4);
            AllPSections.Add(temp);
            b4.PSection = temp;
            temp.FromRoad = b4;
            temp.ToRoad = l4;
            temp.ClosestDistToStore = 0;
            temp = new ParkingSection("F2", true, 16, p4, l4);
            AllPSections.Add(temp);
            l4.PSection = temp;
            temp.FromRoad = l4;
            temp.ToRoad = p4;
            temp.ClosestDistToStore = 20;
            temp = new ParkingSection("F3", true, 7, a4, p4);
            AllPSections.Add(temp);
            p4.PSection = temp;
            temp.FromRoad = p4;
            temp.ToRoad = a4;
            temp.ClosestDistToStore = 50;


        }

        private void btnDodajPMjesto_Click(object sender, EventArgs e)
        {
            ParkingSection section = AllPSections.Find(x => x.Name.ToLower()
                .Equals(tbImeSekcije.Text.ToLower()));
            if (section == null)
            {
                tbImeSekcije.Text = "NOT FOUND";
                return;
            }
            int brojMjesta;
            if(!int.TryParse(tbBrojParkMjesta.Text, out brojMjesta))
            {
                tbBrojParkMjesta.Text = "Nije broj";
                return;
            }
            if (section.FreeSpots.Contains(brojMjesta))
            {
                tbBrojParkMjesta.Text = "Zauzeto";
                return;
            }
            if(brojMjesta > section.MaxParkingSpots)
            {
                tbBrojParkMjesta.Text = "<"+(section.MaxParkingSpots+1);
                return;
            }
            else if(brojMjesta < 1)
            {
                tbBrojParkMjesta.Text = ">0";
                return;
            }
            section.FreeSpots.Add(brojMjesta);
            if(!FreePSpacesSections.Contains(section))
                FreePSpacesSections.Add(section);
        }
    }
}
