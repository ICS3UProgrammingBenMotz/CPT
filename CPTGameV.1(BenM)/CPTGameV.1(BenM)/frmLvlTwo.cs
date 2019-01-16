using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace CPTGameV._1_BenM_
{
    public partial class frmLvlTwo : Form
    {
        List<PictureBox> listOCoins = new List<PictureBox>();

        WindowsMediaPlayer CaChing = new WindowsMediaPlayer();

        WindowsMediaPlayer L2Music = new WindowsMediaPlayer();

        //controls player going left
        bool goLeft = false;

        //controls player going right
        bool goRight = false;

        //checks if the player is jumping
        bool jumping = false;

        //value if the player has the key
        bool hasKey = false;

        //sets jump speed
        int jumpSpeed;

        //sets force
        int force = 8;

        //sets score
        int score;

        //sets player speed
        int playSpeed;

        //sets backround mocing speed
        int backLeft = 10;

        int randNumb;

        //Variable for lives
        int lives;

        Random randNumbGen = new Random();

        Image playerImage;

        public int GenerateNumb()
        {
            //rand numbs equals
            randNumb = randNumbGen.Next(1, 3 + 1);

            //returns randNumb
            return randNumb;
        }
        //items that will be passed
        int SpeedLvl;

        int JumpLvl;

        int jumpCost;

        int speedCost;

        int livesCost;


        public frmLvlTwo(int upgradeLives, int uplivesCost, int upgradePlaySpeed, int upSpeedCost, int upSpeedLvl, int upgradeJumpSpeed, int upJumpCost, int upJumpLvl, int upgradeScore, Image upgradePicPlayer)
        {
            InitializeComponent();

            CaChing.URL = "CaChing.mp3";

            L2Music.URL = "lvl2Music.mp3";


            //updates player image
            playerImage = upgradePicPlayer;

            //for lives
            lives = upgradeLives;
            livesCost = uplivesCost;

            //for jump
            jumpSpeed = upgradeJumpSpeed;
            JumpLvl = upJumpLvl;
            jumpCost = upJumpCost;

            //for speed
            playSpeed = upgradePlaySpeed;
            SpeedLvl = upSpeedLvl;
            speedCost = upSpeedCost;

            //for score
            score = upgradeScore;

            //sets picture box to chosen pic
            picPlayer.Image = playerImage;
        }

        private void frmLvlTwo_Load(object sender, EventArgs e)
        {
            //hides portal
            picPortal.Hide();

            //plays music
            L2Music.controls.play();

            lblLives.Text = "Lives = " + lives;

            lblScore.Text = "Score = " + score;

            //adds coins to list
            listOCoins.Add(picCoin1);
            listOCoins.Add(picCoin2);
            listOCoins.Add(picCoin3);
            listOCoins.Add(picCoin4);
            listOCoins.Add(picCoin5);
            listOCoins.Add(picCoin6);
            listOCoins.Add(picCoin7);
            listOCoins.Add(picCoin8);


        }

        private void tmrLvlTimer_Tick(object sender, EventArgs e)
        {

        }

        private void lvlTwoTimer (object sender, EventArgs e)
        {
            //links the jump speed to player pic box
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
            if (goRight && picPlayer.Left + (picPlayer.Width + 100) < this.ClientSize.Width)
            {
                picPlayer.Left += playSpeed;
            }
            //stops the player on the right of the form




            //moves backround
            if (goRight && background.Left > -1900)
            {
                background.Left -= backLeft;

                //this loop checks coins and platoforms in the level
                //when they are found, it'll move to the left
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && (string)x.Tag == "platform" || x is PictureBox && (string)x.Tag == "coin" || x is PictureBox && (string)x.Tag == "door"
                        || x is PictureBox && (string)x.Tag == "key" || x is PictureBox && (string)x.Tag == "fire" || x is PictureBox && (string)x.Tag == "diamond")
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
                        || x is PictureBox && (string)x.Tag == "key" || x is PictureBox && (string)x.Tag == "fire" || x is PictureBox && (string)x.Tag == "diamond")
                    {
                        x.Left += backLeft;
                    }


                }
            }

            //checks for all controls in the form
            foreach (Control x in this.Controls)
            {
                //if x is a picbox and has a tag of platform
                if (x is PictureBox && (string)x.Tag == "platform")
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
                if (x is PictureBox && (string)x.Tag == "coin")
                {
                    //if player collides with the coin
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        int coinFinder = 1;

                        PictureBox coin = "picCoin" + coinFinder;

                        //removes coin
                        this.Controls.Remove(x);

                        while (coinFinder <= 8)
                        {
                            if (x.Name == "picCoin" + coinFinder)
                            {
                                listOCoins.Remove(coin);
                            }
                        }


                        //increments score
                        score++;

                        //updates score
                        lblScore.Text = "Score = " + score;

                        //plays CaChing sound effect when coins are picked up
                        CaChing.controls.play();

                    }
                }




                //If the player hits fire
                if (x is PictureBox && (string)x.Tag == "fire")
                {
                    if (picPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        if (lives == 1)
                        {
                            //stops tmr
                            tmrLvlTimer.Stop();

                            //hides player
                            picPlayer.Hide();

                            //var for dead screen
                            var deadScreen = new frmDeadScreen(score, playerImage);

                            //shows dead screen
                            deadScreen.Show();

                            L2Music.controls.stop();

                            this.Hide();

                            //makes lives = 0
                            lives--;
                            lblLives.Text = "Lives = " + lives;
                        }
                        else
                        {
                            tmrLvlTimer.Stop();

                            this.Hide();

                            //lets player continue to play
                            lives--;
                            lblLives.Text = "Lives = " + lives;

                            L2Music.controls.stop();

                            var lvl2Respawn = new frmLvlTwo(lives, livesCost, playSpeed, speedCost, SpeedLvl, jumpSpeed, jumpCost, JumpLvl, score, playerImage);

                            lvl2Respawn.Show();
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

                        if (randNumb == 1)
                        {
                            score = score + 100;

                            lblScore.Text = "Score = " + score;
                        }
                        else if (randNumb == 2)
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
            if (picPlayer.Bounds.IntersectsWith(picPortal.Bounds) && hasKey)
            {
                picPortal.Image = Properties.Resources.door_open;

                tmrLvlTimer.Stop();

                this.Hide();

                L2Music.controls.stop();

                var endGame = new frmYouWin(playerImage);

                endGame.Show();
            }

            //when the player gets the key
            if (picPlayer.Bounds.IntersectsWith(picPortalStone.Bounds))
            {
                picPortal.Show();
                this.Controls.Remove(picPortalStone);
                hasKey = true;
            }
            //when the player dies
            if (picPlayer.Top + picPlayer.Height > this.ClientSize.Height + 60)
            {
                tmrLvlTimer.Stop();

                //var for dead screen
                var deadScreen = new frmDeadScreen(score, playerImage);

                //shows dead screen
                deadScreen.Show();

                L2Music.controls.stop();

                this.Hide();

                lives = 0;

                lblLives.Text = "Lives = " + lives;
            }
        }



        //function for key is down
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            //this code moves the player

            //if the key is pressed and player is in the pannel
            if (e.KeyCode == Keys.Left)
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
            if (e.KeyCode == Keys.Space && !jumping)
            {

                //sets jumping bool to true
                jumping = true;
                //picPlayer.Image = Properties.Resources.playerMario;
            }

        }




        //function for key is up
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            //if key is not pressed it is set to false
            //for left key
            if (e.KeyCode == Keys.Left)
            {
                //sets go left bool to false
                goLeft = false;


                // picPlayer.Image = Properties.Resources.Small_Mario_NSMBU;
            }

            //for right key
            if (e.KeyCode == Keys.Right)
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

        private void picFire1_Click(object sender, EventArgs e)
        {

        }

        private void background_Click(object sender, EventArgs e)
        {

        }
    }
}

