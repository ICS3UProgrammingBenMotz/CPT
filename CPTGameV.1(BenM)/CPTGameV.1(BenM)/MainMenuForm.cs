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
    public partial class frmMainMenu : Form
    {
        //creates a media player
        WindowsMediaPlayer musicPlay = new WindowsMediaPlayer();

        public frmMainMenu()
        {
            InitializeComponent();

            //lets media player play this music
            musicPlay.URL = "illuminatiSong.mp3";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            var helpform = new frmHelp();

            //shows help form
            helpform.Show();

            //hides main menu
            this.Hide();

            //pauses the music
            musicPlay.controls.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            var chooseChar = new frmChooseChar();

            //brings player to the game
            chooseChar.Show();

            //hides form
            this.Hide();

            //stops music
            musicPlay.controls.stop();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            //plays music
            musicPlay.controls.play();
        }
    }
}
