/// HIGH SCORE FORM
///
/// This form displays the highscore board and allows the player too
/// add their score to the leaderboard.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;            //Used for file management
using Newtonsoft.Json;      //Used for reading high score data

namespace FallingBlockGame
{
    public partial class frmHighScore : Form
    {
        public int iScore;                              //INTEGER used to store the current score
        bool scoreAdded;                                //BOOLEAN used to store whether a score has been added
        List<HighScoreItem> highScores;                 //List of HighScoreItem Record for storing High Score Board
        string sWindowTitle = Application.ProductName;  //STRING used to store the window title

        //Declare record to store item in high score list
        public class HighScoreItem
        {
            public string Name { get; set; }    //STRING used to store player name
            public int Score { get; set; }      //INTEGER used to store player score
        }

        //Run when the form is initialising
        public frmHighScore()
        {

            //Initialize all components of the form
            InitializeComponent();
        }

        //Runs when the form is loaded
        private void frmHighScore_Load(object sender, EventArgs e)
        {

            //Set window title
            this.Text = sWindowTitle + " | Game Over";

            //Output message which includes score
            lblOutput.Text = "You finished with a score of " + Convert.ToString(iScore);

            //If the highscores.json file exists, load the highscore data from it
            if (File.Exists(Application.StartupPath + @"\highscores.json") == true)
            {

                Int16 iLoop;      //INTEGER used to store loop value
                Int16 iLoopUntil; //INTEGER used to store value loop finishes at
                
                //Declare variable used to open high score file
                StreamReader streamReaderhighScores;

                //Open highscore.json file
                streamReaderhighScores = new StreamReader(Application.StartupPath + @"\highscores.json");

                //Declare STRING and set contents of the highscores.json file
                string sHighScoreJson = streamReaderhighScores.ReadToEnd();

                //Attempt to deserialize the json data
                try
                {

                    //Deserialize Json for high scores
                    highScores = JsonConvert.DeserializeObject<List<HighScoreItem>>(sHighScoreJson);

                }

                //If the deserialization failed
                catch
                {

                    //Deserialize blank json data
                    highScores = JsonConvert.DeserializeObject<List<HighScoreItem>>("[]");
                }

				//Update highscores displayed
                displayHighScores();

                //Close highscore.json file
                streamReaderhighScores.Close();
            }

            //Otherwise, no highscores.json file exists
            else
            {

                //Deserialize blank json data
                highScores = JsonConvert.DeserializeObject<List<HighScoreItem>>("[]");
            }

            //Set location in relation to owner form
            this.Location = this.Owner.Location;
        }

        //Runs when the form is closing
        private void frmHighScore_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            //If no score has been added to the highscore board
            if (!scoreAdded)
            {

                //Add score with the name 'Unknown'
                addScoreToHighScores("Unknown", iScore);

            }
        }

        //Adds score to the high score board
        /* 
         *name        STRING which stores the player name
         *score       INTEGER which scores the player score */
        private void addScoreToHighScores(string name, int score)
        {
            //Add new high score item record to the highscores
            highScores.Add(new HighScoreItem());

            //Set new highscore item record name
            highScores[highScores.Count - 1].Name = name;

            //Set new highscore item record score
            highScores[highScores.Count - 1].Score = score;

            //Sort only necessary if there is two or more scores
            if (highScores.Count >= 2)
            {
                //BEGIN BUBBLE SORTING HIGHSCORES

                Int16 i;            //INTEGER used for sorting
                Int16 j;            //INTEGER used for sorting
                int tempScore;      //INTEGER used for swapping scores
                string tempName;    //STRING used for swapping names
                bool swapped;       //BOOLEAN used to detect whether a swap has been made in a pass

                //Set i to the highest index in highscores list
                i = (Int16)(highScores.Count - 1);

                //Loop until i is no longer bigger than 0
                //  OR swapped boolean flag becomes false
                do
                {

                    //Set j to i
                    j = i;

                    //Set swapped boolean flag to false
                    swapped = false;

                    //Loop until j is no longer bigger than 0
                    do
                    {

                        //If highscore[j].Score > highScores[j - 1].Score
                        if (highScores[j].Score > highScores[j - 1].Score)
                        {

                            //Store highScores[j] in temporary variables
                            tempScore = highScores[j].Score;
                            tempName = highScores[j].Name;

                            //Set highScores[j] to highScores[j - 1]
                            highScores[j].Score = highScores[j - 1].Score;
                            highScores[j].Name = highScores[j - 1].Name;

                            //Set highScores[j - 1] to the values in the temporary variables
                            highScores[j - 1].Score = tempScore;
                            highScores[j - 1].Name = tempName;

                            //Set swapped boolean flag to true
                            swapped = true;
                        }

                        //Take one away from j
                        j = (Int16)(j - 1);

                        //Loop again
                    } while (j > 0);

                    //Take one away from i
                    i = (Int16)(i - 1);

                    //Loop again
                } while (i > 0 && swapped == true);
            }

            //Displays the high scores in the list boxes
            displayHighScores();

            //Declare variable used to write high score file
            StreamWriter streamWriterhighScores;

            //Start writing to highscore.json file
            streamWriterhighScores = new StreamWriter(Application.StartupPath + @"\highScores.json");

            //Generate JSON string from highscroes
            string sHighScoreJson = JsonConvert.SerializeObject(highScores);

            //Write JSON string to file
            streamWriterhighScores.Write(sHighScoreJson);

            //Close file
            streamWriterhighScores.Close();

            //Set score added boolean flag to true
            scoreAdded = true;
        }

