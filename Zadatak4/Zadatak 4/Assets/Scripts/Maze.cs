using System;
using System.Collections.Generic;
using System.Linq;

namespace Zadatak_4___A_star
{
    class Maze
    {
        public static int XSize { get; set; }
        public static int YSize { get; set; }

        public static Cell Start { get; set; }
        public static Cell End { get; set; }

        public static List<Cell> Open { get; set; }
        public static List<Cell> Closed { get; set; }

        public static Cell[,] M { get; set; }

        public Maze(int x, int y)
        {
            XSize = x;
            YSize = y;

            M = new Cell[x, y];
            Open = new List<Cell>();
            Closed = new List<Cell>();
        }

        //generate q's 8 successors and set their parents to q
        public static List<Cell> FindAdjacentWalkableCells(Cell fromCell)
        {
            List<Cell> adj = FindAdjacentCells(fromCell);
            List<Cell> walkable = new List<Cell>();

            foreach (Cell c in adj)
            {
                if (c.Wall == true)
                {
                    continue;
                }
                
                // If it's untested, set the parent and flag it as 'Open' for consideration
                if(c.State == CellState.Untested)
                {
                    c.Parent = fromCell;
                    c.State = CellState.Open;
                }
                walkable.Add(c);
            }

            return walkable;
        }

        public static List<Cell> FindAdjacentCells(Cell c)
        {
            List<Cell> cells = new List<Cell>();
            if (IsValidCell(c.Location.x, c.Location.y - 1f))
                cells.Add(M[(int)c.Location.x, (int)c.Location.y - 1]);
            if (IsValidCell(c.Location.x, c.Location.y + 1))
                cells.Add(M[(int)c.Location.x, (int)c.Location.y + 1]);
            if (IsValidCell(c.Location.x - 1, c.Location.y))
                cells.Add(M[(int)c.Location.x - 1, (int)c.Location.y]);
            if (IsValidCell(c.Location.x + 1, c.Location.y))
                cells.Add(M[(int)c.Location.x + 1, (int)c.Location.y]);

            //diagonals
            if (IsValidCell(c.Location.x + 1, c.Location.y + 1))
                cells.Add(M[(int)c.Location.x + 1, (int)c.Location.y + 1]);
            if (IsValidCell((int)c.Location.x + 1, c.Location.y - 1))
                cells.Add(M[(int)c.Location.x + 1, (int)c.Location.y - 1]);
            if (IsValidCell(c.Location.x - 1, c.Location.y + 1))
                cells.Add(M[(int)c.Location.x - 1, (int)c.Location.y + 1]);
            if (IsValidCell(c.Location.x - 1, c.Location.y - 1))
                cells.Add(M[(int)c.Location.x - 1, (int)c.Location.y - 1]);


            return cells;
        }

        public static bool IsValidCell(float xx, float yy)
        {
            int x = (int)xx;
            int y = (int)yy;

            bool valid = true;
            if (x < 0)
                valid = false;
            else if (x >= XSize)
                valid = false;
            else if (y < 0)
                valid = false;
            else if (y >= YSize)
                valid = false;
            return valid;
        }

