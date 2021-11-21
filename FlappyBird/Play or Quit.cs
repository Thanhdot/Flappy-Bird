using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class playorquit : Form
    {
        public playorquit()
        {
            InitializeComponent();
        }

        private void playagain_Click(object sender, EventArgs e)
        {
            FlappyBird play = new FlappyBird();
            this.Hide();
            play.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playorquit_Load(object sender, EventArgs e)
        {
            textBox1.Text = FlappyBird.luunumberscore.num;
        }
    }
}
