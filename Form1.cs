using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{ 
    // this code was written by zineb oufqir , please don't change the code or delete it ...
    public partial class Form1 : Form
    {
        int pipeSpeed = 8; // default pipe speed defined with an integer
        int gravity = 15; // gravity represents the down mouvement of the bird 
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timerEvent(object sender, EventArgs e)
        {
            pictureBox1.Top += gravity;
            pictureBox2.Left -= pipeSpeed;
            pictureBox3.Left -= pipeSpeed;
            label1.Text = "Score :" + score;
            // below we are checking if the pipes have left the screen
            if (pictureBox3.Left < 150)
            {
                pictureBox3.Left = 800;
              
                score++;
            }
            if(pictureBox2.Left<180)
            {
                pictureBox2.Left = 950;
            }
                //the if statements cheks if the bird has hit the pipes or the player has left the screen from top
            if(pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds) || pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds) || pictureBox1.Top <-25 || pictureBox1.Bounds.IntersectsWith(pictureBox4.Bounds))//this condition present that id the bird touch any pipe or the ground the came should end
            {
                endGame();
            }
            if(score>5)
            {
                pipeSpeed = 15;
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void keyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = -15;
            }
        }

        private void keyUpEvent(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Space)
            {
                gravity = 15;
            }
        }
        private void endGame()
        {
            timer.Stop();//the timer should stop to pause the game
            label1.Text += "GAME OVER !!";// and to display this message
         }
    }
}
