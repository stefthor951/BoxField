﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using BoxField.Screens;

namespace BoxField
{
    public partial class GameScreen : UserControl
    {
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, bDown, nDown, mDown, spaceDown;

        //used to draw boxes on screen
        //SolidBrush boxBrush = new SolidBrush(Color.White);

        //TODO - create a list to hold a column of boxes        
        List<Box> boxList = new List<Box>();

        //box values
        int boxSize, boxSpeed, newBoxCounter, columnSectionTimer, randomSectionTimer, columnBoxLocation, 
            counter, randomNumber, score, transitionCounterThing, colourCounterUp, colourCounterDown, boxColourUp, boxColourDown,
            backColourRed, backColourGreen, backColourBlue;
        bool transitioning = false;
        SolidBrush playerBrush = new SolidBrush(Color.FromArgb(0, 0, 0));
        string direction = "left";
        string backColour = "red";
        string boxColour;
        Random randnum = new Random();
        Box player;

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        /// <summary>
        /// Set initial game values here
        /// </summary>
        public void OnStart()
        {
            //TODO - set game start values
            boxSize = 20;
            boxSpeed = 7;
            newBoxCounter = 0;
            score = 0;
            randomSectionTimer = 800;
            columnSectionTimer = 0;
            colourCounterUp = 0;
            colourCounterDown = 255;
            randomNumber = randnum.Next(5, 51);
            transitionCounterThing = 0;
            //transitioning = true; //remove after

            //Box b1 = new Box(5, 5, boxSize, boxSpeed, 255, 255, 255);
            //boxList.Add(b1);


            player = new Box(this.Width / 2 - boxSize / 2, this.Height - 100, boxSize, 8, 0, 0, 0);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.B:
                    bDown = true;
                    break;
                case Keys.N:
                    nDown = true;
                    break;
                case Keys.M:
                    mDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.B:
                    bDown = false;
                    break;
                case Keys.N:
                    nDown = false;
                    break;
                case Keys.M:
                    mDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {
            foreach (Box b in boxList)
            {
                b.Move();
            }
            newBoxCounter--;
            score++;
            if (score % 1000 == 0)
            {
                boxSpeed++;
                if (newBoxCounter > 0)
                {
                    newBoxCounter--;
                }
            }
            if (score % 2500 == 0)
            {
                player.speed++;
            }
            scoreLabel.Text = "Score: " + score;

            #region creates boxes in the "random" phase
            if (randomSectionTimer > 0)
            {
                randomSectionTimer--;

                if (randomSectionTimer < 1800) //waits for a few timer ticks as a buffer between phases
                {
                    colourCounterUp++;
                    colourCounterDown--;
                    //if (colourCounterDown == 0)
                    //{
                    //    colourCounterDown = 255;
                    //}
                    //if (colourCounterUp == 255)
                    //{
                    //    colourCounterUp = 0;
                    //}
                    if (newBoxCounter <= 0)
                    {
                        Box b = new Box(randnum.Next(0, this.Width * Convert.ToInt16(0.75)), -boxSize, boxSize, boxSpeed, 255, 255, 255);
                        boxList.Add(b);
                        newBoxCounter = 5;
                        //this.BackColor = Color.FromArgb(randnum.Next(0, 256), randnum.Next(0, 256), randnum.Next(0, 256));
                        //if (backColour == "red")
                        //{
                        //    if (colourCounterDown <= 0)
                        //    {
                        //        backColour = "blue";
                        //        colourCounterDown = 255;
                        //        colourCounterUp = 0;
                        //    }
                        //    this.BackColor = Color.FromArgb(colourCounterDown, colourCounterUp, 0);
                        //}
                        //if (backColour == "blue")
                        //{
                        //    if (colourCounterDown <= 0)
                        //    {
                        //        backColour = "green";
                        //        colourCounterDown = 255;
                        //        colourCounterUp = 0;
                        //    }
                        //    this.BackColor = Color.FromArgb(0, colourCounterDown, colourCounterUp);
                        //}
                        //if (backColour == "green")
                        //{
                        //    if (colourCounterDown <= 0)
                        //    {
                        //        backColour = "red";
                        //        colourCounterDown = 255;
                        //        colourCounterUp = 0;
                        //    }
                        //    this.BackColor = Color.FromArgb(colourCounterUp, 0, colourCounterDown);
                        //}

                    }
                    if (backColour == "red")
                    {
                        backColourRed = colourCounterDown;
                        backColourGreen = colourCounterUp;
                        backColourBlue = 0;
                        this.BackColor = Color.FromArgb(backColourRed, backColourGreen, backColourBlue);
                        if (colourCounterDown <= 0)
                        {
                            backColour = "green";
                            colourCounterDown = 255;
                            colourCounterUp = 0;
                        }
                        
                    }
                    if (backColour == "green")
                    {
                        backColourRed = 0;
                        backColourGreen = colourCounterDown;
                        backColourBlue = colourCounterUp;
                        this.BackColor = Color.FromArgb(backColourRed, backColourGreen, backColourBlue);
                        if (colourCounterDown <= 0)
                        {
                            backColour = "blue";
                            colourCounterDown = 255;
                            colourCounterUp = 0;
                        }
                        
                    }
                    if (backColour == "blue")
                    {
                        backColourRed = colourCounterUp;
                        backColourGreen = 0;
                        backColourBlue = colourCounterDown;
                        this.BackColor = Color.FromArgb(backColourRed, backColourGreen, backColourBlue);
                        if (colourCounterDown <= 0)
                        {
                            backColour = "red";
                            colourCounterDown = 255;
                            colourCounterUp = 0;
                        }
                       
                    }
                }

                if (randomSectionTimer <= 0)
                {
                    transitioning = true; ; //1875 ticks is equal to 15 seconds at 125 fps
                    columnBoxLocation = randnum.Next(5, this.Width - 150 - boxSize);
                    
                }
            }
            #endregion

            #region transition to column phase
            else if (transitioning)
            {

                int leftDistanceRequired = columnBoxLocation;
                int rightDistanceRequired = this.Width - columnBoxLocation - 150 - boxSize;
                int generalDistanceRequired;
                if (leftDistanceRequired > rightDistanceRequired)
                {
                    generalDistanceRequired = leftDistanceRequired;
                }
                else
                {
                    generalDistanceRequired = rightDistanceRequired;
                }

                if (newBoxCounter <= 0)
                {
                    int redValue = 255 - backColourRed;
                    int greenValue = 255 - backColourGreen;
                    int blueValue = 255 - backColourBlue;
                    Box b1 = new Box(columnBoxLocation - generalDistanceRequired + transitionCounterThing, -boxSize, boxSize, boxSpeed, redValue, greenValue, blueValue);
                    boxList.Add(b1);
                    Box b2 = new Box(columnBoxLocation + 150 + generalDistanceRequired - transitionCounterThing, -boxSize, boxSize, boxSpeed, redValue, greenValue, blueValue);
                    boxList.Add(b2);
                    transitionCounterThing += boxSize;
                    newBoxCounter = 6;
                }
                if (transitionCounterThing >= generalDistanceRequired)
                {
                    transitioning = false;
                    columnSectionTimer = 1000; //change back to 600 after
                    transitionCounterThing = 0;
                }
            }
            #endregion

            #region creates boxes in the "column" phase
            else if (columnSectionTimer > 0)
            {
                columnSectionTimer--;
                boxColourUp+=5;
                boxColourDown-=5;

                //if (columnSectionTimer < ) //waits for a few timer ticks as a buffer between phases 
                {
                    if (newBoxCounter <= 0)
                    {
                        int counter2 = 0;

                        int redValue = 255 - backColourRed;
                        int greenValue = 255 - backColourGreen;
                        int blueValue = 255 - backColourBlue;

                        if (direction == "left")
                        {
                            columnBoxLocation -= 5;
                            counter++;
                        }

                        else if (direction == "right")
                        {
                            columnBoxLocation += 5;
                            counter++;
                        }

                        newBoxCounter = 4;

                        if (columnBoxLocation - boxSize < 0 || columnBoxLocation + 150 + boxSize > this.Width)
                        {
                            counter = randomNumber;

                        }
                        if (counter == randomNumber)
                        {
                            randomNumber = randnum.Next(5, 51);
                            counter = 0;

                            if (direction == "left")
                            {
                                direction = "right";
                            }
                            else if (direction == "right")
                            {
                                direction = "left";
                            }
                        }
                        if (counter2 == 0)
                        {

                        }

                        Box b1 = new Box(columnBoxLocation, -boxSize, boxSize, boxSpeed, redValue, greenValue, blueValue);
                        boxList.Add(b1);
                        Box b2 = new Box(columnBoxLocation + 150, -boxSize, boxSize, boxSpeed, redValue, greenValue, blueValue);
                        boxList.Add(b2);

                        
                    }

                    //if (boxColour == "red")
                    //{

                    //    if (boxColourDown <= 0)
                    //    {
                    //        boxColour = "green";
                    //        boxColourDown = 255;
                    //        boxColourUp = 0;
                    //    }

                    //    foreach (Box b in boxList)
                    //    {
                    //        b.colourRed = boxColourDown;
                    //        b.colourGreen = boxColourUp;
                    //        b.colourBlue = 0;
                    //    }

                    //}
                    //if (boxColour == "green")
                    //{

                    //    if (boxColourDown <= 0)
                    //    {
                    //        boxColour = "blue";
                    //        boxColourDown = 255;
                    //        boxColourUp = 0;
                    //    }
                    //    foreach (Box b in boxList)
                    //    {
                    //        b.colourRed = 0;
                    //        b.colourGreen = boxColourDown;
                    //        b.colourBlue = boxColourUp;
                    //    }

                    //}
                    //if (boxColour == "blue")
                    //{
                    //    if (boxColourDown <= 0)
                    //    {
                    //        boxColour = "red";
                    //        boxColourDown = 255;
                    //        boxColourUp = 0;
                    //    }
                    //    foreach (Box b in boxList)
                    //    {
                    //        b.colourRed = boxColourUp;
                    //        b.colourGreen = 0;
                    //        b.colourBlue = boxColourDown;
                    //    }
                    //}


                    if (columnSectionTimer <= 0)
                    {
                        randomSectionTimer = 675;//change back to675 after
                    }
                }
            }
            #endregion
            //TODO - remove box if it has gone of screen
            if (boxList.Count > 0)
            {
                if (boxList[0].y > this.Height && boxList.Count > 0)
                {
                    boxList.RemoveAt(0);
                }
            }
            #region player movement and collision
            //Move player
            if (leftArrowDown)
            {
                player.Move("left");

                if (player.x < 0) //if the player is too far to the left
                {
                    player.x += player.speed;
                }
            }

            if (rightArrowDown)
            {
                player.Move("right");
                if (player.x > this.Width - player.size) //if the player is too far to the right
                {
                    player.x -= player.speed;
                }
            }

            //Check for collision between player and boxes
            foreach (Box b in boxList)
            {
                Boolean hasCollided = false;

                hasCollided = player.Collision(b);

                if (hasCollided)
                {
                    Form1.scores.Add(score);
                    gameLoop.Stop();

                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    LoseScreen ls = new LoseScreen();
                    f.Controls.Add(ls);
                }
            }
            #endregion
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //TODO - draw boxes to screen
            foreach (Box b in boxList)
            {
                SolidBrush boxBrush = new SolidBrush(Color.FromArgb(b.colourRed, b.colourGreen, b.colourBlue));
                e.Graphics.FillRectangle(boxBrush, b.x, b.y, b.size, b.size);
				Pen outlinePen = new Pen(Color.Black, 2);
				e.Graphics.DrawRectangle(outlinePen, b.x, b.y, b.size, b.size);
			}
            SolidBrush playerBrush = new SolidBrush(Color.FromArgb(player.colourRed, player.colourGreen, player.colourBlue));
            e.Graphics.FillRectangle(playerBrush, player.x, player.y, player.size, player.size);
        }
    }
}