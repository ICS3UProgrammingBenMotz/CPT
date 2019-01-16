namespace CPTGameV._1_BenM_
{
    partial class frmSplashScreen
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
            this.components = new System.ComponentModel.Container();
            this.picBenMotz = new System.Windows.Forms.PictureBox();
            this.lblBenMotzGamingStudios = new System.Windows.Forms.Label();
            this.tmrWait = new System.Windows.Forms.Timer(this.components);
            this.prbSecs = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picBenMotz)).BeginInit();
            this.SuspendLayout();
            // 
            // picBenMotz
            // 
            this.picBenMotz.BackColor = System.Drawing.Color.Transparent;
            this.picBenMotz.Image = global::CPTGameV._1_BenM_.Properties.Resources.benmotzGamingStudiosImage;
            this.picBenMotz.Location = new System.Drawing.Point(183, 68);
            this.picBenMotz.Name = "picBenMotz";
            this.picBenMotz.Size = new System.Drawing.Size(245, 240);
            this.picBenMotz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBenMotz.TabIndex = 0;
            this.picBenMotz.TabStop = false;
            // 
            // lblBenMotzGamingStudios
            // 
            this.lblBenMotzGamingStudios.AutoSize = true;
            this.lblBenMotzGamingStudios.BackColor = System.Drawing.Color.Transparent;
            this.lblBenMotzGamingStudios.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenMotzGamingStudios.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblBenMotzGamingStudios.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblBenMotzGamingStudios.Location = new System.Drawing.Point(210, 326);
            this.lblBenMotzGamingStudios.Name = "lblBenMotzGamingStudios";
            this.lblBenMotzGamingStudios.Size = new System.Drawing.Size(255, 28);
            this.lblBenMotzGamingStudios.TabIndex = 1;
            this.lblBenMotzGamingStudios.Text = "Motzart Gaming Studios";
            // 
            // tmrWait
            // 
            this.tmrWait.Enabled = true;
            this.tmrWait.Interval = 2500;
            this.tmrWait.Tick += new System.EventHandler(this.tmrWait_Tick);
            // 
            // prbSecs
            // 
            this.prbSecs.Location = new System.Drawing.Point(109, 403);
            this.prbSecs.Name = "prbSecs";
            this.prbSecs.Size = new System.Drawing.Size(406, 29);
            this.prbSecs.TabIndex = 2;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CPTGameV._1_BenM_.Properties.Resources.spashScreenBackground;
            this.ClientSize = new System.Drawing.Size(646, 463);
            this.Controls.Add(this.prbSecs);
            this.Controls.Add(this.lblBenMotzGamingStudios);
            this.Controls.Add(this.picBenMotz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBenMotz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBenMotz;
        private System.Windows.Forms.Label lblBenMotzGamingStudios;
        private System.Windows.Forms.Timer tmrWait;
        private System.Windows.Forms.ProgressBar prbSecs;
    }
}