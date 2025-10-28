using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    internal class Food
    {
        public Point Pos;
        public int Value;
        public Brush Color;
        public Food(int x, int y, int value, Brush color)
        {
            Pos = new Point(x, y);
            Value = value;
            Color = color;
        }
    }
}
