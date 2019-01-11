using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WMPLib;

namespace CPTGameV._1_BenM_
{
    

    public partial class frmCPTGame : Form
    {
        //creates media player
        WindowsMediaPlayer L1Music = new WindowsMediaPlayer();

        WindowsMediaPlayer CaChing = new WindowsMediaPlayer();

        //controls player going left
        bool goLeft = false;

        //controls player going right
        bool goRight = false;

        //checks if the player is jumping
        bool jumping = false;

        //value if the player has the key
        bool hasKey = false;

        //sets jump speed
        int jumpSpeed = 10;

        //sets force
        int force = 8;

        //sets score
        int score = 0;

        //sets player speed
        int playSpeed=10;

        //sets backround mocing speed
        int backLeft = 10;

        int randNumb;

        //Variable for lives
        int lives = 1;

        Random randNumbGen = new Random();

        Image playerImage;

        public int GenerateNumb()
        {
            //rand numbs equals
            randNumb = randNumbGen.Next(1, 3 + 1);

            //returns randNumb
            return randNumb;
        }

        public frmCPTGame(Image picUserChoice)
        {
            InitializeComponent();

            picPlayer.Image = picUserChoice;

            playerImage = picUserChoice;

            L1Music.URL = "Chcken.mp3";

            CaChing.URL = "CaChing.mp3";
        }

        private void picBackground_Click(object sender, EventArgs e)
        {

        }

        private void mainGameTimer(object sender, EventArgs e)
        {
            
            //links the jump speed to player pci box
            picPlayer.Top += jumpSpeed;

            //refreshs player pic box constintly
            picPlayer.Refresh();

            //if jumping is true and force < 0
            //then jumping is changed to false
            if (jumping && force < 0)
            {
                jumping = false;
            }

            //if jumping is true
            //then change jump speed to -12
            //reduces force by 1
            if (jumping)
            {
                jumpSpeed = -12;
                force -= 1; 
            }
            else
            {
                //changes jump speed to 12
                jumpSpeed = 12;
            }

            //if go left is true and player left is > 100 pixels
            //only then move player toward the left
            if (goLeft && picPlayer.Left > 30)
            {
                picPlayer.Left -= playSpeed;
            }
            //this stops player on left of the form

            //goes right if bool is true
            if (goRight && picPlayer.Left + (picPlayer.Width+100) < this.ClientSize.Width)
            {
                picPlayer.Left += playSpeed;
            }
            //stops the player on the right of the form

            //moves backround
            if (goRight && background.Left > -1280)
            {
                background.Left -= backLeft;

                //this loop checks coins and platoforms in the level
                //when they are found, it'll move to the left
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "platform"|| x is PictureBox && (string)x.Tag =="coin" || x is PictureBox && (string)x.Tag =="door"
                        || x is PictureBox && (string)x.Tag == "key" || x is PictureBox && (string)x.Tag == "spike" || x is PictureBox && (string)x.Tag == "diamond")
                    {
                        x.Left -= backLeft;
                    }
                }
            }

