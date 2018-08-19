using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace My15_Puzzle.Models
{
    public class Position
    {
        public int X;
        public int Y;
        public string Name;

        public Position(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}