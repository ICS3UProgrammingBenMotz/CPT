namespace CPTGameV._1_BenM_
{
    partial class frmLvlTwo
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
            this.picBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // picBackground
            // 
            this.picBackground.BackColor = System.Drawing.Color.Transparent;
            this.picBackground.BackgroundImage = global::CPTGameV._1_BenM_.Properties.Resources.lvl2Background;
            this.picBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBackground.Location = new System.Drawing.Point(-46, -176);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(2004, 643);
            this.picBackground.TabIndex = 0;
            this.picBackground.TabStop = false;
            // 
            // frmLvlTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 463);
            this.Controls.Add(this.picBackground);
            this.Name = "frmLvlTwo";
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground;
    }
}