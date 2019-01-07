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
    public partial class frmHelp : Form
    {
        //creates new media player 
        new WindowsMediaPlayer helpSoundtrack = new WindowsMediaPlayer();

        public frmHelp()
        {
            InitializeComponent();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            var homeScreen = new frmMainMenu();

            //goes to main menu
            homeScreen.Show();

            //hides form
            this.Hide();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {

        }
    }
}
