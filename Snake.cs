using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Snake
    {
        public List<Point> Body;
        public int DirX;
        public int DirY;

        public Snake(int startX, int startY)
        {
            Body = new List<Point>();
            Body.Add(new Point(startX, startY));
            DirX = 1;
            DirY = 0;
        }
        public void Move()
        {
            Point abc = new Point(Body[0].X + DirX, Body[0].Y + DirY);
            Body.Insert(0, abc);
            Body.RemoveAt(Body.Count - 1);
        }
        void Grow()
        {

        }
        void ChangeDirection()
        {
        }
        void IsCollision()
        {
        }
    }
}
