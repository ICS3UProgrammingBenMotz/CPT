namespace CPTGameV._1_BenM_
{
    partial class frmHelp
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
            this.lblArrowKeys = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picCash = new System.Windows.Forms.PictureBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.picSpikes = new System.Windows.Forms.PictureBox();
            this.lblSpikes = new System.Windows.Forms.Label();
            this.picKey = new System.Windows.Forms.PictureBox();
            this.lblKeys = new System.Windows.Forms.Label();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.picDiamond = new System.Windows.Forms.PictureBox();
            this.lblPowerUps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiamond)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArrowKeys
            // 
            this.lblArrowKeys.AutoSize = true;
            this.lblArrowKeys.BackColor = System.Drawing.Color.Transparent;
            this.lblArrowKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrowKeys.Location = new System.Drawing.Point(72, 39);
            this.lblArrowKeys.Name = "lblArrowKeys";
            this.lblArrowKeys.Size = new System.Drawing.Size(354, 25);
            this.lblArrowKeys.TabIndex = 0;
            this.lblArrowKeys.Text = "Arrow Keys    -    Moves you around";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Space    -    Jump";
            // 
            // picCash
            // 
            this.picCash.BackColor = System.Drawing.Color.Transparent;
            this.picCash.Image = global::CPTGameV._1_BenM_.Properties.Resources.cash;
            this.picCash.Location = new System.Drawing.Point(57, 200);
            this.picCash.Name = "picCash";
            this.picCash.Size = new System.Drawing.Size(100, 50);
            this.picCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCash.TabIndex = 2;
            this.picCash.TabStop = false;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.BackColor = System.Drawing.Color.Transparent;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(182, 213);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(390, 25);
            this.lblCash.TabIndex = 3;
            this.lblCash.Text = "Collect these to upgrade your character\r\n";
            // 
            // picSpikes
            // 
            this.picSpikes.BackColor = System.Drawing.Color.Transparent;
            this.picSpikes.Image = global::CPTGameV._1_BenM_.Properties.Resources.spikes_png_1;
            this.picSpikes.Location = new System.Drawing.Point(57, 268);
            this.picSpikes.Name = "picSpikes";
            this.picSpikes.Size = new System.Drawing.Size(100, 50);
            this.picSpikes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSpikes.TabIndex = 4;
            this.picSpikes.TabStop = false;
            // 
            // lblSpikes
            // 
            this.lblSpikes.AutoSize = true;
            this.lblSpikes.BackColor = System.Drawing.Color.Transparent;
            this.lblSpikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpikes.Location = new System.Drawing.Point(184, 279);
            this.lblSpikes.Name = "lblSpikes";
            this.lblSpikes.Size = new System.Drawing.Size(242, 25);
            this.lblSpikes.TabIndex = 5;
            this.lblSpikes.Text = "Don\'t step on the spikes";
            // 
            // picKey
            // 
            this.picKey.BackColor = System.Drawing.Color.Transparent;
            this.picKey.Image = global::CPTGameV._1_BenM_.Properties.Resources.GoldKey;
            this.picKey.Location = new System.Drawing.Point(57, 340);
            this.picKey.Name = "picKey";
            this.picKey.Size = new System.Drawing.Size(100, 50);
            this.picKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picKey.TabIndex = 6;
            this.picKey.TabStop = false;
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.BackColor = System.Drawing.Color.Transparent;
            this.lblKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeys.Location = new System.Drawing.Point(182, 352);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(389, 25);
            this.lblKeys.TabIndex = 7;
            this.lblKeys.Text = "Collect the keys to get to the next level!";
            this.lblKeys.Click += new System.EventHandler(this.lblKeys_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoHome.Location = new System.Drawing.Point(504, 1);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(126, 42);
            this.btnGoHome.TabIndex = 8;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // picDiamond
            // 
            this.picDiamond.BackColor = System.Drawing.Color.Transparent;
            this.picDiamond.Image = global::CPTGameV._1_BenM_.Properties.Resources.diamond;
            this.picDiamond.Location = new System.Drawing.Point(57, 144);
            this.picDiamond.Name = "picDiamond";
            this.picDiamond.Size = new System.Drawing.Size(100, 50);
            this.picDiamond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDiamond.TabIndex = 9;
            this.picDiamond.TabStop = false;
            // 
            // lblPowerUps
            // 
            this.lblPowerUps.AutoSize = true;
            this.lblPowerUps.BackColor = System.Drawing.Color.Transparent;
            this.lblPowerUps.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerUps.Location = new System.Drawing.Point(182, 156);
            this.lblPowerUps.Name = "lblPowerUps";
            this.lblPowerUps.Size = new System.Drawing.Size(391, 25);
            this.lblPowerUps.TabIndex = 10;
            this.lblPowerUps.Text = "Collect the diamonds to get extra points";
            // 
            // frmHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CPTGameV._1_BenM_.Properties.Resources.MenuBackground1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 463);
            this.Controls.Add(this.lblPowerUps);
            this.Controls.Add(this.picDiamond);
            this.Controls.Add(this.btnGoHome);
            this.Controls.Add(this.lblKeys);
            this.Controls.Add(this.picKey);
            this.Controls.Add(this.lblSpikes);
            this.Controls.Add(this.picSpikes);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.picCash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblArrowKeys);
            this.Name = "frmHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.frmHelp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDiamond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArrowKeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCash;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.PictureBox picSpikes;
        private System.Windows.Forms.Label lblSpikes;
        private System.Windows.Forms.PictureBox picKey;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.PictureBox picDiamond;
        private System.Windows.Forms.Label lblPowerUps;
    }
}