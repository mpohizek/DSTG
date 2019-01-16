using System;
using UnityEngine;

namespace Zadatak_4___A_star
{

    public enum CellState { Untested, Open, Closed }
    class Cell
    {
        public Vector2 Location { get; set; }
        public Char Character { get; set; }

        //true ako je zid
        public bool Wall { get; set; }
        public bool Start { get; set; }
        public CellState State { get; set; }
        public bool IsWalkable { get; set; }

        public Cell Parent { get; set; }

        //distance from the start cell to this cell
        public double GStartToThis { get; set; }
        //straight line distance from this cell to the end cell 
        public double HeuristicThisToEnd { get; set; }
        //TotalDistance = StartToThis + ThisToEnd
        public double FTotalDistance { get; set; }

        public Cell()
        {

        }
        public Cell(int y, int x, bool wall)
        {
            Location = new Vector2(x, y);
            
            State = CellState.Untested;
            Wall = wall;
            HeuristicThisToEnd = -1;
        }

        public void Init(int y, int x, bool wall)
        {
            Location = new Vector2(x, y);

            State = CellState.Untested;
            Wall = wall;
            HeuristicThisToEnd = -1;
        }
        
        //public double CalcThisToEnd(Cell end)
        //{
        //    this.HeuristicThisToEnd = Maze.CalcDist(this, end);
        //    return this.HeuristicThisToEnd;
        //}
    }
}
