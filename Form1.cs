using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdGameFull
{
    public partial class Form1 : Form
    {
        bool spacePressed = false;
        bool scoreIncrement = false;
        bool pipeMovement = true;
        public int score = 0;
        public int gravity = 20;
        public int pipesMVT = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // will remain empty
        }

        private void Score_Click(object sender, EventArgs e)
        {
            // will remain empty
        }

        private void Ground_Click(object sender, EventArgs e)
        {
            // will remain empty
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

            BirdFly.Top += gravity;
            pipe1.Left -= pipesMVT;
            pipe2.Left -= pipesMVT;
            Score.Text = "Score: " + score;

            if ((pipe1.Right < 70 || pipe2.Right < 70) && !scoreIncrement)
            {
                scoreIncrement = true;
                score++;
            }
            Random rnd = new Random();  
            if (pipe1.Left <= -150)
            {
                pipe1.Left += 700 + rnd.Next(300);
                score++;
            }
            if (pipe2.Left <= -180)
            {
                pipe2.Left += 700 + rnd.Next(300);
                score++;
            }

            // now lets set some logical approach to when obstacles are encountred and our bird hits them
            if(BirdFly.Bounds.IntersectsWith(pipe1.Bounds) || BirdFly.Bounds.IntersectsWith(pipe2.Bounds) || BirdFly.Bounds.IntersectsWith(Ground.Bounds)
                || BirdFly.Top < -25)
            {
                // call the time to end function to terminate the current ongoing game
                timeToEnd();
            }

            if (score > 5) pipesMVT = 18;
        }

        private void timeToEnd()
        {
            gameTimer.Stop();
            Score.Text += " <<Game Over>>";

        }

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -20;
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 5;
        }
    }
}