        public bool Search()
        {
            Start.FTotalDistance = CalcDist(Start, End);
            while (Open.Count > 0)
            {
                //find the node with the least f on the open list, call it "q"
                CalculateGForOpen();
                CalculateTotalDistanceForOpen();
                Open.Sort((cell1, cell2) => cell1.FTotalDistance.CompareTo(cell2.FTotalDistance));
                Cell q = Open.First();
                //pop q off the open list
                Open.Remove(q);
                // generate q's 8 successors and set their parents to q
                List<Cell> walkable = FindAdjacentWalkableCells(q);
                //for each successor
                foreach (Cell c in walkable)
                {
                    //if successor is the goal, stop search
                    if (c.Location == End.Location)
                        return true;
                    Cell openCell = Open.FirstOrDefault(cell => 
                    (int)cell.Location.x == (int)c.Location.x && (int)cell.Location.y == (int)c.Location.y);
                    Cell succ = new Cell((int)c.Location.y, (int)c.Location.x, c.Wall);
                    succ.GStartToThis = q.GStartToThis + CalcDist(succ, q);
                    succ.HeuristicThisToEnd = c.HeuristicThisToEnd;
                    succ.FTotalDistance = succ.GStartToThis + succ.HeuristicThisToEnd;

                    /*if a node with the same position as 
                        successor is in the OPEN list which has a 
                        lower f than successor, skip this successor
                        */
                    if (openCell != null && openCell.FTotalDistance < succ.FTotalDistance)
                        continue;

                    /*if a node with the same position as
                        successor is in the CLOSED list which has
                       a lower f than successor, skip this successor
                       otherwise, add  the node to the open list*/
                    Cell closedCell = Closed.FirstOrDefault(cell =>
                    (int)cell.Location.x == (int)c.Location.x && (int)cell.Location.y == (int)c.Location.y);
                    if (closedCell != null && closedCell.FTotalDistance < succ.FTotalDistance)
                        continue;
                    else
                    {
                        c.GStartToThis = q.GStartToThis + CalcDist(c, q);
                        c.HeuristicThisToEnd = c.HeuristicThisToEnd;
                        c.FTotalDistance = c.GStartToThis + c.HeuristicThisToEnd;

                        if (openCell == null && closedCell == null)
                        {
                            Open.Add(c);
                            c.State = CellState.Open;
                        }
                    }
                }
                //push q on the closed list
                Closed.Add(q);
                q.State = CellState.Closed;
            }
            return false;
        }

        private void CalculateTotalDistanceForOpen()
        {
            foreach(Cell c in Open)
            {
                c.FTotalDistance = c.GStartToThis + c.HeuristicThisToEnd;
            }
        }

        private void CalculateGForOpen()
        {
            foreach (Cell c in Open)
            {
                if (c.Parent != null)
                    c.GStartToThis = c.Parent.GStartToThis + CalcDist(c,c.Parent);
                else
                    c.GStartToThis = 0; //this is the starting cell
            }
        }

        public void LoadMazeFromFile(string filePath)
        {
            int y = 0;
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath);
            line = file.ReadLine();
            while ((line = file.ReadLine()) != null)
            {
                int x = 0;
                foreach (char c in line)
                {
                    if (c.Equals('+'))
                    {
                        M[x, y] = new Cell(y, x, true);
                        M[x, y].Character = '#';
                    }
                    else
                    {
                        M[x, y] = new Cell(y, x, false);
                        M[x, y].Character = ' ';
                        if (c.Equals('S'))
                        {
                            M[x, y].Start = true;
                            Start = M[x, y];
                            Open.Add(M[x, y]);
                            Start.State = CellState.Open;
                            Start.GStartToThis = 0;
                            M[x, y].Character = 'S';
                        }else if (c.Equals('E'))
                        {
                            End = M[x, y];
                            M[x, y].Character = 'E';
                        }
                    }
                    x++;
                }

                y++;
            }

            file.Close();
            
            CalculateHeuristicForMaze();
        }

        private void CalculateHeuristicForMaze()
        {
            foreach (Cell c in M)
            {
                c.HeuristicThisToEnd = CalcDist(c, End);
            }
        }

        //Manhattan Distance - Calculates distance from this to the other cell
        public static double CalcDist(Cell c1, Cell c2)
        {
            int x = Math.Max((int)c2.Location.y, (int)c1.Location.y) - Math.Min((int)c2.Location.y, (int)c1.Location.y);
            int y = Math.Max((int)c2.Location.x, (int)c1.Location.x) - Math.Min((int)c2.Location.x, (int)c1.Location.x);

            double distance = x + y;

            return distance;
        }
    }
}
