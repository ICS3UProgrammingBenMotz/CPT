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
    public partial class frmYouWin : Form
    {
        WindowsMediaPlayer Win = new WindowsMediaPlayer();

        Image playerImage;

        public frmYouWin(Image playerImagePassed)
        {
            InitializeComponent();

            playerImage = playerImagePassed;

            Win.URL = "Win.mp3";

            
        }

        private void frmYouWin_Load(object sender, EventArgs e)
        {
            picPlayer.Image = playerImage;

            Win.controls.play();
        }

        private void picContinue_Click(object sender, EventArgs e)
        {
            var Creds = new frmCredits();

            Creds.Show();

            Win.controls.stop();

            this.Hide();
        }
    }
}
