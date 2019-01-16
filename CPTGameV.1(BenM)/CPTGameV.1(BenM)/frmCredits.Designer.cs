namespace CPTGameV._1_BenM_
{
    partial class frmCredits
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
            this.lblCreated = new System.Windows.Forms.Label();
            this.picDancin1 = new System.Windows.Forms.PictureBox();
            this.picDancin2 = new System.Windows.Forms.PictureBox();
            this.lblThnaks = new System.Windows.Forms.Label();
            this.tmr5Secs = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picDancin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDancin2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCreated
            // 
            this.lblCreated.AutoSize = true;
            this.lblCreated.BackColor = System.Drawing.Color.Transparent;
            this.lblCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreated.ForeColor = System.Drawing.Color.Black;
            this.lblCreated.Location = new System.Drawing.Point(129, 57);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(354, 25);
            this.lblCreated.TabIndex = 0;
            this.lblCreated.Text = "Created and Coded by Ben Motz";
            // 
            // picDancin1
            // 
            this.picDancin1.BackColor = System.Drawing.Color.Transparent;
            this.picDancin1.Image = global::CPTGameV._1_BenM_.Properties.Resources.dancin;
            this.picDancin1.Location = new System.Drawing.Point(-54, 101);
            this.picDancin1.Name = "picDancin1";
            this.picDancin1.Size = new System.Drawing.Size(350, 350);
            this.picDancin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDancin1.TabIndex = 1;
            this.picDancin1.TabStop = false;
            // 
            // picDancin2
            // 
            this.picDancin2.BackColor = System.Drawing.Color.Transparent;
            this.picDancin2.Image = global::CPTGameV._1_BenM_.Properties.Resources.dancin;
            this.picDancin2.Location = new System.Drawing.Point(268, 101);
            this.picDancin2.Name = "picDancin2";
            this.picDancin2.Size = new System.Drawing.Size(350, 350);
            this.picDancin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDancin2.TabIndex = 2;
            this.picDancin2.TabStop = false;
            // 
            // lblThnaks
            // 
            this.lblThnaks.AutoSize = true;
            this.lblThnaks.BackColor = System.Drawing.Color.Transparent;
            this.lblThnaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThnaks.ForeColor = System.Drawing.Color.Black;
            this.lblThnaks.Location = new System.Drawing.Point(186, 101);
            this.lblThnaks.Name = "lblThnaks";
            this.lblThnaks.Size = new System.Drawing.Size(216, 25);
            this.lblThnaks.TabIndex = 3;
            this.lblThnaks.Text = "Thanks for Playing!";
            // 
            // tmr5Secs
            // 
            this.tmr5Secs.Enabled = true;
            this.tmr5Secs.Interval = 5000;
            this.tmr5Secs.Tick += new System.EventHandler(this.tmr5Secs_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mniExit
            // 
            this.mniExit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mniExit.Image = global::CPTGameV._1_BenM_.Properties.Resources.exit;
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(54, 20);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // frmCredits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CPTGameV._1_BenM_.Properties.Resources.brickWall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 463);
            this.Controls.Add(this.lblThnaks);
            this.Controls.Add(this.picDancin2);
            this.Controls.Add(this.picDancin1);
            this.Controls.Add(this.lblCreated);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCredits";
            ((System.ComponentModel.ISupportInitialize)(this.picDancin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDancin2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.PictureBox picDancin1;
        private System.Windows.Forms.PictureBox picDancin2;
        private System.Windows.Forms.Label lblThnaks;
        private System.Windows.Forms.Timer tmr5Secs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}