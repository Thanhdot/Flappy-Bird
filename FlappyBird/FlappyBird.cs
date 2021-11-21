using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlappyBird
{ 
    public partial class FlappyBird : Form
    {
        int pipeSpeed = 5;
        int gravity = 5;
        int score = 0;

        public FlappyBird()
        { 
            InitializeComponent();
           // InitializeGrid();
        }
        private void GameTimeEvent(object sender, EventArgs e)
        {
            
            Bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            textScore.Text = "Score: " + score;

            if (pipeBottom.Left < -50)
            {
                pipeBottom.Left = 400;
                score++;
            }
            if (pipeTop.Left < -80)
            {
                pipeTop.Left = 550;
                score++;
            }

            if (Bird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                Bird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                Bird.Bounds.IntersectsWith(Ground.Bounds) || Bird.Top < -25
                )
            {
                EndGame();
            }

            if (score > 5)
            {
                pipeSpeed = 8;
            }
        }

        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -5;
            }
        }

        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }
        public class luunumberscore
        {
            static public string num; 
        }
        private void EndGame()
        {
            GameTimer.Stop();
            luunumberscore.num = score.ToString();
            playorquit play1 = new playorquit();
            
            play1.Show();
            this.Hide();
        }
    }
}
