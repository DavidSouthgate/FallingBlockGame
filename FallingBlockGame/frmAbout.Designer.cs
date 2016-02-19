namespace FallingBlockGame
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.lblApplicationTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblApplicationVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLinkFontCpyRght = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApplicationTitle
            // 
            this.lblApplicationTitle.AutoSize = true;
            this.lblApplicationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationTitle.ForeColor = System.Drawing.Color.White;
            this.lblApplicationTitle.Location = new System.Drawing.Point(192, 14);
            this.lblApplicationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationTitle.Name = "lblApplicationTitle";
            this.lblApplicationTitle.Size = new System.Drawing.Size(314, 47);
            this.lblApplicationTitle.TabIndex = 0;
            this.lblApplicationTitle.Text = "Application Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FallingBlockGame.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(18, -26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblApplicationVersion
            // 
            this.lblApplicationVersion.AutoSize = true;
            this.lblApplicationVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationVersion.ForeColor = System.Drawing.Color.White;
            this.lblApplicationVersion.Location = new System.Drawing.Point(195, 62);
            this.lblApplicationVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApplicationVersion.Name = "lblApplicationVersion";
            this.lblApplicationVersion.Size = new System.Drawing.Size(220, 29);
            this.lblApplicationVersion.TabIndex = 2;
            this.lblApplicationVersion.Text = "Application Version";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(192, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "© David Southgate  2015-2016";
            // 
            // lblLinkFontCpyRght
            // 
            this.lblLinkFontCpyRght.LinkColor = System.Drawing.Color.Silver;
            this.lblLinkFontCpyRght.Location = new System.Drawing.Point(196, 143);
            this.lblLinkFontCpyRght.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLinkFontCpyRght.Name = "lblLinkFontCpyRght";
            this.lblLinkFontCpyRght.Size = new System.Drawing.Size(428, 51);
            this.lblLinkFontCpyRght.TabIndex = 4;
            this.lblLinkFontCpyRght.TabStop = true;
            this.lblLinkFontCpyRght.Text = "Gubblebum Font is Copyright (c) by and a Trademark (tm) of Tjarda Koster [Free fo" +
    "r non-commercial use]";
            this.lblLinkFontCpyRght.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkFontCpyRght_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(642, 200);
            this.Controls.Add(this.lblLinkFontCpyRght);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApplicationVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblApplicationTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmAbout";
            this.Text = "frmAbout";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplicationTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblApplicationVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblLinkFontCpyRght;
    }
}