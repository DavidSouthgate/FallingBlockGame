namespace FallingBlockGame
{
    partial class frmHighScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHighScore));
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.listHighScoresNames = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.cmdAddScore = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHighScoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listHighScoresWeb = new System.Windows.Forms.ListBox();
            this.listHighScoresScores = new System.Windows.Forms.ListBox();
            this.cmdPlayAgain = new System.Windows.Forms.Button();
            this.cmdMainMenu = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(18, 122);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(714, 49);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "You finished with a score of XXXX";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameOver
            // 
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.White;
            this.lblGameOver.Location = new System.Drawing.Point(18, 35);
            this.lblGameOver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(714, 86);
            this.lblGameOver.TabIndex = 1;
            this.lblGameOver.Text = "Game Over!";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listHighScoresNames
            // 
            this.listHighScoresNames.BackColor = System.Drawing.Color.Black;
            this.listHighScoresNames.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHighScoresNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHighScoresNames.ForeColor = System.Drawing.Color.White;
            this.listHighScoresNames.FormattingEnabled = true;
            this.listHighScoresNames.ItemHeight = 29;
            this.listHighScoresNames.Location = new System.Drawing.Point(141, 311);
            this.listHighScoresNames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listHighScoresNames.Name = "listHighScoresNames";
            this.listHighScoresNames.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listHighScoresNames.Size = new System.Drawing.Size(310, 493);
            this.listHighScoresNames.TabIndex = 191;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(74, 4);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(144, 215);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(460, 35);
            this.txtName.TabIndex = 195;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.ForeColor = System.Drawing.Color.White;
            this.lblEnterName.Location = new System.Drawing.Point(136, 180);
            this.lblEnterName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(147, 29);
            this.lblEnterName.TabIndex = 194;
            this.lblEnterName.Text = "Enter Name:";
            // 
            // cmdAddScore
            // 
            this.cmdAddScore.Location = new System.Drawing.Point(144, 266);
            this.cmdAddScore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdAddScore.Name = "cmdAddScore";
            this.cmdAddScore.Size = new System.Drawing.Size(462, 35);
            this.cmdAddScore.TabIndex = 196;
            this.cmdAddScore.Text = "Add Score";
            this.cmdAddScore.UseVisualStyleBackColor = true;
            this.cmdAddScore.Click += new System.EventHandler(this.cmdAddScore_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.highScoresToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(750, 35);
            this.menuStrip1.TabIndex = 197;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
            this.resetToolStripMenuItem.Text = "Play Again";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHighScoresToolStripMenuItem});
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.highScoresToolStripMenuItem.Text = "High Scores";
            // 
            // clearHighScoresToolStripMenuItem
            // 
            this.clearHighScoresToolStripMenuItem.Name = "clearHighScoresToolStripMenuItem";
            this.clearHighScoresToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
            this.clearHighScoresToolStripMenuItem.Text = "Clear High Scores";
            this.clearHighScoresToolStripMenuItem.Click += new System.EventHandler(this.clearHighScoresToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.howToPlayToolStripMenuItem.Text = "How to Play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // listHighScoresWeb
            // 
            this.listHighScoresWeb.FormattingEnabled = true;
            this.listHighScoresWeb.ItemHeight = 20;
            this.listHighScoresWeb.Location = new System.Drawing.Point(834, 311);
            this.listHighScoresWeb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listHighScoresWeb.Name = "listHighScoresWeb";
            this.listHighScoresWeb.Size = new System.Drawing.Size(450, 424);
            this.listHighScoresWeb.TabIndex = 199;
            // 
            // listHighScoresScores
            // 
            this.listHighScoresScores.BackColor = System.Drawing.Color.Black;
            this.listHighScoresScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHighScoresScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHighScoresScores.ForeColor = System.Drawing.Color.White;
            this.listHighScoresScores.FormattingEnabled = true;
            this.listHighScoresScores.ItemHeight = 29;
            this.listHighScoresScores.Location = new System.Drawing.Point(462, 311);
            this.listHighScoresScores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listHighScoresScores.Name = "listHighScoresScores";
            this.listHighScoresScores.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listHighScoresScores.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listHighScoresScores.Size = new System.Drawing.Size(144, 493);
            this.listHighScoresScores.TabIndex = 201;
            // 
            // cmdPlayAgain
            // 
            this.cmdPlayAgain.BackgroundImage = global::FallingBlockGame.Properties.Resources.button;
            this.cmdPlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPlayAgain.FlatAppearance.BorderSize = 0;
            this.cmdPlayAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdPlayAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPlayAgain.ForeColor = System.Drawing.Color.White;
            this.cmdPlayAgain.Location = new System.Drawing.Point(53, 820);
            this.cmdPlayAgain.Name = "cmdPlayAgain";
            this.cmdPlayAgain.Size = new System.Drawing.Size(317, 63);
            this.cmdPlayAgain.TabIndex = 202;
            this.cmdPlayAgain.Text = "Play Again";
            this.cmdPlayAgain.UseVisualStyleBackColor = true;
            this.cmdPlayAgain.Click += new System.EventHandler(this.cmdPlayAgain_Click);
            // 
            // cmdMainMenu
            // 
            this.cmdMainMenu.BackgroundImage = global::FallingBlockGame.Properties.Resources.button;
            this.cmdMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdMainMenu.FlatAppearance.BorderSize = 0;
            this.cmdMainMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cmdMainMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cmdMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMainMenu.ForeColor = System.Drawing.Color.White;
            this.cmdMainMenu.Location = new System.Drawing.Point(381, 820);
            this.cmdMainMenu.Name = "cmdMainMenu";
            this.cmdMainMenu.Size = new System.Drawing.Size(317, 63);
            this.cmdMainMenu.TabIndex = 203;
            this.cmdMainMenu.Text = "Main Menu";
            this.cmdMainMenu.UseVisualStyleBackColor = true;
            this.cmdMainMenu.Click += new System.EventHandler(this.cmdMainMenu_Click);
            // 
            // frmHighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(750, 908);
            this.Controls.Add(this.cmdMainMenu);
            this.Controls.Add(this.cmdPlayAgain);
            this.Controls.Add(this.listHighScoresScores);
            this.Controls.Add(this.listHighScoresWeb);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.cmdAddScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEnterName);
            this.Controls.Add(this.listHighScoresNames);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblOutput);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmHighScore";
            this.Text = "frmHighScore";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHighScore_Closing);
            this.Load += new System.EventHandler(this.frmHighScore_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.ListBox listHighScoresNames;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Button cmdAddScore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ListBox listHighScoresWeb;
        private System.Windows.Forms.ListBox listHighScoresScores;
        private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHighScoresToolStripMenuItem;
        private System.Windows.Forms.Button cmdPlayAgain;
        private System.Windows.Forms.Button cmdMainMenu;
    }
}