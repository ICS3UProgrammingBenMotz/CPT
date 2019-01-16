namespace CPTGameV._1_BenM_
{
    partial class frmYouWin
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
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picBigChungus = new System.Windows.Forms.PictureBox();
            this.picBigChungus2 = new System.Windows.Forms.PictureBox();
            this.picContinue = new System.Windows.Forms.PictureBox();
            this.picYouWin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBigChungus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBigChungus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContinue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouWin)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Image = global::CPTGameV._1_BenM_.Properties.Resources.gladiator_5;
            this.picPlayer.Location = new System.Drawing.Point(272, 220);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(87, 95);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 4;
            this.picPlayer.TabStop = false;
            // 
            // picBigChungus
            // 
            this.picBigChungus.BackColor = System.Drawing.Color.Transparent;
            this.picBigChungus.Image = global::CPTGameV._1_BenM_.Properties.Resources.bigChungus;
            this.picBigChungus.Location = new System.Drawing.Point(119, 283);
            this.picBigChungus.Name = "picBigChungus";
            this.picBigChungus.Size = new System.Drawing.Size(137, 157);
            this.picBigChungus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBigChungus.TabIndex = 5;
            this.picBigChungus.TabStop = false;
            // 
            // picBigChungus2
            // 
            this.picBigChungus2.BackColor = System.Drawing.Color.Transparent;
            this.picBigChungus2.Image = global::CPTGameV._1_BenM_.Properties.Resources.bigChungus;
            this.picBigChungus2.Location = new System.Drawing.Point(365, 283);
            this.picBigChungus2.Name = "picBigChungus2";
            this.picBigChungus2.Size = new System.Drawing.Size(134, 157);
            this.picBigChungus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBigChungus2.TabIndex = 6;
            this.picBigChungus2.TabStop = false;
            // 
            // picContinue
            // 
            this.picContinue.BackColor = System.Drawing.Color.Transparent;
            this.picContinue.Image = global::CPTGameV._1_BenM_.Properties.Resources._continue;
            this.picContinue.Location = new System.Drawing.Point(392, 22);
            this.picContinue.Name = "picContinue";
            this.picContinue.Size = new System.Drawing.Size(196, 70);
            this.picContinue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContinue.TabIndex = 7;
            this.picContinue.TabStop = false;
            this.picContinue.Click += new System.EventHandler(this.picContinue_Click);
            // 
            // picYouWin
            // 
            this.picYouWin.BackColor = System.Drawing.Color.Transparent;
            this.picYouWin.Image = global::CPTGameV._1_BenM_.Properties.Resources.Youwin;
            this.picYouWin.Location = new System.Drawing.Point(199, 98);
            this.picYouWin.Name = "picYouWin";
            this.picYouWin.Size = new System.Drawing.Size(235, 95);
            this.picYouWin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picYouWin.TabIndex = 8;
            this.picYouWin.TabStop = false;
            // 
            // frmYouWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CPTGameV._1_BenM_.Properties.Resources.mansion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 463);
            this.Controls.Add(this.picYouWin);
            this.Controls.Add(this.picContinue);
            this.Controls.Add(this.picBigChungus2);
            this.Controls.Add(this.picBigChungus);
            this.Controls.Add(this.picPlayer);
            this.Name = "frmYouWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONGRATS";
            this.Load += new System.EventHandler(this.frmYouWin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBigChungus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBigChungus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picContinue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYouWin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picBigChungus;
        private System.Windows.Forms.PictureBox picBigChungus2;
        private System.Windows.Forms.PictureBox picContinue;
        private System.Windows.Forms.PictureBox picYouWin;
    }
}