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
    public partial class frmDeadScreen : Form
    {
        WindowsMediaPlayer DeadMus = new WindowsMediaPlayer();

        Image playerImage;

        int deadScore;

        public frmDeadScreen(int score, Image playerPic)
        {
            InitializeComponent();

            deadScore = score;

            playerImage = playerPic;

            DeadMus.URL = "deathSound.mp3";
        }

        private void frmDeadScreen_Load(object sender, EventArgs e)
        {
            //makes pic box the player's chosen image
            picPlayer.Image = playerImage;

            //dead score
            lblYourScore.Text = "Your score was: " + deadScore;

            DeadMus.controls.play();

        }

        private void picPlayer_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            Application.Exit();            
       }

        private void mniRetry_Click(object sender, EventArgs e)
        {
            var lvlOne = new frmCPTGame(playerImage);

            lvlOne.Show();
        }
    }
}
