/// GAME FORM
///
/// This form contains the game. It is played here then the score is
/// transfered to the highscore board form once the game has ended.

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
    public partial class frmGamePlay : Form
    {
        PictureBox[] picBlockGrid;      //Stores control array of picture boxes used to display game
        PictureBox[] picBlockNextGrid;  //Stores control array of picture boxes used to display next block
        Bitmap[] imgBlockImage;         //Stores the images of each block

        bool[,,,] blockShapeArray = new bool[8, 4, 4, 4];   //Declare 4-D array to store the shape of every block
        Int16[,] blockArray = new Int16[18, 10];                //Declare 2-D array to store all the static blocks and their colour

        Int16 iFallingBlockRow = 0;       //INTEGER used to store the row position of falling block
        Int16 iFallingBlockColumn = 0;    //INTEGER used to store the column position of falling block
        Int16 iFallingBlockId = 0;        //INTEGER used to store the block ID of falling block
        Int16 iFallingBlockPos = 0;       //INTEGER used to store the block position (rotation) of falling block
        Int16 iFallingBlockIdNext = 0;    //INTEGER used to store the next falling block ID

        Int16 iScoreLines = 0;            //INTEGER used to store the number of lines destroyed
        Int32 iScore = 0;                 //INTEGER used to store the the current score
        Int16 iLevel = 1;                 //INTEGER used to store the the current level

        bool bGamePaused = false;       //BOOLEAN used to store the whether the game is paused or not

        const Int16 iGameRows = 17;       //CONSTANT INTEGER used to store the number of rows in the game
        const Int16 iGameColumns = 9;     //CONSTANT INTEGER used to store the number of columns in the game
        const Int16 iNumberOfBlocks = 7;  //CONSTANT INTEGER used to store the number of possible blocks

        string sWindowTitle = Application.ProductName;  //STRING used to store the standard window title

        Random randomNumber = new Random();             //Random number generation used for random falling blocks

        //Declare record to store item in high score list
        public class HighScoreItem
        {
            public string Name { get; set; }    //STRING used to store player name
            public int Score { get; set; }      //INTEGER used to store player score
        }

        //Run when the form is initialising
        public frmGamePlay()
        {

            //Initialize all components of the form
            InitializeComponent();
        }

        //Run when the form has loaded
        private void Form1_Load(object sender, EventArgs e)
        {

            //Put all of the picture boxes used to display the game into a control array
            picBlockGrid = new PictureBox[] { picBlockGrid1, picBlockGrid2, picBlockGrid3, picBlockGrid4, picBlockGrid5,
                                                picBlockGrid6, picBlockGrid7, picBlockGrid8, picBlockGrid9, picBlockGrid10,
                                                picBlockGrid11, picBlockGrid12, picBlockGrid13, picBlockGrid14, picBlockGrid15,
                                                picBlockGrid16, picBlockGrid17, picBlockGrid18, picBlockGrid19, picBlockGrid20,
                                                picBlockGrid21, picBlockGrid22, picBlockGrid23, picBlockGrid24, picBlockGrid25,
                                                picBlockGrid26, picBlockGrid27, picBlockGrid28, picBlockGrid29, picBlockGrid30,
                                                picBlockGrid31, picBlockGrid32, picBlockGrid33, picBlockGrid34, picBlockGrid35,
                                                picBlockGrid36, picBlockGrid37, picBlockGrid38, picBlockGrid39, picBlockGrid40,
                                                picBlockGrid41, picBlockGrid42, picBlockGrid43, picBlockGrid44, picBlockGrid45,
                                                picBlockGrid46, picBlockGrid47, picBlockGrid48, picBlockGrid49, picBlockGrid50,
                                                picBlockGrid51, picBlockGrid52, picBlockGrid53, picBlockGrid54, picBlockGrid55,
                                                picBlockGrid56, picBlockGrid57, picBlockGrid58, picBlockGrid59, picBlockGrid60,
                                                picBlockGrid61, picBlockGrid62, picBlockGrid63, picBlockGrid64, picBlockGrid65,
                                                picBlockGrid66, picBlockGrid67, picBlockGrid68, picBlockGrid69, picBlockGrid70,
                                                picBlockGrid71, picBlockGrid72, picBlockGrid73, picBlockGrid74, picBlockGrid75,
                                                picBlockGrid76, picBlockGrid77, picBlockGrid78, picBlockGrid79, picBlockGrid80,
                                                picBlockGrid81, picBlockGrid82, picBlockGrid83, picBlockGrid84, picBlockGrid85,
                                                picBlockGrid86, picBlockGrid87, picBlockGrid88, picBlockGrid89, picBlockGrid90,
                                                picBlockGrid91, picBlockGrid92, picBlockGrid93, picBlockGrid94, picBlockGrid95,
                                                picBlockGrid96, picBlockGrid97, picBlockGrid98, picBlockGrid99, picBlockGrid100,
                                                picBlockGrid101, picBlockGrid102, picBlockGrid103, picBlockGrid104, picBlockGrid105,
                                                picBlockGrid106, picBlockGrid107, picBlockGrid108, picBlockGrid109, picBlockGrid110,
                                                picBlockGrid111, picBlockGrid112, picBlockGrid113, picBlockGrid114, picBlockGrid115,
                                                picBlockGrid116, picBlockGrid117, picBlockGrid118, picBlockGrid119, picBlockGrid120,
                                                picBlockGrid121, picBlockGrid122, picBlockGrid123, picBlockGrid124, picBlockGrid125,
                                                picBlockGrid126, picBlockGrid127, picBlockGrid128, picBlockGrid129, picBlockGrid130,
                                                picBlockGrid131, picBlockGrid132, picBlockGrid133, picBlockGrid134, picBlockGrid135,
                                                picBlockGrid136, picBlockGrid137, picBlockGrid138, picBlockGrid139, picBlockGrid140,
                                                picBlockGrid141, picBlockGrid142, picBlockGrid143, picBlockGrid144, picBlockGrid145,
                                                picBlockGrid146, picBlockGrid147, picBlockGrid148, picBlockGrid149, picBlockGrid150,
                                                picBlockGrid151, picBlockGrid152, picBlockGrid153, picBlockGrid154, picBlockGrid155,
                                                picBlockGrid156, picBlockGrid157, picBlockGrid158, picBlockGrid159, picBlockGrid160,
                                                picBlockGrid161, picBlockGrid162, picBlockGrid163, picBlockGrid164, picBlockGrid165,
                                                picBlockGrid166, picBlockGrid167, picBlockGrid168, picBlockGrid169, picBlockGrid170,
                                                picBlockGrid171, picBlockGrid172, picBlockGrid173, picBlockGrid174, picBlockGrid175,
                                                picBlockGrid176, picBlockGrid177, picBlockGrid178, picBlockGrid179, picBlockGrid180 };

            //Put all of the picture boxes used to display the next block into a control array
            picBlockNextGrid = new PictureBox[] { picBlockNextGrid1, picBlockNextGrid2, picBlockNextGrid3, picBlockNextGrid4,
                                                    picBlockNextGrid5,picBlockNextGrid6, picBlockNextGrid7, picBlockNextGrid8,
                                                    picBlockNextGrid9, picBlockNextGrid10, picBlockNextGrid11, picBlockNextGrid12,
                                                    picBlockNextGrid13, picBlockNextGrid14, picBlockNextGrid15, picBlockNextGrid16 };

            //Put all of the images used for blocks into array (First is null)
            imgBlockImage = new Bitmap[] { null, Properties.Resources.imgBlock1, Properties.Resources.imgBlock2,
                                                Properties.Resources.imgBlock3, Properties.Resources.imgBlock4,
                                                Properties.Resources.imgBlock5, Properties.Resources.imgBlock6,
                                                Properties.Resources.imgBlock7 };

            //Set window title
            this.Text = sWindowTitle;

            //If the highscores.json file exists
            if (File.Exists(Application.StartupPath + @"\highscores.json") == true)
            {

                List<HighScoreItem> highScores;         //Stores the highscore table once it has been opened.
                StreamReader streamReaderHighScores;    //Used to open highscores.json file
                string sHighScoreJson;                  //STRING used to store contents of highscores.json file

                //Open high score file
                streamReaderHighScores = new StreamReader(Application.StartupPath + @"\highscores.json");

                //Set sHighScoreJson to the contects of the high score file
                sHighScoreJson = streamReaderHighScores.ReadToEnd();

                //Attempt to decode JSON string
                try
                {
                    //Decode JSON for high scores and store structure i
                    highScores = JsonConvert.DeserializeObject<List<HighScoreItem>>(sHighScoreJson);
                }

                //If the attempt to decode the JSON string fails
                catch
                {
                    //Decode as empty JSON string
                    highScores = JsonConvert.DeserializeObject<List<HighScoreItem>>("[]");
                }

                //If there are no items in the high score list
                if (highScores.Count == 0)
                {

                    //Set high score label to 0
                    lblHighScore.Text = "0";
                }

                //Otherwise get highscore and set label
                else
                {

                    //Set High Score label to be the first score in file.
                    //      (File should be already sorted unless tampered with)
                    lblHighScore.Text = Convert.ToString(highScores[0].Score);
                }
 
                //Close high score file
                streamReaderHighScores.Close();

            }


            //4D Array Used to store the shape of all blocks and the shape at
            //	each rotation
            //
            //  blockShapeArray[BlockID, BlockRotation, Row, Column]
            //
            blockShapeArray[0, 0, 1, 0] = true; //I Block - Rotation 1
            blockShapeArray[0, 0, 1, 1] = true; //I Block - Rotation 1
            blockShapeArray[0, 0, 1, 2] = true; //I Block - Rotation 1
            blockShapeArray[0, 0, 1, 3] = true; //I Block - Rotation 1
            blockShapeArray[0, 1, 0, 1] = true; //I Block - Rotation 2
            blockShapeArray[0, 1, 1, 1] = true; //I Block - Rotation 2
            blockShapeArray[0, 1, 2, 1] = true; //I Block - Rotation 2
            blockShapeArray[0, 1, 3, 1] = true; //I Block - Rotation 2
            blockShapeArray[0, 2, 1, 0] = true; //I Block - Rotation 3
            blockShapeArray[0, 2, 1, 1] = true; //I Block - Rotation 3
            blockShapeArray[0, 2, 1, 2] = true; //I Block - Rotation 3
            blockShapeArray[0, 2, 1, 3] = true; //I Block - Rotation 3
            blockShapeArray[0, 3, 0, 1] = true; //I Block - Rotation 4
            blockShapeArray[0, 3, 1, 1] = true; //I Block - Rotation 4
            blockShapeArray[0, 3, 2, 1] = true; //I Block - Rotation 4
            blockShapeArray[0, 3, 3, 1] = true; //I Block - Rotation 4
            blockShapeArray[1, 0, 0, 0] = true; //J Block - Rotation 1
            blockShapeArray[1, 0, 1, 0] = true; //J Block - Rotation 1
            blockShapeArray[1, 0, 1, 1] = true; //J Block - Rotation 1
            blockShapeArray[1, 0, 1, 2] = true; //J Block - Rotation 1
            blockShapeArray[1, 1, 0, 1] = true; //J Block - Rotation 2
            blockShapeArray[1, 1, 0, 2] = true; //J Block - Rotation 2
            blockShapeArray[1, 1, 1, 1] = true; //J Block - Rotation 2
            blockShapeArray[1, 1, 2, 1] = true; //J Block - Rotation 2
            blockShapeArray[1, 2, 1, 0] = true; //J Block - Rotation 3
            blockShapeArray[1, 2, 1, 1] = true; //J Block - Rotation 3
            blockShapeArray[1, 2, 1, 2] = true; //J Block - Rotation 3
            blockShapeArray[1, 2, 2, 2] = true; //J Block - Rotation 3
            blockShapeArray[1, 3, 0, 1] = true; //J Block - Rotation 4
            blockShapeArray[1, 3, 1, 1] = true; //J Block - Rotation 4
            blockShapeArray[1, 3, 2, 0] = true; //J Block - Rotation 4
            blockShapeArray[1, 3, 2, 1] = true; //J Block - Rotation 4
            blockShapeArray[2, 0, 0, 2] = true; //L Block - Rotation 1
            blockShapeArray[2, 0, 1, 0] = true; //L Block - Rotation 1
            blockShapeArray[2, 0, 1, 1] = true; //L Block - Rotation 1
            blockShapeArray[2, 0, 1, 2] = true; //L Block - Rotation 1
            blockShapeArray[2, 1, 0, 1] = true; //L Block - Rotation 2
            blockShapeArray[2, 1, 1, 1] = true; //L Block - Rotation 2
            blockShapeArray[2, 1, 2, 1] = true; //L Block - Rotation 2
            blockShapeArray[2, 1, 2, 2] = true; //L Block - Rotation 2
            blockShapeArray[2, 2, 1, 0] = true; //L Block - Rotation 3
            blockShapeArray[2, 2, 1, 1] = true; //L Block - Rotation 3
            blockShapeArray[2, 2, 1, 2] = true; //L Block - Rotation 3
            blockShapeArray[2, 2, 2, 0] = true; //L Block - Rotation 3
            blockShapeArray[2, 3, 0, 0] = true; //L Block - Rotation 4
            blockShapeArray[2, 3, 0, 1] = true; //L Block - Rotation 4
            blockShapeArray[2, 3, 1, 1] = true; //L Block - Rotation 4
            blockShapeArray[2, 3, 2, 1] = true; //L Block - Rotation 4
            blockShapeArray[3, 0, 0, 0] = true; //O Block - Rotation 1
            blockShapeArray[3, 0, 0, 1] = true; //O Block - Rotation 1
            blockShapeArray[3, 0, 1, 0] = true; //O Block - Rotation 1
            blockShapeArray[3, 0, 1, 1] = true; //O Block - Rotation 1
            blockShapeArray[3, 1, 0, 0] = true; //O Block - Rotation 2
            blockShapeArray[3, 1, 0, 1] = true; //O Block - Rotation 2
            blockShapeArray[3, 1, 1, 0] = true; //O Block - Rotation 2
            blockShapeArray[3, 1, 1, 1] = true; //O Block - Rotation 2
            blockShapeArray[3, 2, 0, 0] = true; //O Block - Rotation 3
            blockShapeArray[3, 2, 0, 1] = true; //O Block - Rotation 3
            blockShapeArray[3, 2, 1, 0] = true; //O Block - Rotation 3
            blockShapeArray[3, 2, 1, 1] = true; //O Block - Rotation 3
            blockShapeArray[3, 3, 0, 0] = true; //O Block - Rotation 4
            blockShapeArray[3, 3, 0, 1] = true; //O Block - Rotation 4
            blockShapeArray[3, 3, 1, 0] = true; //O Block - Rotation 4
            blockShapeArray[3, 3, 1, 1] = true; //O Block - Rotation 4
            blockShapeArray[4, 0, 1, 1] = true; //S Block - Rotation 1
            blockShapeArray[4, 0, 1, 2] = true; //S Block - Rotation 1
            blockShapeArray[4, 0, 2, 0] = true; //S Block - Rotation 1
            blockShapeArray[4, 0, 2, 1] = true; //S Block - Rotation 1
            blockShapeArray[4, 1, 0, 1] = true; //S Block - Rotation 2
            blockShapeArray[4, 1, 1, 1] = true; //S Block - Rotation 2
            blockShapeArray[4, 1, 1, 2] = true; //S Block - Rotation 2
            blockShapeArray[4, 1, 2, 2] = true; //S Block - Rotation 2
            blockShapeArray[4, 2, 1, 1] = true; //S Block - Rotation 3
            blockShapeArray[4, 2, 1, 2] = true; //S Block - Rotation 3
            blockShapeArray[4, 2, 2, 0] = true; //S Block - Rotation 3
            blockShapeArray[4, 2, 2, 1] = true; //S Block - Rotation 3
            blockShapeArray[4, 3, 0, 1] = true; //S Block - Rotation 4
            blockShapeArray[4, 3, 1, 1] = true; //S Block - Rotation 4
            blockShapeArray[4, 3, 1, 2] = true; //S Block - Rotation 4
            blockShapeArray[4, 3, 2, 2] = true; //S Block - Rotation 4
            blockShapeArray[5, 0, 0, 1] = true; //T Block - Rotation 1
            blockShapeArray[5, 0, 1, 0] = true; //T Block - Rotation 1
            blockShapeArray[5, 0, 1, 1] = true; //T Block - Rotation 1
            blockShapeArray[5, 0, 1, 2] = true; //T Block - Rotation 1
            blockShapeArray[5, 1, 0, 1] = true; //T Block - Rotation 2
            blockShapeArray[5, 1, 1, 1] = true; //T Block - Rotation 2
            blockShapeArray[5, 1, 1, 2] = true; //T Block - Rotation 2
            blockShapeArray[5, 1, 2, 1] = true; //T Block - Rotation 2
            blockShapeArray[5, 2, 1, 0] = true; //T Block - Rotation 3
            blockShapeArray[5, 2, 1, 1] = true; //T Block - Rotation 3
            blockShapeArray[5, 2, 1, 2] = true; //T Block - Rotation 3
            blockShapeArray[5, 2, 2, 1] = true; //T Block - Rotation 3
            blockShapeArray[5, 3, 0, 1] = true; //T Block - Rotation 4
            blockShapeArray[5, 3, 1, 0] = true; //T Block - Rotation 4
            blockShapeArray[5, 3, 1, 1] = true; //T Block - Rotation 4
            blockShapeArray[5, 3, 2, 1] = true; //T Block - Rotation 4
            blockShapeArray[6, 0, 1, 0] = true; //Z Block - Rotation 1
            blockShapeArray[6, 0, 1, 1] = true; //Z Block - Rotation 1
            blockShapeArray[6, 0, 2, 1] = true; //Z Block - Rotation 1
            blockShapeArray[6, 0, 2, 2] = true; //Z Block - Rotation 1
            blockShapeArray[6, 1, 0, 2] = true; //Z Block - Rotation 2
            blockShapeArray[6, 1, 1, 1] = true; //Z Block - Rotation 2
            blockShapeArray[6, 1, 1, 2] = true; //Z Block - Rotation 2
            blockShapeArray[6, 1, 2, 1] = true; //Z Block - Rotation 2
            blockShapeArray[6, 2, 1, 0] = true; //Z Block - Rotation 3
            blockShapeArray[6, 2, 1, 1] = true; //Z Block - Rotation 3
            blockShapeArray[6, 2, 2, 1] = true; //Z Block - Rotation 3
            blockShapeArray[6, 2, 2, 2] = true; //Z Block - Rotation 3
            blockShapeArray[6, 3, 0, 2] = true; //Z Block - Rotation 4
            blockShapeArray[6, 3, 1, 1] = true; //Z Block - Rotation 4
            blockShapeArray[6, 3, 1, 2] = true; //Z Block - Rotation 4
            blockShapeArray[6, 3, 2, 1] = true; //Z Block - Rotation 4

            //Start the game
            startGame();
        }

        //Runs when any key is pressed on the form
        private void frmGamePlay_KeyDown(object sender, KeyEventArgs keyDown)
        {

            //If game is not paused
            if (bGamePaused == false)
            {

                //If A (Or Left) key is pressed
                if (keyDown.KeyCode == Keys.A || keyDown.KeyCode == Keys.Left)
                {

                    //Check if the block can be moved left
                    if (canBeMoved((Int16)(iFallingBlockId), (Int16)(iFallingBlockPos), (Int16)(iFallingBlockRow), (Int16)(iFallingBlockColumn - 1)))
                    {

                        //Move block left
                        iFallingBlockColumn = (Int16)(iFallingBlockColumn - 1);

                        //Update block displayed on screen
                        displayFallingBlock();
                    }
                }

                //Else if D (Or Right) key is pressed
                else if (keyDown.KeyCode == Keys.D || keyDown.KeyCode == Keys.Right)
                {

                    //Check if the block can be moved right
                    if (canBeMoved((Int16)(iFallingBlockId), (Int16)(iFallingBlockPos), (Int16)(iFallingBlockRow), (Int16)(iFallingBlockColumn + 1)))
                    {

                        //Move block right
                        iFallingBlockColumn = (Int16)(iFallingBlockColumn + 1);

                        //Update block displayed on screen
                        displayFallingBlock();
                    }
                }

                //Else if W (Or Up) key is pressed
                else if (keyDown.KeyCode == Keys.W || keyDown.KeyCode == Keys.Up)
                {

                    Int16 iFallingBlockPosNext;       //INTEGER used to store the next block position (Rotation)

                    //If the current block is at position 3
                    if (iFallingBlockPos == 3)
                    {

                        //Set next block position to 0
                        iFallingBlockPosNext = 0;
                    }

                    //Otheriwse
                    else
                    {

                        //Set next block position to the current block position + 1
                        iFallingBlockPosNext = (Int16)(iFallingBlockPos + 1);
                    }

                    //Check if this new position is allowed
                    if (canBeMoved(iFallingBlockId, iFallingBlockPosNext, iFallingBlockRow, iFallingBlockColumn))
                    {

                        //Set current block position to the value of the next block position
                        iFallingBlockPos = iFallingBlockPosNext;

                        //Update block displayed on screen
                        displayFallingBlock();
                    }
                }

                //Else if S (Or Down) key is pressed
                else if (keyDown.KeyCode == Keys.S || keyDown.KeyCode == Keys.Down)
                {

                    //Set timer interval to 40
                    tmrFall.Interval = 40;
                }
            }
        }

        //Runs when any key is released on the form
        private void frmGamePlay_KeyUp(object sender, KeyEventArgs e)
        {
            //If S (Or Down) key is release
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {

                //Return timer interval to its normal value for the current level
                tmrFall.Interval = gameSpeed(iLevel);
            }
        }

        //Runs when the timer 'ticks'
        private void tmrFall_Tick(object sender, EventArgs e)
        {          

            //Check if the block can be moved into the position currently under it
            if (canBeMoved((Int16)(iFallingBlockId), (Int16)(iFallingBlockPos), (Int16)(iFallingBlockRow + 1), (Int16)(iFallingBlockColumn)))
            {

                //Add one to the falling block row
                iFallingBlockRow = (Int16)(iFallingBlockRow + 1);

                //Update block displayed on screen
                displayFallingBlock();
            }

            //Otherwise, the block must become a static block at the current position
            else
            {
                Int16 iRow = 0;       //INTEGER used to store the row while looping
                Int16 iColumn = 0;    //INTEGER used to store the column while looping

                //Loop for every row in the block area
                for (iRow = 0; iRow <= 3; iRow++)
                {

                    //Loop for every column in the block area
                    for (iColumn = 0; iColumn <= 3; iColumn++)
                    {

                        //If a sub-block of the falling block exists in the current position
                        if (blockShapeArray[iFallingBlockId, iFallingBlockPos, iRow, iColumn])
                        {

                            //Add that sub-block to the position in the static block array
                            blockArray[iFallingBlockRow + iRow, iFallingBlockColumn + iColumn] = (Int16)(iFallingBlockId + 1);
                        }
                    }
                }

                //Set current falling block id to the next falling block id
                iFallingBlockId = iFallingBlockIdNext;

                //Loop until next falling block id is not the current falling block id
                do
                {

                    //Generate random next falling block id
                    iFallingBlockIdNext = (Int16)(randomNumber.Next(0, iNumberOfBlocks));

                } while (iFallingBlockId == iFallingBlockIdNext);

                //Set current falling block position (rotation) to default (0)
                iFallingBlockPos = 0;

                //Set current falling block row to top (0)
                iFallingBlockRow = 0;

                //Set current falling block column to default for start (4)
                iFallingBlockColumn = 4;

                //Update block displayed on screen
                displayNextBlock();

                //Check for any full rows and destroy the necessary rows
                rowDestruction();

                //Check if the block can exist at the start position
                if (canBeMoved(iFallingBlockId, iFallingBlockPos, iFallingBlockRow, iFallingBlockColumn))
                {

                    //Update all sub-blocks on the screen
                    displayGrid();
                }

                //Otherwise, the player has lost
                else
                {

                    //End the game
                    endGame();
                }
            }
        }

        //Start a new game
        private void startGame()
        {

            //Set current block id to random value
            iFallingBlockId = (Int16)(randomNumber.Next(0, iNumberOfBlocks));

            //Loop until next falling block id is not the current falling block id
            do
            {

                //Generate random next falling block id
                iFallingBlockIdNext = (Int16)(randomNumber.Next(0, iNumberOfBlocks));

            } while (iFallingBlockIdNext == iFallingBlockId);

            //Set falling block to position 0
            iFallingBlockPos = 0;

            //Start block falling from row 0
            iFallingBlockRow = 0;

            //Start block falling from column 4
            iFallingBlockColumn = 4;

            //Display next block
            displayNextBlock();

            //Set time intervalr/game speed for correct level
            tmrFall.Interval = gameSpeed(iLevel);

            //Display correct number of lines destroyed
            lblLines.Text = Convert.ToString(iScoreLines);

            //Display correct score
            lblScore.Text = Convert.ToString(iScore);

            //Display correct level
            lblLevel.Text = Convert.ToString(iLevel);

            //Updates all sub-blocks on the screen
            displayGrid();

            //Start timer for falling blocks
            tmrFall.Enabled = true;
        }

        //End the game
        private void endGame()
        {
            //Disable timer
            tmrFall.Enabled = false;

            //Create a new instance of the form 'frmMenu'
            frmHighScore frmHighScore = new frmHighScore();

            //Hide the current form
            this.Hide();

            //Transfer the score to the high scores form
            frmHighScore.iScore = iScore;

            //Show the newly created form
            frmHighScore.ShowDialog();

            //Close the current form
            this.Close();
        }

        //Updates all sub-blocks on the screen
        private void displayGrid()
        {

            Int16 iRow = 0;       //INTEGER used to store row whilst looping
            Int16 iColumn = 0;    //INTEGER used to store column whilst looping

            //Loop for every row in game grid
            for (iRow = 0; iRow <= iGameRows; iRow++)
            {

                //Loop for every column in game grid
                for (iColumn = 0; iColumn <= iGameColumns; iColumn++)
                {

                    //If static block should be displayed in this position
                    if (blockArray[iRow, iColumn] != 0)
                    {

                        //Display static block
                        picBlockGrid[(iRow * 10) + iColumn].Image = imgBlockImage[blockArray[iRow, iColumn]];
                    }

                    //If row and column is in a position where falling block could be rendered
                    else if(iRow >= iFallingBlockRow && iRow <= iFallingBlockRow + 3 &&
                        iColumn >= iFallingBlockColumn && iColumn <= iFallingBlockColumn + 3 &&
                        blockShapeArray[iFallingBlockId, iFallingBlockPos, iRow - iFallingBlockRow, iColumn - iFallingBlockColumn]) 
                    {

                        //Display appropriate coloured block
                        picBlockGrid[(iRow * 10) + iColumn].Image = imgBlockImage[iFallingBlockId + 1];
                    }

                    //Otherwise display nothing in position
                    else
                    {
                        picBlockGrid[(iRow * 10) + iColumn].Image = null;
                    }
                }
            }
        }

        //Updates the sub-blocks in the game grid where the block is falling
        private void displayFallingBlock()
        {

            Int16 iRow = 0;       //INTEGER used to store row whilst looping
            Int16 iColumn = 0;    //INTEGER used to store column whilst looping

            //Loop for every row at the current position of the falling block within the game grid
            for (iRow = (Int16)(iFallingBlockRow - 1); iRow <= iFallingBlockRow + 3; iRow++)
            {

                //Loop for every column at the current position of the falling block within the game grid
                for (iColumn = (Int16)(iFallingBlockColumn - 1); iColumn <= iFallingBlockColumn + 4; iColumn++)
                {

                    //If row and column is valid position on game grid
                    if(iRow >= 0 && iRow <= iGameRows &&
                        iColumn >= 0 && iColumn <= iGameColumns)
                    {

                        //If static block should be displayed in this position
                        if (blockArray[iRow, iColumn] != 0)
                        {

                            //Display static block
                            picBlockGrid[(iRow * 10) + iColumn].Image = imgBlockImage[blockArray[iRow, iColumn]];
                        }

                        //If row and column is in a position where block could be rendered
                        else if (iRow >= iFallingBlockRow && iRow <= iFallingBlockRow + 3 &&
                            iColumn >= iFallingBlockColumn && iColumn <= iFallingBlockColumn + 3 &&
                            blockShapeArray[iFallingBlockId, iFallingBlockPos, iRow - iFallingBlockRow, iColumn - iFallingBlockColumn])
                        {

                            //Display block
                            picBlockGrid[(iRow * 10) + iColumn].Image = imgBlockImage[iFallingBlockId + 1];
                        }

                        //Otherwise display nothing in position
                        else
                        {
                            picBlockGrid[(iRow * 10) + iColumn].Image = null;
                        }
                    }
                }
            }
        }

        //Display the preview of the next block at the right hand side
        private void displayNextBlock()
        {
            Int16 iRow = 0;       //INTEGER used to store row whilst looping
            Int16 iColumn = 0;    //INTEGER used to store column whilst looping

            //Loop for every row in block
            for (iRow = 0; iRow <= 3; iRow++)
            {

                //Loop for every column in block
                for (iColumn = 0; iColumn <= 3; iColumn++)
                {

                    //If sub-block in next block (row, column position) should be shown
                    if (blockShapeArray[iFallingBlockIdNext, 0, iRow, iColumn])
                    {

                        //Display block
                        picBlockNextGrid[(iRow * 4) + iColumn].Image = imgBlockImage[iFallingBlockIdNext + 1];
                    }

                    //Otherwise, display nothing
                    else
                    {

                        //Display no block at that position
                        picBlockNextGrid[(iRow * 4) + iColumn].Image = null;
                    }
                }
            }
        }

        //Check for any full rows and destroy the neccessary rows
        private void rowDestruction()
        {
            Int16 iRow = 0;               //INTEGER used to store row whilst looping
            Int16 iColumn = 0;            //INTEGER used to store column whilst looping
            Int16 iRowsDestroyed = 0;     //INTEGER used to store the number of rows that have been destroyed
            bool bNotFullRow = false;   //BOOLEAN flag used to identify a non full row

            //Loop for every row in the game grid
            for (iRow = 0; iRow <= iGameRows; iRow++)
            {

                //Reset boolean flag which identifies a non full row
                bNotFullRow = false;

                //Reset column to 0
                iColumn = 0;

                //Loop for every column in row or until a sub-block is empty in the row 
                do
                {

                    //If sub-block is empty
                    if (blockArray[iRow, iColumn] == 0)
                    {

                        //Set boolean flag to identify a non full row to true
                        bNotFullRow = true;
                    }

                    //Add one to column variable
                    iColumn++;

                } while (iColumn <= iGameColumns && bNotFullRow == false);

                //If row is full of blocks
                if (bNotFullRow == false)
                {

                    //Loop for every column in row to clear all blocks
                    for (iColumn = 0; iColumn <= iGameColumns; iColumn++)
                    {

                        //Set block at position to nothing
                        blockArray[iRow, iColumn] = 0;
                    }

                    Int16 iRowMove = 0;   //INTEGER used to identify rows when moving rows down

                    //Loop for every row staring from the current (now empty row) to the top of the game grid
                    for (iRowMove = iRow; iRowMove >= 1; iRowMove = (Int16)(iRowMove - 1))
                    {

                        //Loop for every column in row to move row down
                        for (iColumn = 0; iColumn <= iGameColumns; iColumn++)
                        {

                            //Move sub-block down one row
                            blockArray[iRowMove, iColumn] = blockArray[iRowMove - 1, iColumn];
                        }
                    }

                    //Add one to INTEGER storing the amount of rows destroyed
                    iRowsDestroyed++;
                }

            }

            //If a row has been destroyed
            if (iRowsDestroyed > 0)
            {
                Int16 iScoreAddition = 0;     //INTEGER used to store the ammount to be added to the current score

                //Add the number of rows destroyed to the INTEGER stroing total lines cleared
                iScoreLines = (Int16)(iScoreLines + iRowsDestroyed);

                //Output total lines cleared
                lblLines.Text = Convert.ToString(iScoreLines);

                //If 1 row destroyed this move
                if(iRowsDestroyed == 1)
                {

                    //Score to be added to total score is calculated using level
                    iScoreAddition = (Int16)(40 * iLevel);
                }

                //If 2 row destroyed this move
                else if (iRowsDestroyed == 2)
                {

                    //Score to be added to total score is calculated using level
                    iScoreAddition = (Int16)(100 * iLevel);
                }

                //If 3 row destroyed this move
                else if (iRowsDestroyed == 3)
                {

                    //Score to be added to total score is calculated using level
                    iScoreAddition = (Int16)(300 * iLevel);
                }

                //If 4 row destroyed this move
                else if (iRowsDestroyed == 4)
                {

                    //Score to be added to total score is calculated using level
                    iScoreAddition = (Int16)(1200 * iLevel);
                }


                //Add the score to be added to the actual score
                iScore = iScore + iScoreAddition;

                //Display the new total score
                lblScore.Text = Convert.ToString(iScore);

                //Calculate the current level [Total Number of lines destroyed / 10 (Rounded Down)]
                iLevel = (Int16)(Convert.ToInt16(Math.Floor(Convert.ToDecimal(iScoreLines) / 10)) + 1);

                //Check if iScore has overflowed the limit of the 32 bit integer
                //      Would require a VERY long game for this to happen
                //      aprox 2990 Tetrises in a row
                if (iScore < -1)
                {

                    //Disable the timer
                    tmrFall.Enabled = false;

                    //Display congratulation message
                    MessageBox.Show("You have managed to get the highest possible score. Did you cheat?",
                                    "Highest Possible Score",                       //Title of the message box
                                    MessageBoxButtons.OK,                           //Buttons displayed on message box
                                    MessageBoxIcon.Exclamation);                    //Type of messahe box

                    //Set score to highest value [Largest number availiable in 32 bit integer]
                    iScore = 2147483647;

                    //End the game
                    endGame();

                }
                //Check if iLevel has overflowed the limit of the 16 bit integer
                //      Would also a VERY long game for this to happen
                else if (iLevel < -1)
                {

                    //Disable the timer
                    tmrFall.Enabled = false;

                    //Display congratulation message
                    MessageBox.Show("You have managed to get the highest possible level. Did you cheat?",
                                    "Highest Possible Level",                       //Title of the message box
                                    MessageBoxButtons.OK,                           //Buttons displayed on message box
                                    MessageBoxIcon.Exclamation);                    //Type of messahe box

                    //Set level to highest value [Largest number availiable in 16 bit integer]
                    iLevel = 32767;

                    //End the game
                    endGame();

                }
                //Display level
                lblLevel.Text = Convert.ToString(iLevel);

                //Recalculate time interval
                tmrFall.Interval = gameSpeed(iLevel);
            }
        }

        //Reset core game variables
        private void resetGame()
        {
            Int16 iRow = 0;       //INTEGER used to store row whilst looping
            Int16 iColumn = 0;    //INTEGER used to store column whilst looping

            //Loop for every row in the game grid
            for (iRow = 0; iRow <= iGameRows; iRow++)
            {

                //Loop for every column in the game grid
                for (iColumn = 0; iColumn <= iGameColumns; iColumn++)
                {

                    //Reset reset block to be empty
                    blockArray[iRow, iColumn] = 0;
                }
            }

            //Reset number of lines complete
            iScoreLines = 0;

            //Reset Score
            iScore = 0;

            //Reset level
            iLevel = 1;
        }

        //Returns whether a block can be placed in position on grid.
        /* 
         *  iFallingBlockIdCheck        The ID of the block to check
         *  iFallingBlockPosCheck       The position (rotation) of the block to check
         *  iFallingBlockRowCheck       The row position on the game grid that should be checked whether the block can be there
         *  iFallingBlockColumnCheck    The column position on the game grid that should be checked whether the block can be there */
        private bool canBeMoved(Int16 iFallingBlockIdCheck, Int16 iFallingBlockPosCheck, Int16 iFallingBlockRowCheck, Int16 iFallingBlockColumnCheck)
        {
            Int16 iBlockRow = 0;      //INTEGER used to store row whilst looping
            Int16 iBlockColumn = 0;   //INTEGER used to store column whilst looping
            bool bCantMove = false; //BOOLEAN used to store whether the block can be moved to position

            //Loop for every ROW at the proposed block position
            do
            {

                //Reset block column to 0
                iBlockColumn = 0;

                //Loop for every COLUMN at the proposed block position
                do
                {

                    //Check if the falling block consists of a sub-block at that position
                    if (blockShapeArray[iFallingBlockIdCheck, iFallingBlockPosCheck, iBlockRow, iBlockColumn])
                    {

                        //Check if sub-block is allowed to exist at that position
                        if (iBlockColumn + iFallingBlockColumnCheck > iGameColumns ||       //Check if block is to the right of the right hand side edge
                            iBlockColumn + iFallingBlockColumnCheck < 0 ||                  //Check if block is to the left of the left hand side edge
                            iBlockRow + iFallingBlockRowCheck > iGameRows ||                //Check if block is under the bottom edge
                            blockArray[iBlockRow + iFallingBlockRowCheck,
                                       iBlockColumn + iFallingBlockColumnCheck] != 0)       //Check if a block exists at the proposed position
                        {

                            //Set can't move boolean to false
                            bCantMove = true;
                        }
                    }

                    //Add one to block column
                    iBlockColumn++;

                //Loop while iBlockColumn is under 3 and bCantMove is False
                } while (iBlockColumn <= 3 && bCantMove == false);

                //Add one to block row
                iBlockRow++;

            //Loop while iBlockRow is under 3 and bCantMove is False
            } while (iBlockRow <= 3 && bCantMove == false);

            //If the above loop found the block to exist at the positon
            if(bCantMove)
            {

                //Return false
                return false;
            }

            //Otherwise, the block can exist at the position
            else
            {

                //Return true
                return true;
            }
        }

        //Returns an INTEGER used for determining the timer delay used for the falling block
        private Int16 gameSpeed(Int16 level)
        {

            //Declare and set a proposed game speed.
            //  This uses a formula which is 500 * 0.8^CurrentLevel [ROUNDED UP]
            Int16 iProposedGameSpeed = Convert.ToInt16(Math.Ceiling(500 * Math.Pow(0.8, level)));

            //If the proposed speed is less than 40
            if (iProposedGameSpeed < 40)
            {

                //Use a speed of 40 anyway
                iProposedGameSpeed = 40;
            }

            //Return the result of the game speed
            return iProposedGameSpeed;
        }

        //Pauses the game
        private void pauseGame()
        {

            //Set pause menu strip item text to 'Resume'
            pauseToolStripMenuItem.Text = "Resume";

            //Disable the timer
            tmrFall.Enabled = false;

            //Set game paused boolean to true
            bGamePaused = true;

            //Display paused game label
            lblGamePaused.Visible = true;

            //Change window title to include 'Paused'
            this.Text = sWindowTitle + " | Paused";
        }

        //Unpause the game
        private void unpauseGame()
        {

            //Set pause menu strip item text to 'Pause'
            pauseToolStripMenuItem.Text = "Pause";

            //Enable the timer
            tmrFall.Enabled = true;

            //Set game paused boolean to false
            bGamePaused = false;

            //Hide paused game label
            lblGamePaused.Visible = false;

            //Change window title to default value
            this.Text = sWindowTitle;
        }

        /**************************
         **MENU STRIP ITEM EVENTS**
         **************************/

        //Runs when menu strip pause button is pressed
        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //If game is not currently paused
            if (!bGamePaused)
            {

                //Pause the game
                pauseGame();
            }

            //Otherwise, the game is currently paused
            else
            {

                //Unpause the game
                unpauseGame();
            }
        }

        //Runs when menu strip reset button is pressed
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If game is paused
            if (bGamePaused == true)
            {

                //Unpause the game
                unpauseGame();
            }

            //Reset core game variables
            resetGame();

            //Start a new game
            startGame();
        }

        //Runs when menu strip quit button is pressed
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            //Create a new instance of the form 'frmMenu'
            frmMenu frmMenu = new frmMenu();

            //Show the newly created form
            frmMenu.ShowDialog();

            //Close the current form
            this.Close();
        }

        //Runs when menu strip about button is pressed
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pause the game
            pauseGame();

            //Create a new instance of the form 'frmAbout'
            frmAbout frmAbout = new frmAbout();

            //Show the newly created form
            frmAbout.ShowDialog();
        }

        //Runs when menu strip about button is pressed
        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pause the game
            pauseGame();

            //Create a new instance of the form 'frmAbout'
            frmHowToPlay frmHowToPlay = new frmHowToPlay();

            //Show the newly created form
            frmHowToPlay.ShowDialog();
        }

        private void tESTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu.Height = 15;
        }
    }
}
