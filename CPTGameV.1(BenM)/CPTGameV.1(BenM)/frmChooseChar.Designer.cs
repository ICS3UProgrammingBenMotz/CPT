namespace CPTGameV._1_BenM_
{
    partial class frmChooseChar
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
            this.picComandoGuy = new System.Windows.Forms.PictureBox();
            this.picMario = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picComandoGuy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picComandoGuy
            // 
            this.picComandoGuy.BackColor = System.Drawing.Color.Transparent;
            this.picComandoGuy.Image = global::CPTGameV._1_BenM_.Properties.Resources.playerGuy;
            this.picComandoGuy.Location = new System.Drawing.Point(108, 96);
            this.picComandoGuy.Name = "picComandoGuy";
            this.picComandoGuy.Size = new System.Drawing.Size(87, 116);
            this.picComandoGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picComandoGuy.TabIndex = 1;
            this.picComandoGuy.TabStop = false;
            this.picComandoGuy.Click += new System.EventHandler(this.picComandoGuy_Click);
            // 
            // picMario
            // 
            this.picMario.BackColor = System.Drawing.Color.Transparent;
            this.picMario.Image = global::CPTGameV._1_BenM_.Properties.Resources.Small_Mario_NSMBU;
            this.picMario.Location = new System.Drawing.Point(394, 96);
            this.picMario.Name = "picMario";
            this.picMario.Size = new System.Drawing.Size(87, 116);
            this.picMario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMario.TabIndex = 2;
            this.picMario.TabStop = false;
            this.picMario.Click += new System.EventHandler(this.picMario_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CPTGameV._1_BenM_.Properties.Resources.gladiator_5;
            this.pictureBox2.Location = new System.Drawing.Point(263, 268);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblPick
            // 
            this.lblPick.AutoSize = true;
            this.lblPick.BackColor = System.Drawing.Color.Transparent;
            this.lblPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPick.Location = new System.Drawing.Point(177, 38);
            this.lblPick.Name = "lblPick";
            this.lblPick.Size = new System.Drawing.Size(234, 24);
            this.lblPick.TabIndex = 4;
            this.lblPick.Text = "Choose Your Character!";
            // 
            // frmChooseChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CPTGameV._1_BenM_.Properties.Resources.MenuBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 424);
            this.Controls.Add(this.lblPick);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.picMario);
            this.Controls.Add(this.picComandoGuy);
            this.Name = "frmChooseChar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose your character";
            this.Load += new System.EventHandler(this.frmChooseChar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picComandoGuy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picComandoGuy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblPick;
        private System.Windows.Forms.PictureBox picMario;
    }
}