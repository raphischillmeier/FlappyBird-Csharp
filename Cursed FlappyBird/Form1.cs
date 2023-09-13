using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursed_FlappyBird
{
    public partial class pipeDownOne : Form
    {
        
        public pipeDownOne()
        {
            InitializeComponent();
        }

        int playerSpeed = 7;
        int playerScore = 0;
        int gravity = 5; 

        private void label1_Click(object sender, EventArgs e)
        {
               
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            flappy.Top += gravity;
            pipeUpOne.Left -= playerSpeed;
            pipeUpTwo.Left -= playerSpeed;
            pipeUpThree.Left -= playerSpeed;
            dipeDownOne.Left -= playerSpeed;
            pipeDownTwo.Left -= playerSpeed;
            pipeDownThree.Left -= playerSpeed;

            if(dipeDownOne.Left < -25)
            {
                playerScore++;
                dipeDownOne.Left = 550;
            }
            if (pipeDownTwo.Left < -25)
            {
                playerScore++;
                pipeDownTwo.Left = 550;
            }
            if (pipeDownThree.Left < -25)
            {
                playerScore++;
                pipeDownThree.Left = 550;
            }
            if (pipeUpOne.Left < -25)
            {
                playerScore++;
                pipeUpOne.Left = 550;
            }
            if (pipeUpTwo.Left < -25)
            {
                playerScore++;
                pipeUpTwo.Left = 550;
            }
            if (pipeUpThree.Left < -25)
            {
                playerScore++;
                pipeUpThree.Left = 550;
            }


            if(flappy.Top < 25 || flappy.Bounds.IntersectsWith(dipeDownOne.Bounds) || flappy.Bounds.IntersectsWith(pipeDownTwo.Bounds) || flappy.Bounds.IntersectsWith(pipeDownThree.Bounds) || flappy.Bounds.IntersectsWith(pipeUpOne.Bounds) || flappy.Bounds.IntersectsWith(pipeUpTwo.Bounds) || flappy.Bounds.IntersectsWith(pipeUpThree .Bounds))
            {
                gameOver();
                gameTimer.Stop();
            }
        }

        private void click(object sender, MouseEventArgs e)
        {
            
        }

        private void keyDownEvent(object sender, KeyEventArgs keyEventArgs)
        {
            if (keyEventArgs.KeyCode == Keys.Space)
            {
                gravity = -6;
            }
        }

        private void keyUpEvent(object sender, KeyEventArgs keyEventArgs)
        {
            if(keyEventArgs.KeyCode == Keys.Space){
                gravity = +6 ;
            }
        }
        private void gameOver()
        {
            
            gameOverText.Visible = true;
            scoreText.Visible = true;
            restart.Visible = true;
            scoreText.Text = "Score: " + playerScore;
        }

        private void restart_Click(object sender, EventArgs e)
        {
            
        }

        private void restart_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void keyDownEventRestart(object sender, EventArgs e)
        {

        }

        private void keyPress(object sender, KeyPressEventArgs e)
        {
             
        }
    }
}
