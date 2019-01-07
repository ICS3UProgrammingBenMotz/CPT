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
    public partial class frmChooseChar : Form
    {
        
        //sets player image to nothing
        Image picPlayer = null;

        public frmChooseChar()
        {
            InitializeComponent();
        }

        private void picComandoGuy_Click(object sender, EventArgs e)
        {
            
            picPlayer = Properties.Resources.playerGuy;

            //creates new form with passing the image that the player chose
            var lev1 = new frmCPTGame(picPlayer);

            this.Hide();

            lev1.Show();
        }

        private void picMario_Click(object sender, EventArgs e)
        {
            //sets player to mario
            picPlayer = Properties.Resources.Small_Mario_NSMBU;

            //creates new form
            var lev1 = new frmCPTGame(picPlayer);

            this.Hide();

            lev1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            picPlayer = Properties.Resources.gladiator_5;

            //creates new form
            var lev1 = new frmCPTGame(picPlayer);

            this.Hide();

            lev1.Show();

        }

        private void frmChooseChar_Load(object sender, EventArgs e)
        {

        }
    }
}
