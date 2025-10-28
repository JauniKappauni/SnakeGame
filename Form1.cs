using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        Snake snake = new Snake(5, 5);
        Random random = new Random();
        List<Food> foods = new List<Food>();
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "SnakeGame - GFS Software ";
            this.BackColor = Color.Black;

            timer1.Interval = 100;
            timer1.Start();
            this.KeyDown += Form1_KeyDown;
            this.KeyPreview = true;
            foods = new List<Food>()
{
            new Food(0, 0, 1, Brushes.Red),
            new Food(0, 0, 2, Brushes.Green),
            new Food(0, 0, 3, Brushes.Blue),
            new Food(0, 0, 4, Brushes.White)
};
            foreach (var f in foods)
                SpawnFood(f);
            label1.Text = "Score: 0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            snake.Move();
            foreach (var f in foods)
            {
                if (snake.Body[0] == f.Pos)
                {
                    snake.Grow();
                    SpawnFood(f);
                    score += f.Value;
                    label1.Text = "Score: " + score;
                }
            }
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            Brush brush = Brushes.Lime;
            foreach (Point p in snake.Body)
            {
                g.FillRectangle(brush, p.X * 20, p.Y * 20, 20, 20);
            }
            foreach (var f in foods)
            {
                g.FillRectangle(f.Color, f.Pos.X * 20, f.Pos.Y * 20, 20, 20);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    snake.ChangeDirection(0, -1);
                    break;
                case Keys.S:
                    snake.ChangeDirection(0, 1);
                    break;
                case Keys.A:
                    snake.ChangeDirection(-1, 0);
                    break;
                case Keys.D:
                    snake.ChangeDirection(1, 0);
                    break;
            }
        }

        private void SpawnFood(Food f)
        {
            int x, y;
            x = random.Next(0, 20);
            y = random.Next(0, 20);
            f.Pos = new Point(x, y);
        }
    }
}
