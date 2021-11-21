using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Start1 : Form
    {
        public Start1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            FlappyBird start = new FlappyBird();
            this.Hide();
            start.Show();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
