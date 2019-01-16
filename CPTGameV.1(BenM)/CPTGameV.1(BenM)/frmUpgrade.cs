using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPTGameV._1_BenM_
{
    public partial class frmUpgrade : Form
    {
        //creates varaibles that can player can upgrade
        int upgradeLives;

        int upgradePlaySpeed;

        int upgradeJumpSpeed;

        int upgradeScore;

        Image upgradePicPlayer;

        int SpeedLvl;

        int JumpLvl;

        int jumpCost;

        int speedCost;

        int livesCost;



        public frmUpgrade(Image picPlayer, int playSpeed, int jumpSpeed, int lives, int score, int livesCost1, int SpeedLvl1, int JumpLvl1, int jumpCost1, int speedCost1)
        {
            InitializeComponent();

            upgradeLives = lives;

            upgradePlaySpeed = playSpeed;

            upgradeJumpSpeed = jumpSpeed;

            upgradePicPlayer = picPlayer;

            upgradeScore = score;

           SpeedLvl = SpeedLvl1;

            JumpLvl = JumpLvl1;

            jumpCost = jumpCost1;

            speedCost = speedCost1;

           livesCost = livesCost1;

        }

        private void lblSpeedLvl_Click(object sender, EventArgs e)
        {
         
        }

        private void picUpgradeSpeed_Click(object sender, EventArgs e)
        {

            if (upgradeScore >= speedCost)
            {
                //changes the play speed
                upgradePlaySpeed = upgradePlaySpeed + 5;

                //increments speed lvl
                SpeedLvl++;

                //Increases speed lvl on lbl
                lblSpeedLvl.Text = "Speed: " + SpeedLvl;

                //Chnages upgrade score
                upgradeScore = upgradeScore - speedCost;

                //updates lbl
                lblUpgradePoints.Text = "Upgrade Points : " + upgradeScore;

                //doubles speed
                speedCost = speedCost * 2;
                
                //updates label
                lblCostSpeed.Text =  speedCost + " Points"; 
            }
            else
            {
                //if the player does not have enough points
                MessageBox.Show("Not enough points");
            }
        }

        private void picMoreLiives_Click(object sender, EventArgs e)
        {
            if (upgradeScore >= livesCost)
            {
                upgradeLives++;

                lblLives.Text = "Lives: " + upgradeLives;

                upgradeScore = upgradeScore - livesCost;

                lblUpgradePoints.Text = "Upgrade Points : " + upgradeScore;

                livesCost = livesCost * 2;

                lblCostExtraLife.Text = livesCost + " Points";
            }
            else
            {
              MessageBox.Show("Not enough points");
            }
        }

        private void picUpgradeJump_Click(object sender, EventArgs e)
        {
            if (upgradeScore >= jumpCost)
            {
                upgradeJumpSpeed = upgradeJumpSpeed + 5;

                JumpLvl++;

                lblJumpLvl.Text = "Jump: " + JumpLvl;

                upgradeScore = upgradeScore - jumpCost;

                lblUpgradePoints.Text = "Upgrade Points : " + upgradeScore;

                jumpCost = jumpCost * 2;

                lblCostJump.Text = jumpCost + " Points";
            }
            else
            {
                MessageBox.Show("Not enough points");
            }
        }

        private void lblLives_Click(object sender, EventArgs e)
        {

        }

        private void frmUpgrade_Load(object sender, EventArgs e)
        {
            lblUpgradePoints.Text = "Upgrade Points : " + upgradeScore;

        }

        private void picNextLevel_Click(object sender, EventArgs e)
        {
            var lvlTwo = new frmLvlTwo(upgradeLives, livesCost, upgradePlaySpeed, speedCost, SpeedLvl, upgradeJumpSpeed, jumpCost, JumpLvl,upgradeScore, upgradePicPlayer);

            lvlTwo.Show();

            this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
