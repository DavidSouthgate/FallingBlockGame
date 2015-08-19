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
            this.lblPlayAgain = new System.Windows.Forms.Label();
            this.listHighScoresWeb = new System.Windows.Forms.ListBox();
            this.lmlMainMenu = new System.Windows.Forms.Label();
            this.listHighScoresScores = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.White;
            this.lblOutput.Location = new System.Drawing.Point(12, 79);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(476, 32);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "You finished with a score of XXXX";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameOver
            // 
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.White;
            this.lblGameOver.Location = new System.Drawing.Point(12, 23);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(476, 56);
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
            this.listHighScoresNames.ItemHeight = 20;
            this.listHighScoresNames.Location = new System.Drawing.Point(95, 202);
            this.listHighScoresNames.Name = "listHighScoresNames";
            this.listHighScoresNames.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listHighScoresNames.Size = new System.Drawing.Size(207, 200);
            this.listHighScoresNames.TabIndex = 191;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(96, 140);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 26);
            this.txtName.TabIndex = 195;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.ForeColor = System.Drawing.Color.White;
            this.lblEnterName.Location = new System.Drawing.Point(91, 117);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(98, 20);
            this.lblEnterName.TabIndex = 194;
            this.lblEnterName.Text = "Enter Name:";
            // 
            // cmdAddScore
            // 
            this.cmdAddScore.Location = new System.Drawing.Point(96, 173);
            this.cmdAddScore.Name = "cmdAddScore";
            this.cmdAddScore.Size = new System.Drawing.Size(308, 23);
            this.cmdAddScore.TabIndex = 196;
            this.cmdAddScore.Text = "Add Score";
            this.cmdAddScore.UseVisualStyleBackColor = true;
            this.cmdAddScore.Click += new System.EventHandler(this.cmdAddScore_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.highScoresToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 197;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.resetToolStripMenuItem.Text = "Play Again";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // highScoresToolStripMenuItem
            // 
            this.highScoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHighScoresToolStripMenuItem});
            this.highScoresToolStripMenuItem.Name = "highScoresToolStripMenuItem";
            this.highScoresToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.highScoresToolStripMenuItem.Text = "High Scores";
            // 
            // clearHighScoresToolStripMenuItem
            // 
            this.clearHighScoresToolStripMenuItem.Name = "clearHighScoresToolStripMenuItem";
            this.clearHighScoresToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.clearHighScoresToolStripMenuItem.Text = "Clear High Scores";
            this.clearHighScoresToolStripMenuItem.Click += new System.EventHandler(this.clearHighScoresToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.howToPlayToolStripMenuItem.Text = "How to Play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblPlayAgain
            // 
            this.lblPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayAgain.ForeColor = System.Drawing.Color.White;
            this.lblPlayAgain.Image = global::FallingBlockGame.Properties.Resources.button;
            this.lblPlayAgain.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPlayAgain.Location = new System.Drawing.Point(36, 530);
            this.lblPlayAgain.Margin = new System.Windows.Forms.Padding(0);
            this.lblPlayAgain.Name = "lblPlayAgain";
            this.lblPlayAgain.Size = new System.Drawing.Size(210, 51);
            this.lblPlayAgain.TabIndex = 198;
            this.lblPlayAgain.Text = "Play Again";
            this.lblPlayAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayAgain.Click += new System.EventHandler(this.lblPlayAgain_Click);
            // 
            // listHighScoresWeb
            // 
            this.listHighScoresWeb.FormattingEnabled = true;
            this.listHighScoresWeb.Location = new System.Drawing.Point(556, 202);
            this.listHighScoresWeb.Name = "listHighScoresWeb";
            this.listHighScoresWeb.Size = new System.Drawing.Size(301, 277);
            this.listHighScoresWeb.TabIndex = 199;
            // 
            // lmlMainMenu
            // 
            this.lmlMainMenu.BackColor = System.Drawing.Color.Transparent;
            this.lmlMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lmlMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmlMainMenu.ForeColor = System.Drawing.Color.White;
            this.lmlMainMenu.Image = global::FallingBlockGame.Properties.Resources.button;
            this.lmlMainMenu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lmlMainMenu.Location = new System.Drawing.Point(255, 530);
            this.lmlMainMenu.Margin = new System.Windows.Forms.Padding(0);
            this.lmlMainMenu.Name = "lmlMainMenu";
            this.lmlMainMenu.Size = new System.Drawing.Size(210, 51);
            this.lmlMainMenu.TabIndex = 200;
            this.lmlMainMenu.Text = "Main Menu";
            this.lmlMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lmlMainMenu.Click += new System.EventHandler(this.lmlMainMenu_Click);
            // 
            // listHighScoresScores
            // 
            this.listHighScoresScores.BackColor = System.Drawing.Color.Black;
            this.listHighScoresScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listHighScoresScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHighScoresScores.ForeColor = System.Drawing.Color.White;
            this.listHighScoresScores.FormattingEnabled = true;
            this.listHighScoresScores.ItemHeight = 20;
            this.listHighScoresScores.Location = new System.Drawing.Point(308, 202);
            this.listHighScoresScores.Name = "listHighScoresScores";
            this.listHighScoresScores.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listHighScoresScores.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listHighScoresScores.Size = new System.Drawing.Size(96, 200);
            this.listHighScoresScores.TabIndex = 201;
            // 
            // frmHighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(500, 590);
            this.Controls.Add(this.listHighScoresScores);
            this.Controls.Add(this.lmlMainMenu);
            this.Controls.Add(this.listHighScoresWeb);
            this.Controls.Add(this.lblPlayAgain);
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
        private System.Windows.Forms.Label lblPlayAgain;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.ListBox listHighScoresWeb;
        private System.Windows.Forms.Label lmlMainMenu;
        private System.Windows.Forms.ListBox listHighScoresScores;
        private System.Windows.Forms.ToolStripMenuItem highScoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHighScoresToolStripMenuItem;
    }
}