        //Runs when the add score button is click
        private void cmdAddScore_Click(object sender, EventArgs e)
        {
            //If no score has been added to the highscore board
            if (!scoreAdded)
            {

                //Add score with the name from the name text box
                addScoreToHighScores(txtName.Text, iScore);

                //Disable the name text box
                txtName.Enabled = false;

                //Disable the add score command button
                cmdAddScore.Enabled = false;
            }
        }

        //Start a new game
        private void playAgain()
        {

            //If no score has been added to the highscore board
            if (!scoreAdded)
            {

                //Add score with the name 'Unknown'
                addScoreToHighScores("Unknown", iScore);
            }

            //Create a new instance of the form 'frmGamePlay'
            frmGamePlay frmGamePlay = new frmGamePlay();

            //Hide the current form
            this.Hide();

            //Show the newly created form
            frmGamePlay.ShowDialog(this);

            //Close the current form
            this.Close();
        }

        //Clears the highscores from the listboxes and the highscores.json file
        private void clearHighScores()
        {

            //Display confirmation dialog with message 'Are you sure you want to clear the high score board?' and title 'Clear high scores?'
            DialogResult DialogResultClearScores = MessageBox.Show("Are you sure you want to clear the high score board?",
                                                                    "Clear high scores?",
                                                                    MessageBoxButtons.YesNo);

            //If the user confirmed their decision
            if (DialogResultClearScores == DialogResult.Yes)
            {
                //Deserialize blank json data
                highScores = JsonConvert.DeserializeObject<List<HighScoreItem>>("[]");

                //Declare variable used to write high score file
                StreamWriter streamWriterhighScores;

                //Start writing to highscore.json file
                streamWriterhighScores = new StreamWriter(Application.StartupPath + @"\highScores.json");

                //Write blank JSON string to file
                streamWriterhighScores.Write("[]");

                //Close file
                streamWriterhighScores.Close();

                //Display and update the highscore list boxes so no scores exist
                displayHighScores();

                //Set scoreAdded to false
                scoreAdded = false;

                //Enable name text box
                txtName.Enabled = true;

                //Enable add command button
                cmdAddScore.Enabled = true;
            }
        }

        //Displays the high scores in the list boxes
        private void displayHighScores()
        {

            //Clear list box holding high score scores
            listHighScoresScores.Items.Clear();

            //Clear list box holding high score names
            listHighScoresNames.Items.Clear();

            Int16 iLoop;          //INTEGER used to store value of loop when looping
            Int16 iLoopUntil;     //INTEGER used to store how many times to loop

            //If less than 10 highscores
            if (highScores.Count <= 10)
            {

                //Set variable so that loop only loops for existing highscores
                iLoopUntil = (Int16)(highScores.Count - 1);
            }

            else
            {

                //Set variable so that loop loops 10 times
                iLoopUntil = 9;
            }

            //Loop for a maximum of the first 10 highscores
            for (iLoop = 0; iLoop <= iLoopUntil; iLoop++)
            {

                //Add name to high score name list box
                listHighScoresNames.Items.Add(highScores[iLoop].Name);

                //Add score to high score scores list box
                listHighScoresScores.Items.Add(Convert.ToString(highScores[iLoop].Score));
            }
        }

        //Runs when the play again button is clicked
        private void cmdPlayAgain_Click(object sender, EventArgs e)
        {

            //Start a new game
            playAgain();
        }

        //Runs when the main menu button is clicked
        private void cmdMainMenu_Click(object sender, EventArgs e)
        {

            //If no score has been added to the highscore board
            if (!scoreAdded)
            {

                //Add score with the name 'Unknown'
                addScoreToHighScores("Unknown", iScore);

            }

            //Create a new instance of the form 'frmMenu'
            frmMenu frmMenu = new frmMenu();

            //Hide the current form
            this.Hide();

            //Show the newly created form
            frmMenu.ShowDialog(this);

            //Close the current form
            this.Close();
        }

        /**************************
         **MENU STRIP ITEM EVENTS**
         **************************/
        //Runs when menu strip reset button is pressed
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Start a new game
            playAgain();
        }

        //Runs when menu strip about button is pressed
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Create a new instance of the form 'frmAbout'
            frmAbout frmAbout = new frmAbout();

            //Show the newly created form
            frmAbout.ShowDialog(this);
        }

        //Runs when menu strip how to play button is pressed
        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Create a new instance of the form 'frmAbout'
            frmHowToPlay frmHowToPlay = new frmHowToPlay();

            //Show the newly created form
            frmHowToPlay.ShowDialog(this);
        }

        //Runs when menu strip clear highscores menu strip item is clicked
        private void clearHighScoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Clears the highscores from the listboxes and the highscores.json file
            clearHighScores();
        }
    }
}
