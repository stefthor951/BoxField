using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BoxField.Screens
{
    public partial class LoseScreen : UserControl
    {
        Boolean leftArrowDown, downArrowDown, rightArrowDown, upArrowDown, spaceDown;
        int index1, index2, index3;
        int selected = 0;
        int lastSelected = 0;

        private void LoseScreen_KeyUp(object sender, KeyEventArgs e)
        {
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
                case Keys.Space:
                    spaceDown = false;
                    break;
                default:
                    break;
            }
        }

        private void LoseScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            lastSelected = selected;

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
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.Escape:
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    MainScreen ms = new MainScreen();
                    ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);
                    f.Controls.Add(ms);
                    ms.Focus();
                    break;
                default:
                    break;
            }

            if (rightArrowDown == true)
            {
                if (selected == 4)
                {
                    selected = 0;
                }
                else
                {
                    selected++;
                }
            }

            if (leftArrowDown == true)
            {
                if (selected == 0)
                {
                    selected = 4;
                }
                else
                {
                    selected--;
                }
            }

            switch (selected)
            {
                case 0:
                    nameText1.ForeColor = Color.Red;

                    if (upArrowDown == true)// && index1 < 25)
                    {
                        index1++;

                        if (index1 > 25)
                        {
                            index1 = 0;
                        }
                    }

                    if (downArrowDown == true)// && index1 > 0)
                    {
                        index1--;

                        if (index1 < 0)
                        {
                            index1 = 25;
                        }
                    }
                    break;

                case 1:
                    nameText2.ForeColor = Color.Red;

                    if (upArrowDown == true)// && index2 < 25)
                    {
                        index2++;

                        if (index2 > 25)
                        {
                            index2 = 0;
                        }
                    }

                    if (downArrowDown == true)// && index2 > 0)
                    {
                        index2--;

                        if (index2 < 0)
                        {
                            index2 = 25;
                        }
                    }
                    break;

                case 2:
                    nameText3.ForeColor = Color.Red;

                    if (upArrowDown == true)// && index3 < 25)
                    {
                        index3++;

                        if (index3 > 25)
                        {
                            index3 = 0;
                        }
                    }

                    if (downArrowDown == true)// && index3 > 0)
                    {
                        index3--;

                            if (index3 < 0)
                            {
                                index3 = 25;
                            }
                        }
                    break;

                case 3:
                    restartButton.ForeColor = Color.Red;

                    if (spaceDown == true)
                    {
                        Highscore hs = new Highscore(nameText1.Text + nameText2.Text + nameText3.Text, Convert.ToString(Form1.currentScore));
                        hs.save(hs);
                        hs.saveScores(Form1.highscoreList);
                        // Goes to the game screen
                        Form f = this.FindForm();
                        GameScreen gs = new GameScreen();

                        gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);

                        f.Controls.Add(gs);
                        f.Controls.Remove(this);
                        gs.Focus();
                    }
                    break;

                case 4:
                    menuButton.ForeColor = Color.Red;

                    if (spaceDown == true)
                    {
                        Highscore hs = new Highscore(nameText1.Text + nameText2.Text + nameText3.Text, Convert.ToString(Form1.currentScore));
                        hs.save(hs);
                        hs.saveScores(Form1.highscoreList);
                        // Goes to the main menu screen
                        Form f = this.FindForm();
                        MainScreen ms = new MainScreen();

                        ms.Location = new Point((f.Width - ms.Width) / 2, (f.Height - ms.Height) / 2);

                        f.Controls.Add(ms);
                        f.Controls.Remove(this);
                        ms.Focus();
                    }
                    break;
            }

            if (selected != lastSelected)
            {
                switch (lastSelected)
                {
                    case 0:
                        nameText1.ForeColor = Color.Black;
                        break;

                    case 1:
                        nameText2.ForeColor = Color.Black;
                        break;

                    case 2:
                        nameText3.ForeColor = Color.Black;
                        break;

                    case 3:
                        restartButton.ForeColor = Color.Black;
                        break;

                    case 4:
                        menuButton.ForeColor = Color.Black;
                        break;
                }
            }

            switch (index1)
            {
                case 0:
                    nameText1.Text = "A";
                    break;
                case 1:
                    nameText1.Text = "B";
                    break;
                case 2:
                    nameText1.Text = "C";
                    break;
                case 3:
                    nameText1.Text = "D";
                    break;
                case 4:
                    nameText1.Text = "E";
                    break;
                case 5:
                    nameText1.Text = "F";
                    break;
                case 6:
                    nameText1.Text = "G";
                    break;
                case 7:
                    nameText1.Text = "H";
                    break;
                case 8:
                    nameText1.Text = "I";
                    break;
                case 9:
                    nameText1.Text = "J";
                    break;
                case 10:
                    nameText1.Text = "K";
                    break;
                case 11:
                    nameText1.Text = "L";
                    break;
                case 12:
                    nameText1.Text = "M";
                    break;
                case 13:
                    nameText1.Text = "N";
                    break;
                case 14:
                    nameText1.Text = "O";
                    break;
                case 15:
                    nameText1.Text = "P";
                    break;
                case 16:
                    nameText1.Text = "Q";
                    break;
                case 17:
                    nameText1.Text = "R";
                    break;
                case 18:
                    nameText1.Text = "S";
                    break;
                case 19:
                    nameText1.Text = "T";
                    break;
                case 20:
                    nameText1.Text = "U";
                    break;
                case 21:
                    nameText1.Text = "V";
                    break;
                case 22:
                    nameText1.Text = "W";
                    break;
                case 23:
                    nameText1.Text = "X";
                    break;
                case 24:
                    nameText1.Text = "Y";
                    break;
                case 25:
                    nameText1.Text = "Z";
                    break;
            }

            switch (index2)
            {
                case 0:
                    nameText2.Text = "A";
                    break;
                case 1:
                    nameText2.Text = "B";
                    break;
                case 2:
                    nameText2.Text = "C";
                    break;
                case 3:
                    nameText2.Text = "D";
                    break;
                case 4:
                    nameText2.Text = "E";
                    break;
                case 5:
                    nameText2.Text = "F";
                    break;
                case 6:
                    nameText2.Text = "G";
                    break;
                case 7:
                    nameText2.Text = "H";
                    break;
                case 8:
                    nameText2.Text = "I";
                    break;
                case 9:
                    nameText2.Text = "J";
                    break;
                case 10:
                    nameText2.Text = "K";
                    break;
                case 11:
                    nameText2.Text = "L";
                    break;
                case 12:
                    nameText2.Text = "M";
                    break;
                case 13:
                    nameText2.Text = "N";
                    break;
                case 14:
                    nameText2.Text = "O";
                    break;
                case 15:
                    nameText2.Text = "P";
                    break;
                case 16:
                    nameText2.Text = "Q";
                    break;
                case 17:
                    nameText2.Text = "R";
                    break;
                case 18:
                    nameText2.Text = "S";
                    break;
                case 19:
                    nameText2.Text = "T";
                    break;
                case 20:
                    nameText2.Text = "U";
                    break;
                case 21:
                    nameText2.Text = "V";
                    break;
                case 22:
                    nameText2.Text = "W";
                    break;
                case 23:
                    nameText2.Text = "X";
                    break;
                case 24:
                    nameText2.Text = "Y";
                    break;
                case 25:
                    nameText2.Text = "Z";
                    break;
            }

            switch (index3)
            {
                case 0:
                    nameText3.Text = "A";
                    break;
                case 1:
                    nameText3.Text = "B";
                    break;
                case 2:
                    nameText3.Text = "C";
                    break;
                case 3:
                    nameText3.Text = "D";
                    break;
                case 4:
                    nameText3.Text = "E";
                    break;
                case 5:
                    nameText3.Text = "F";
                    break;
                case 6:
                    nameText3.Text = "G";
                    break;
                case 7:
                    nameText3.Text = "H";
                    break;
                case 8:
                    nameText3.Text = "I";
                    break;
                case 9:
                    nameText3.Text = "J";
                    break;
                case 10:
                    nameText3.Text = "K";
                    break;
                case 11:
                    nameText3.Text = "L";
                    break;
                case 12:
                    nameText3.Text = "M";
                    break;
                case 13:
                    nameText3.Text = "N";
                    break;
                case 14:
                    nameText3.Text = "O";
                    break;
                case 15:
                    nameText3.Text = "P";
                    break;
                case 16:
                    nameText3.Text = "Q";
                    break;
                case 17:
                    nameText3.Text = "R";
                    break;
                case 18:
                    nameText3.Text = "S";
                    break;
                case 19:
                    nameText3.Text = "T";
                    break;
                case 20:
                    nameText3.Text = "U";
                    break;
                case 21:
                    nameText3.Text = "V";
                    break;
                case 22:
                    nameText3.Text = "W";
                    break;
                case 23:
                    nameText3.Text = "X";
                    break;
                case 24:
                    nameText3.Text = "Y";
                    break;
                case 25:
                    nameText3.Text = "Z";
                    break;
            }
        }

        public LoseScreen()
        {
            InitializeComponent();
            OnLoad();
        }

        private void OnLoad()
        {
            scoreOutputLabel.Text = "Final Score: " + Convert.ToString(Form1.currentScore);
        }
    }
}