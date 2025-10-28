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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            game.FormClosed += (s, args) => this.Show();
            this.Hide();
            game.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            this.Text = "SnakeGame - GFS Software ";
            this.BackColor = Color.Black;
        }
    }
}