            if (goLeft && background.Left < 2)
            {
               background.Left += backLeft;

                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "coin" || x is PictureBox && (string)x.Tag == "door"
                        || x is PictureBox && (string)x.Tag == "key" || x is PictureBox && (string) x.Tag=="spike" || x is PictureBox && (string) x.Tag=="diamond" )
                    {
                        x.Left+= backLeft;
                    }


                }
            }

            //checks for all controls in the form
           foreach (Control x in this.Controls)
           {
                //if x is a picbox and has a tag of platform
                if ( x is PictureBox && (string)x.Tag =="platform")
                {
                    //checks if player is collding with it
                    //and if jumpingh is false
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8;
                        picPlayer.Top = x.Top - picPlayer.Height;
                        jumpSpeed = 0;
                    }
                }
                if (x is PictureBox && (string)x.Tag =="coin")
                {
                        //if player collides with the coin
                        if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                        {
                            //removes coin
                            this.Controls.Remove(x);

                            //increments score
                            score++;

                            //updates score
                            lblScore.Text = "Score = " + score;

                            //plays CaChing sound effect when coins are picked up
                            CaChing.controls.play();

                        }           
                }
                //If the player hits a spike
                if (x is PictureBox && (string)x.Tag == "spike")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (lives == 1)
                        {
                            //stops tmr
                            tmrGameTimer.Stop();

                            //hides player
                            picPlayer.Hide();

                            //var for dead screen
                            var deadScreen = new frmDeadScreen(score, playerImage);

                            //shows dead screen
                            deadScreen.Show();                           

                            L1Music.controls.stop();

                            this.Hide();

                            //makes lives = 0
                            lives--;
                            lblLives.Text = "Lives = " + lives;
                        }
                        else
                        {
                            //lets player continue to play
                            lives--;
                            lblLives.Text = "Lives = " + lives;
                        }
                    }
                }
                //if player pics up diamond
                if (x is PictureBox && (string)x.Tag == "diamond")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);

                        GenerateNumb();

                        if (randNumb==1)
                        {
                            score = score + 100;

                            lblScore.Text = "Score = " + score;
                        }
                        else if (randNumb==2)
                        {
                            score = score + 5;

                            lblScore.Text = "Score = " + score;
                        }
                        else
                        {
                            score = score + 20;

                            lblScore.Text = "Score = " + score;
                        }
                    }
                }

            }

           //If player hits the door
            if (picPlayer.Bounds.IntersectsWith(picDoor.Bounds)&&hasKey)
            {
                picDoor.Image = Properties.Resources.door_open;

                tmrGameTimer.Stop();

                var UpgradeForm = new frmUpgrade (playerImage, playSpeed, jumpSpeed, lives, score);

                UpgradeForm.Show();

                this.Hide();

                L1Music.controls.stop();
            }

           //when the player gets the key
           if (picPlayer.Bounds.IntersectsWith(picKey.Bounds))
            {
                this.Controls.Remove(picKey);
                hasKey = true;
            }
           //when the player dies
           if (picPlayer.Top +picPlayer.Height>this.ClientSize.Height +60)
            {
                tmrGameTimer.Stop();

                //var for dead screen
                var deadScreen = new frmDeadScreen(score, playerImage);

                //shows dead screen
                deadScreen.Show();

                L1Music.controls.stop();

                this.Hide();

                lives = 0;

                lblLives.Text = "Lives = " + lives;
            }   
           

        }
        
       
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            //this code moves the player

            //if the key is pressed and player is in the pannel
            if (e.KeyCode==Keys.Left)
            {
                
                //sets bool to true
                goLeft = true;
                //picPlayer.Image = Properties.Resources.playerMario;
            }

            //if the right key is pressed and if player left plus player width is less than parallel width
            if (e.KeyCode == Keys.Right)
            {
                
                //sets bool to true
                goRight = true;
                //picPlayer.Image = Properties.Resources.playerMario;
            }

            //if player presses space and jumping if false
            if (e.KeyCode==Keys.Space && !jumping)
            {
                
                //sets jumping bool to true
                jumping = true;
                //picPlayer.Image = Properties.Resources.playerMario;
            }

        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            //if key is not pressed it is set to false
            //for left key
            if (e.KeyCode==Keys.Left)
            {
                //sets go left bool to false
                goLeft = false;

                
               // picPlayer.Image = Properties.Resources.Small_Mario_NSMBU;
            }

            //for right key
            if (e.KeyCode==Keys.Right)
            {
                //sets go right to false
                goRight = false;
                
                //picPlayer.Image = Properties.Resources.Small_Mario_NSMBU;
            }

            //when keys are released we check if jumping is false

            //sets jumping back to false so the player can jump again
            if (jumping)
            {
                jumping = false;
                
               // picPlayer.Image = Properties.Resources.Small_Mario_NSMBU;
            }


        }

        private void picPlayer_Click(object sender, EventArgs e)
        {

        }

        private void frmCPTGame_Load(object sender, EventArgs e)
        {
            //plays music
            L1Music.controls.play();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
