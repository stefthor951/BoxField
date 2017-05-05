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
    public partial class MainScreen : UserControl
    {
        int index = 0;
        int lastIndex = 0;

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            lastIndex = index;
            Form f = this.FindForm();
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (index != 0)
                    {
                        index--;
                    }
                    else
                    {
                        index = 2;
                    }
                    break;
                case Keys.Down:
                    if (index != 2)
                    {
                        index++;
                    }
                    else
                    {
                        index = 0;
                    }
                    break;
                case Keys.Escape:
                    Application.Exit();
                    break;
                case Keys.Space:
                    switch (index)
                    {
                        case 0:
                            GameScreen gs = new GameScreen();
                            f.Controls.Add(gs);
                            f.Controls.Remove(this);
                            gs.Focus();

                            gs.Location = new Point((f.Width - gs.Width) / 2, (f.Height - gs.Height) / 2);
                            break;
                        case 1:
                            HighScoreScreen hs = new HighScoreScreen();
                            f.Controls.Add(hs);
                            f.Controls.Remove(this);
                            hs.Focus();

                            hs.Location = new Point((f.Width - hs.Width) / 2, (f.Height - hs.Height) / 2);
                            break;
                        case 2:

                            Application.Exit();
                            break;
                    }
                    break;
                default:
                    break;
            }

            switch (lastIndex)
            {
                case 0:
                    startButton.ForeColor = Color.Black;
                    break;
                case 1:
                    highscoreButton.ForeColor = Color.Black;
                    break;
                case 2:
                    exitButton.ForeColor = Color.Black;
                    break;
            }

            switch (index)
            {
                case 0:
                    startButton.ForeColor = Color.Red;
                    break;
                case 1:
                    highscoreButton.ForeColor = Color.Red;
                    break;
                case 2:
                    exitButton.ForeColor = Color.Red;
                    break;
            }
        }
    }
}
