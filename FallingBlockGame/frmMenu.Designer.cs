namespace FallingBlockGame
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblHowToPlay = new System.Windows.Forms.Label();
            this.lblAboutGame = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FallingBlockGame.Properties.Resources.titleLogo;
            this.pictureBox1.Location = new System.Drawing.Point(60, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 190);
            this.pictureBox1.TabIndex = 199;
            this.pictureBox1.TabStop = false;
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.Color.White;
            this.lblExit.Image = global::FallingBlockGame.Properties.Resources.button;
            this.lblExit.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblExit.Location = new System.Drawing.Point(145, 402);
            this.lblExit.Margin = new System.Windows.Forms.Padding(0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(210, 51);
            this.lblExit.TabIndex = 198;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblHowToPlay
            // 
            this.lblHowToPlay.BackColor = System.Drawing.Color.Transparent;
            this.lblHowToPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHowToPlay.ForeColor = System.Drawing.Color.White;
            this.lblHowToPlay.Image = global::FallingBlockGame.Properties.Resources.button;
            this.lblHowToPlay.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblHowToPlay.Location = new System.Drawing.Point(145, 351);
            this.lblHowToPlay.Margin = new System.Windows.Forms.Padding(0);
            this.lblHowToPlay.Name = "lblHowToPlay";
            this.lblHowToPlay.Size = new System.Drawing.Size(210, 51);
            this.lblHowToPlay.TabIndex = 197;
            this.lblHowToPlay.Text = "How to Play";
            this.lblHowToPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHowToPlay.Click += new System.EventHandler(this.lblHowToPlay_Click);
            // 
            // lblAboutGame
            // 
            this.lblAboutGame.BackColor = System.Drawing.Color.Transparent;
            this.lblAboutGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAboutGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutGame.ForeColor = System.Drawing.Color.White;
            this.lblAboutGame.Image = global::FallingBlockGame.Properties.Resources.button;
            this.lblAboutGame.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblAboutGame.Location = new System.Drawing.Point(145, 300);
            this.lblAboutGame.Margin = new System.Windows.Forms.Padding(0);
            this.lblAboutGame.Name = "lblAboutGame";
            this.lblAboutGame.Size = new System.Drawing.Size(210, 51);
            this.lblAboutGame.TabIndex = 196;
            this.lblAboutGame.Text = "About Game";
            this.lblAboutGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAboutGame.Click += new System.EventHandler(this.lblAboutGame_Click);
            // 
            // lblPlay
            // 
            this.lblPlay.BackColor = System.Drawing.Color.Transparent;
            this.lblPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlay.ForeColor = System.Drawing.Color.White;
            this.lblPlay.Image = global::FallingBlockGame.Properties.Resources.button;
            this.lblPlay.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPlay.Location = new System.Drawing.Point(145, 249);
            this.lblPlay.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(210, 51);
            this.lblPlay.TabIndex = 189;
            this.lblPlay.Text = "Start Game";
            this.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlay.UseMnemonic = false;
            this.lblPlay.Click += new System.EventHandler(this.lblPlay_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 590);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblHowToPlay);
            this.Controls.Add(this.lblAboutGame);
            this.Controls.Add(this.lblPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPlay;
        private System.Windows.Forms.Label lblAboutGame;
        private System.Windows.Forms.Label lblHowToPlay;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}