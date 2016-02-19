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
            this.cmdPlay = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdHowToPlay = new System.Windows.Forms.Button();
            this.cmdAboutGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FallingBlockGame.Properties.Resources.titleLogo;
            this.pictureBox1.Location = new System.Drawing.Point(90, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(570, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 199;
            this.pictureBox1.TabStop = false;
            // 
            // cmdPlay
            // 
            this.cmdPlay.BackgroundImage = global::FallingBlockGame.Properties.Resources.button;
            this.cmdPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPlay.FlatAppearance.BorderSize = 0;
            this.cmdPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPlay.ForeColor = System.Drawing.Color.White;
            this.cmdPlay.Location = new System.Drawing.Point(217, 438);
            this.cmdPlay.Name = "cmdPlay";
            this.cmdPlay.Size = new System.Drawing.Size(317, 63);
            this.cmdPlay.TabIndex = 200;
            this.cmdPlay.Text = "Start Game";
            this.cmdPlay.UseVisualStyleBackColor = true;
            this.cmdPlay.Click += new System.EventHandler(this.cmdPlay_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.BackgroundImage = global::FallingBlockGame.Properties.Resources.button;
            this.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdExit.FlatAppearance.BorderSize = 0;
            this.cmdExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.ForeColor = System.Drawing.Color.White;
            this.cmdExit.Location = new System.Drawing.Point(217, 696);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(317, 63);
            this.cmdExit.TabIndex = 203;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdHowToPlay
            // 
            this.cmdHowToPlay.BackgroundImage = global::FallingBlockGame.Properties.Resources.button;
            this.cmdHowToPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdHowToPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdHowToPlay.FlatAppearance.BorderSize = 0;
            this.cmdHowToPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdHowToPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdHowToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHowToPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdHowToPlay.ForeColor = System.Drawing.Color.White;
            this.cmdHowToPlay.Location = new System.Drawing.Point(217, 610);
            this.cmdHowToPlay.Name = "cmdHowToPlay";
            this.cmdHowToPlay.Size = new System.Drawing.Size(317, 63);
            this.cmdHowToPlay.TabIndex = 202;
            this.cmdHowToPlay.Text = "How to Play";
            this.cmdHowToPlay.UseVisualStyleBackColor = true;
            this.cmdHowToPlay.Click += new System.EventHandler(this.cmdHowToPlay_Click);
            // 
            // cmdAboutGame
            // 
            this.cmdAboutGame.BackgroundImage = global::FallingBlockGame.Properties.Resources.button;
            this.cmdAboutGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdAboutGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAboutGame.FlatAppearance.BorderSize = 0;
            this.cmdAboutGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdAboutGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdAboutGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAboutGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAboutGame.ForeColor = System.Drawing.Color.White;
            this.cmdAboutGame.Location = new System.Drawing.Point(217, 524);
            this.cmdAboutGame.Name = "cmdAboutGame";
            this.cmdAboutGame.Size = new System.Drawing.Size(317, 63);
            this.cmdAboutGame.TabIndex = 201;
            this.cmdAboutGame.Text = "About Game";
            this.cmdAboutGame.UseVisualStyleBackColor = true;
            this.cmdAboutGame.Click += new System.EventHandler(this.cmdAboutGame_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(750, 908);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdHowToPlay);
            this.Controls.Add(this.cmdAboutGame);
            this.Controls.Add(this.cmdPlay);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdPlay;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdHowToPlay;
        private System.Windows.Forms.Button cmdAboutGame;
    }
}