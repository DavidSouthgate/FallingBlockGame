/// HOW TO PLAY FORM
///
/// This form displays information about how to play the game. This
/// includes the objective, controls, and other information about
/// playing the game.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FallingBlockGame
{
    public partial class frmHowToPlay : Form
    {
        Panel panelCurrent;                             //Store the currently displayed help panel
        string sWindowTitle = Application.ProductName;  //STRING used to store the window title

        //Run when the form is initialising
        public frmHowToPlay()
        {

            //Initialize all components of the form
            InitializeComponent();
        }

        //Runs when the form is loaded
        private void frmHowToPlay_Load(object sender, EventArgs e)
        {

            //Set window title
            this.Text = sWindowTitle + " | How to Play";

            //Set objectives help screen panel to be displayed
            viewHelp(panelObjective);
        }

        //Used to view a specific help panel
        private void viewHelp(Panel panelHelp)
        {

            //If no current panel exists
            if (panelCurrent != null)
            {
                //Hide the current help panel
                panelCurrent.Visible = false;
            }

            //Set the current help panel to the new help panel
            panelCurrent = panelHelp;

            //Move new help panel to correct position
            panelCurrent.Left = 222;
            panelCurrent.Top = 12;

            //Display new help panel
            panelCurrent.Visible = true;
        }

        //Runs when the objectives button is clicked
        private void lblObjective_Click(object sender, EventArgs e)
        {

            //Display objectives help section
            viewHelp(panelObjective);
        }

        //Runs when the controls button is clicked
        private void lblControls_Click(object sender, EventArgs e)
        {

            //Display objectives help section
            viewHelp(panelControls);
        }

        //Runs when the blocks button is clicked
        private void lblBlocks_Click(object sender, EventArgs e)
        {

            //Display blocks help section
            viewHelp(panelBlocks);
        }

        //Runs when the high scores button is clicked
        private void lblHighScores_Click(object sender, EventArgs e)
        {

            //Display blocks help section
            viewHelp(panelHighScores);
        }

        //Runs when the FAQ button is clicked
        private void lblFAQ_Click(object sender, EventArgs e)
        {

            //Display FAQ help section
            viewHelp(panelFAQ);
        }

        //Runs when the how to play button is clicked
        private void lblExit_Click(object sender, EventArgs e)
        {

            //Close the how to play form
            this.Close();
        }
    }
}
