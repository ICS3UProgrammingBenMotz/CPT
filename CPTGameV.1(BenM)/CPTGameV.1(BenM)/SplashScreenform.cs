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
    public partial class frmSplashScreen : Form
    {
        //declares constants and variable
        const int MAX_PROGRESS_VALUE = 100;
        int progressbarvalue = 0;

           

        public frmSplashScreen()
        {
            InitializeComponent();
        }
        

        public void splashScreenStart()
        {

        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            //Makes progress bar increase
            do
            {
                this.prbSecs.Value = progressbarvalue;
                progressbarvalue = progressbarvalue + 2;
                this.Refresh();
            } while (progressbarvalue <= MAX_PROGRESS_VALUE);
        }


        private void tmrWait_Tick(object sender, EventArgs e)
        {
            //goes to the home screen after 5 secs
            var homeScreen = new frmMainMenu();

            //goes to main menu
            homeScreen.Show();

            //hides form
            this.Hide();

            //stops the timer
            tmrWait.Stop();
        }

        private void frmSplashScreen_Load_1(object sender, EventArgs e)
        {

        }
    }
}
