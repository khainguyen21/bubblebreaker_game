//***********************************************************************************
//Program: Lab 3
//Date: 23/03/30
//Author: Khai Nguyen 
//Course: CMPE1666
//Class: CNTA01
//***********************************************************************************




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;
using System.Threading;
using System.Media;
using System.IO;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Create the struct to hold the color of each ball 
        public struct Ball
        {
            public Color color;
            public BallState state;
        }
        //create the enum to track status of ball 
        public enum BallState
        {
            DEAD,
            ALIVE
        }


        const int screen_width = 800; //store the width of screen 
        const int screen_height = 600; //store the height of screen 
        const int ball_size = 50;//store the ball size 
        int rowCount = screen_height / ball_size; //store number of rows
        int columnCount = screen_width / ball_size; //store number of columns 
        int iTotalScore = 0;//store the total score 
        int iScore = 0; //store the score for each score
        int selectedMode;//store the mode selected 
        int numBallColors;//store how many base on mode selected
        int speed = 20;//threading speed 

        //create canvas
        CDrawer canvas = new CDrawer(800, 600);
        //create the 2D array of Ball struct 
        Ball[,] balls;
        //get modeless of score
        Scorecs score = null;
        //get modeless of animation 
        AnimationModeless animationTrackBar = new AnimationModeless(); 
        //get modeless of high score 
        HighScoreModal highScore = new HighScoreModal();
        string gameMode;

        private void UI_Play_btn_Click(object sender, EventArgs e)
        {
            //create the modal dialog form 
            SelectDifficulty dlg = new SelectDifficulty();

            //get the game mode from the SelectDifficulty modal dialog
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                selectedMode = dlg.SelectMode;
            }

            //if the selectmode is easy 
            if (selectedMode == 1)
            {
                numBallColors = 3;
                gameMode = "Easy"; 
            }
            //if the selectmode is medium 
            else if (selectedMode == 2)
            {
                numBallColors = 4;
                gameMode = "Medium";
            }
            //if the selectmode is hard 
            else if (selectedMode == 3)
            {
                numBallColors = 5;
                gameMode = "Hard";
            }

            //create the balls array and display them on the screen 
            Randomize();
            Display();

            //start the timer and disable the play button 
            timer1.Enabled = true;

            //Diable the button 
            UI_Play_btn.Enabled = false;



        }

        private void CallBackFormClosing()
        {
            UI_ShowScore_cbx.Checked = false;
        }

        private void CallbackFormClosing1()
        {
            UI_ShowAnimationSped_cbx.Checked = false;
        }



        private void ShowScore(object sender, EventArgs e)
        {
            //if the show score checked 
            if (UI_ShowScore_cbx.Checked)
            {
                if (score == null)
                {
                    score = new Scorecs();
                    score._dFormClosing = CallBackFormClosing;
                }
                score.Show();
            }
            else
            {
                score.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {            
            int highScores; //store the current highest score 
            iScore = Pick();

            //get a total score
            iTotalScore += iScore;

            //passing into modeless dialog 
            score.GameScore = iTotalScore;

            //check if the game is over 
            if (BallsAlive() == 0)
            {
                timer1.Stop();
                canvas.AddText("Game Over", 70, Color.Green);
                UI_Play_btn.Enabled = true;
                timer1.Enabled = false;

                //get the high score from file text 
                highScores = ReadScoreFromFile(gameMode); 

                if (iTotalScore > highScores)
                {
                    if (highScore.ShowDialog() == DialogResult.OK)
                    {
                        WriteToFile(highScore.username, gameMode, iTotalScore);
                    }
                }

            }
        }

        //********************************************************************************************
        //Method: private void Randomize()
        //Purpose: set random color to number of ball in canvas and set ball state is alive 
        //********************************************************************************************
        private void Randomize()
        {
            //create the instance 
            balls = new Ball[columnCount, rowCount];
            //declare an array of 5 Color values
            Color[] colors = { Color.Red, Color.Green, Color.Yellow, Color.Pink, Color.Blue };

            //shuffle colors 
            Random rand = new Random();
            for (int i = 0; i < colors.Length - 1; i++)
            {
                int j = rand.Next(i, colors.Length);
                Color temp = colors[i];
                colors[i] = colors[j];
                colors[j] = temp;
            }

            for (int x = 0; x < columnCount; x++)
            {
                for (int y = 0; y < rowCount; y++)
                {
                    int randColor = rand.Next(numBallColors);
                    balls[x, y].color = colors[randColor];
                    balls[x, y].state = BallState.ALIVE;
                }
            }
        }
        //********************************************************************************************
        //Method: private void Display()
        //Purpose: display the all balls into canvas 
        //********************************************************************************************
        private void Display()
        {
            //clear the canvas first
            canvas.Clear();

            //draw balls that alive

            for (int x = 0; x < columnCount; x++)
            {
                for (int y = 0; y < rowCount; y++)
                {
                    if (balls[x, y].state == BallState.ALIVE)
                    {
                        canvas.AddEllipse(x * ball_size, y * ball_size, ball_size, ball_size, balls[x, y].color);
                    }
                }
            }

            //render the balls 
            canvas.Render();
        }
        //********************************************************************************************
        //Method: private int BallsAlive()
        //Purpose: check if the how many is still alive
        //return number of ball that alive 
        //********************************************************************************************
        private int BallsAlive()
        {
            int aLiveCount = 0;
            for (int x = 0; x < columnCount; x++)
            {
                for (int y = 0; y < rowCount; y++)
                {
                    if (balls[x, y].state == BallState.ALIVE)
                    {
                        aLiveCount++;
                    }
                }
            }
            return aLiveCount;
        }
        //********************************************************************************************
        //Method: public int CheckBalls(int row, int col, Color color)
        //Purpose: check if the ball is dead, set the ball state to dead and increment balls Killed, recursively checked balls around them  
        //Parameter: 
        //int row - number of rows
        //int col - number of column 
        //Color color - color of ball 
        //return number of ball killed 
        //********************************************************************************************
        public int CheckBalls(int row, int col, Color color)
        {
            int ballsKilled = 1;

            //check if row and column is valid 
            if (row < 0 || row >= rowCount || col < 0 || col >= columnCount)
            {
                return 0;
            }

            //check if ball is already dead or of different color 
            if (balls[col, row].state == BallState.DEAD || balls[col, row].color != color)
            {
                return 0;
            }

            //set the ball to state dead
            balls[col, row].state = BallState.DEAD;

            ballsKilled++;

            //check for adjacent balls 
            ballsKilled += CheckBalls(row - 1, col, color); // Check above
            ballsKilled += CheckBalls(row + 1, col, color); // Check below
            ballsKilled += CheckBalls(row, col - 1, color); // Check left
            ballsKilled += CheckBalls(row, col + 1, color); // Check right

            return ballsKilled;
        }
        //********************************************************************************************
        //Method: public int StepDown()
        //Purpose: check if the ball is dead, copy from the top of it, and set on top of it to dead state  
        //return ballsDrop; 
        //********************************************************************************************
        public int StepDown()
        {
            int ballsDrop = 0;

            for (int x = 0; x < columnCount; x++)
            {
                for (int y = rowCount - 1; y > 0; y--)
                {

                    if (balls[x, y].state == BallState.DEAD && y > 0 && balls[x, y - 1].state == BallState.ALIVE)
                    {
                        balls[x, y] = balls[x, y - 1];
                        balls[x, y - 1].state = BallState.DEAD;

                        //animate it at user chosen speed
                        System.Threading.Thread.Sleep(speed);

                        Display();
                        ballsDrop++;
                    }
                }
            }
            return ballsDrop;
        }
        //********************************************************************************************
        //Method: public int FallDown()
        //Purpose: Repeat to call StepDown method until no ball can be dropped   
        //return ballsDrop; 
        //********************************************************************************************
        public int FallDown()
        {
            int totalBallsDropeed = 0;
            int ballsDropped = 0;

            do
            {
                ballsDropped = StepDown();
                totalBallsDropeed += ballsDropped;
                Display();

            } while (ballsDropped > 0);
            return totalBallsDropeed;

        }
        //********************************************************************************************
        //Method: public int Pick()
        //Purpose: get mouse click position, passing into CheckBall() method to check and return number of ball that killed to calculate score
        //return sum; 
        //********************************************************************************************
        public int Pick()
        {
            Point clickPos;
            int score = 0;
            int bonusScore;
            int sum;
            //get the last click position
            bool clicked = canvas.GetLastMouseLeftClick(out clickPos);

            int row;
            int col;
            if (!clicked)
            {
                return 0;
            }

            //convert the click position to row and column
            col = clickPos.X / ball_size;
            row = clickPos.Y / ball_size;

            //check if the ball at clicked position is dead

            if (balls[col, row].state == BallState.DEAD)
            {
                Console.Beep(); // Beep the speaker 
                return 0;
            }

            //the clicked ball is alive, so check adjacent balls recursively 
            int ballsKilled = CheckBalls(row, col, balls[col, row].color);

            for (int i = 0; i < ballsKilled; i++)
            {
                score += (i * 5);
            }

            //for each alive ball clicked, add standard 50 points
            bonusScore = (ballsKilled * 50);

            //add the two point systems
            sum = score + bonusScore;
            //Drop all balls and return score 
            FallDown();
            return sum;
        }

        private void UI_ShowAnimationSped_cbx_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_ShowAnimationSped_cbx.Checked)
            {
                animationTrackBar._AnimationSpeed = CallTheSpeed;
                animationTrackBar.Show();
                animationTrackBar._dFormClosing = CallbackFormClosing1;

            }
        }
        //********************************************************************************************
        //Method: private int CallTheSpeed(int iSpeed)
        //Purpose: get value of speed from animation track bar and set it to speed variable 
        //return spped; 
        //********************************************************************************************
        private int CallTheSpeed(int iSpeed)
        {
            speed = iSpeed; 
            return speed;
        }
        //********************************************************************************************
        //Method: private void WriteToFile(string name, string mode, int score)
        //Purpose: To record the highest score in the specific mode into ....highscore.txt 
        //********************************************************************************************
        private void WriteToFile(string name, string mode, int score)
        {

            try
            {
                File.WriteAllText($"{mode}highscore.txt", $"{name} has {score} points on this {mode} mode.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occurred.");
            }
        }
        //********************************************************************************************
        //Method: private int ReadScoreFromFile(string mode)
        //Purpose: get the highest score from specific mode in text files to compare with the current highest score 
        //********************************************************************************************
        private int ReadScoreFromFile(string mode)
        {
            int score;

            if (File.Exists($"{mode}highscore.txt"))
            {
                using (StreamReader sR = new StreamReader($"{mode}highscore.txt"))
                {
                    string wordfromfile = sR.ReadLine();
                    string word = new string(wordfromfile.Where(char.IsDigit).ToArray());
                    int.TryParse(word, out score);
                    return score;
                }
            }
            else
            {
                return 0;
            }
        }


    }
}