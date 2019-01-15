namespace CPTGameV._1_BenM_
{
    partial class frmEasterEgg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picEasterEgg = new System.Windows.Forms.PictureBox();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.lblDontFeelNice = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picEasterEgg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picEasterEgg
            // 
            this.picEasterEgg.Image = global::CPTGameV._1_BenM_.Properties.Resources.easterEgg;
            this.picEasterEgg.Location = new System.Drawing.Point(-5, -2);
            this.picEasterEgg.Name = "picEasterEgg";
            this.picEasterEgg.Size = new System.Drawing.Size(646, 471);
            this.picEasterEgg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEasterEgg.TabIndex = 0;
            this.picEasterEgg.TabStop = false;
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.BackColor = System.Drawing.Color.Transparent;
            this.lblCongrats.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.Location = new System.Drawing.Point(124, 107);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(362, 28);
            this.lblCongrats.TabIndex = 1;
            this.lblCongrats.Text = "WOW you found the easter egg!";
            // 
            // lblDontFeelNice
            // 
            this.lblDontFeelNice.AutoSize = true;
            this.lblDontFeelNice.BackColor = System.Drawing.Color.Transparent;
            this.lblDontFeelNice.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDontFeelNice.Location = new System.Drawing.Point(143, 185);
            this.lblDontFeelNice.Name = "lblDontFeelNice";
            this.lblDontFeelNice.Size = new System.Drawing.Size(302, 28);
            this.lblDontFeelNice.TabIndex = 2;
            this.lblDontFeelNice.Text = "Don\'t feel too nice though\r\n";
            // 
            // picExit
            // 
            this.picExit.Image = global::CPTGameV._1_BenM_.Properties.Resources.exit;
            this.picExit.Location = new System.Drawing.Point(480, 353);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(69, 34);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 6;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CPTGameV._1_BenM_.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmEasterEgg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CPTGameV._1_BenM_.Properties.Resources.coinLVL2;
            this.ClientSize = new System.Drawing.Size(630, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.lblDontFeelNice);
            this.Controls.Add(this.lblCongrats);
            this.Controls.Add(this.picEasterEgg);
            this.Name = "frmEasterEgg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YEAHH DAWGG";
            ((System.ComponentModel.ISupportInitialize)(this.picEasterEgg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picEasterEgg;
        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Label lblDontFeelNice;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}