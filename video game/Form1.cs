using class_video_game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_video_game
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, jumping, isGameOver; //
        int jumpSpeed; // how high a player jumps
        int force; // gravity
        int score = 0; // keeps track of points player gets
        int playerSpeed = 7; // speed of player
        int horizontalSpeed = 5;
        int verticalSpeed = 3;
        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void player_Click(object sender, EventArgs e)
        {

        }

        private void timerTick(object sender, EventArgs e)
        {
            txtscore.Text = "Score: " + score;
            
            
            // update player position
            player.Top += jumpSpeed;
            if (goLeft == true)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
            }

            // updating jumping and force
            if (jumping == true && force < 0)
            {
                jumping = false;
            }
            if (jumping == true)
            {
                jumpSpeed = -10;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;

            }


            foreach(Control x in this.Controls)
            {
              
                if((string)x.Tag=="platform")
                {      // collision from below
                    if(player.Bounds.IntersectsWith(x.Bounds) && jumpSpeed >= 0 && player.Bottom > x.Top && player.Top < x.Top) 
                   {
                        player.Top = x.Top - player.Height;
                        force = 8;
                        jumping = false;
                    }
                    // check for collision from above
                    if (player.Bounds.IntersectsWith(x.Bounds) && jumpSpeed < 0 && player.Top < x.Bottom && player.Bottom > x.Bottom)
                    {
                        player.Top = x.Bottom;
                        force = 0;
                    
                    }
                    // check for collision from left 
                    if (player.Bounds.IntersectsWith(x.Bounds) && goRight == false && player.Left  < x.Right  && player.Right  > x.Right)
                    {
                        player.Left = x.Right;
                            }
                    // check for collision from right
                    if (player.Bounds.IntersectsWith(x.Bounds) && goLeft == false && player.Right > x.Left && player.Left < x.Left)
                    {
                        player.Left = x.Left - player.Width;
                    }

                    // bring platform to front
                    x.BringToFront();











                    








                }

                if ((string)x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score++;
                    }
                }


                if ((string)x.Tag == "coinmultipler")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        score = score * 2;
                    }
                }
               
                if ((string)x.Tag == "speedboost")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                    {
                        x.Visible = false;
                        playerSpeed = playerSpeed * 2;
                    }
                }

            }

            if (player.Bounds.IntersectsWith(door.Bounds))
            {
                gameTimer.Stop();
                isGameOver = true;
                txtscore.Text = "Score : " + score + Environment.NewLine + " OOOOOOHHHHH";
            }

            if(player.Top + player.Height > this.ClientSize.Height + 50)
            {
                gameTimer.Stop();
                isGameOver = true;
                txtscore.Text = "Score : " + score + Environment.NewLine + "Loser";
            }
            if (player.Bounds.IntersectsWith(Door2.Bounds))
            {
                gameTimer.Stop();
                isGameOver = true;
                txtscore.Text = "Score : " + score + Environment.NewLine + " you who else is loser  MY MOM";
 
            }






            VerticalPlatform.Top += verticalSpeed;

            if(VerticalPlatform.Top <127 || VerticalPlatform.Top > 312)
            {
                verticalSpeed = -verticalSpeed;
            }

            if (player.Bounds.IntersectsWith(enemyone.Bounds))
            {
                gameTimer.Stop();
                isGameOver = true;
                txtscore.Text = "score :" + score + score + Environment.NewLine + " your dead loser";
            }

            enemyone.Left -= enemyOneSpeed;
            if (enemyone.Left < pictureBox1.Left || enemyone.Left + enemyone.Width > pictureBox1.Left + pictureBox1.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
            }



        }


        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
           
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            jumping = false;
        }
    }
}
