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
            this.lblApplicationTitle.Location = new System.Drawing.Point(128, 9);
            this.lblApplicationTitle.Name = "lblApplicationTitle";
            this.lblApplicationTitle.Size = new System.Drawing.Size(206, 31);
            this.lblApplicationTitle.TabIndex = 0;
            this.lblApplicationTitle.Text = "Application Title";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FallingBlockGame.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, -17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblApplicationVersion
            // 
            this.lblApplicationVersion.AutoSize = true;
            this.lblApplicationVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationVersion.ForeColor = System.Drawing.Color.White;
            this.lblApplicationVersion.Location = new System.Drawing.Point(130, 40);
            this.lblApplicationVersion.Name = "lblApplicationVersion";
            this.lblApplicationVersion.Size = new System.Drawing.Size(145, 20);
            this.lblApplicationVersion.TabIndex = 2;
            this.lblApplicationVersion.Text = "Application Version";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Created by David Southgate";
            // 
            // lblLinkFontCpyRght
            // 
            this.lblLinkFontCpyRght.LinkColor = System.Drawing.Color.Silver;
            this.lblLinkFontCpyRght.Location = new System.Drawing.Point(131, 93);
            this.lblLinkFontCpyRght.Name = "lblLinkFontCpyRght";
            this.lblLinkFontCpyRght.Size = new System.Drawing.Size(285, 33);
            this.lblLinkFontCpyRght.TabIndex = 4;
            this.lblLinkFontCpyRght.TabStop = true;
            this.lblLinkFontCpyRght.Text = "Gubblebum Font is Copyright (c) by and a Trademark (tm) of Tjarda Koster [Free fo" +
    "r non-commercial use]";
            this.lblLinkFontCpyRght.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkFontCpyRght_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(428, 130);
            this.Controls.Add(this.lblLinkFontCpyRght);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblApplicationVersion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblApplicationTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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