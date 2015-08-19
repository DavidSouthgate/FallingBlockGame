/// ABOUT GAME FORM
///
/// This form details information about the game including the creator
/// and the version.

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
    public partial class frmAbout : Form
    {

        //Run when the form is initialising
        public frmAbout()
        {

            //Initialize all components of the form
            InitializeComponent();
        }

        //Run when the form has loaded
        private void frmAbout_Load(object sender, EventArgs e)
        {
            //Set Window Title
            this.Text = Application.ProductName + " | About";

            //Set application title
            lblApplicationTitle.Text = Application.ProductName;
            
            //Set application version
            lblApplicationVersion.Text = Application.ProductVersion;
        }

        //Runs when the font copyright notice is clicked
        private void lblLinkFontCpyRght_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //Show information page about font
            System.Windows.Forms.Help.ShowHelp(null, "http://www.deviantart.com/art/Font-GUBBLEBUM-free-60010957");
        }
    }
}
