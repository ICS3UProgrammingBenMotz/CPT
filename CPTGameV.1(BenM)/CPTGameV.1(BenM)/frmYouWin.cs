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
    public partial class frmYouWin : Form
    {
        Image playerImage;

        public frmYouWin(Image playerImagePassed)
        {
            InitializeComponent();

            playerImage = playerImagePassed;

            
        }

        private void frmYouWin_Load(object sender, EventArgs e)
        {
            picPlayer.Image = playerImage;
        }
    }
}
