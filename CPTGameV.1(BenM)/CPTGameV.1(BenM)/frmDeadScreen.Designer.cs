namespace CPTGameV._1_BenM_
{
    partial class frmDeadScreen
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
            this.picTombstone = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picRIP = new System.Windows.Forms.PictureBox();
            this.lblDied = new System.Windows.Forms.Label();
            this.lblYourScore = new System.Windows.Forms.Label();
            this.picGraveyard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniRetry = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picTombstone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGraveyard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picTombstone
            // 
            this.picTombstone.BackColor = System.Drawing.Color.Transparent;
            this.picTombstone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picTombstone.Image = global::CPTGameV._1_BenM_.Properties.Resources.tombstone;
            this.picTombstone.Location = new System.Drawing.Point(217, 173);
            this.picTombstone.Name = "picTombstone";
            this.picTombstone.Size = new System.Drawing.Size(210, 198);
            this.picTombstone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTombstone.TabIndex = 1;
            this.picTombstone.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Location = new System.Drawing.Point(295, 226);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(57, 58);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlayer.TabIndex = 2;
            this.picPlayer.TabStop = false;
            this.picPlayer.Click += new System.EventHandler(this.picPlayer_Click);
            // 
            // picRIP
            // 
            this.picRIP.BackColor = System.Drawing.Color.Transparent;
            this.picRIP.Image = global::CPTGameV._1_BenM_.Properties.Resources.RIP;
            this.picRIP.Location = new System.Drawing.Point(295, 281);
            this.picRIP.Name = "picRIP";
            this.picRIP.Size = new System.Drawing.Size(57, 39);
            this.picRIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRIP.TabIndex = 3;
            this.picRIP.TabStop = false;
            // 
            // lblDied
            // 
            this.lblDied.AutoSize = true;
            this.lblDied.BackColor = System.Drawing.Color.Transparent;
            this.lblDied.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDied.Location = new System.Drawing.Point(263, 81);
            this.lblDied.Name = "lblDied";
            this.lblDied.Size = new System.Drawing.Size(107, 25);
            this.lblDied.TabIndex = 4;
            this.lblDied.Text = "You Died!";
            // 
            // lblYourScore
            // 
            this.lblYourScore.AutoSize = true;
            this.lblYourScore.BackColor = System.Drawing.Color.Transparent;
            this.lblYourScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourScore.Location = new System.Drawing.Point(236, 109);
            this.lblYourScore.Name = "lblYourScore";
            this.lblYourScore.Size = new System.Drawing.Size(173, 25);
            this.lblYourScore.TabIndex = 5;
            this.lblYourScore.Text = "Your score was :";
            // 
            // picGraveyard
            // 
            this.picGraveyard.BackColor = System.Drawing.Color.Transparent;
            this.picGraveyard.Image = global::CPTGameV._1_BenM_.Properties.Resources.graveyard;
            this.picGraveyard.Location = new System.Drawing.Point(-116, 109);
            this.picGraveyard.Name = "picGraveyard";
            this.picGraveyard.Size = new System.Drawing.Size(960, 480);
            this.picGraveyard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picGraveyard.TabIndex = 0;
            this.picGraveyard.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit,
            this.mniRetry});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniExit
            // 
            this.mniExit.Image = global::CPTGameV._1_BenM_.Properties.Resources.exit;
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(53, 20);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mniRetry
            // 
            this.mniRetry.Image = global::CPTGameV._1_BenM_.Properties.Resources.redo;
            this.mniRetry.Name = "mniRetry";
            this.mniRetry.Size = new System.Drawing.Size(62, 20);
            this.mniRetry.Text = "Retry";
            this.mniRetry.Click += new System.EventHandler(this.mniRetry_Click);
            // 
            // frmDeadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CPTGameV._1_BenM_.Properties.Resources.DeadBackground;
            this.ClientSize = new System.Drawing.Size(630, 463);
            this.Controls.Add(this.lblYourScore);
            this.Controls.Add(this.lblDied);
            this.Controls.Add(this.picRIP);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picTombstone);
            this.Controls.Add(this.picGraveyard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDeadScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDeadScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTombstone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGraveyard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picTombstone;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picRIP;
        private System.Windows.Forms.Label lblDied;
        private System.Windows.Forms.Label lblYourScore;
        private System.Windows.Forms.PictureBox picGraveyard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniRetry;
    }
}