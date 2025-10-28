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
        public void Grow()
        {
            Point tail = Body[Body.Count - 1];
            Body.Add(new Point(tail.X, tail.Y));
        }
        public void ChangeDirection(int x, int y)
        {
            DirX = x;
            DirY = y;
        }
        public bool IsCollision(int width, int height)
        {
            Point head = Body[0];
            if(head.X < 0 || head.Y < 0 || head.X >= width || head.Y >= height)
            {
                return true;
            }
            for(int i = 1; i < Body.Count; i++)
            {
                if ((Body[i] == head))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
