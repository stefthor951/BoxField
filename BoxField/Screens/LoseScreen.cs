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
        public LoseScreen()
        {
            InitializeComponent();
            OnLoad();
        }

        private void OnLoad()
        {
            scoreOutputLabel.Text = "Final Score: " + Convert.ToString(Form1.currentScore);

            //Highscore newScore = new Highscore(nameInput.Text, Convert.ToString(Form1.currentScore));
            //Form1.highscoreList.Add(newScore);
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
            ms.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            

            saveButton.Enabled = false;
            saveButton.Visible = false;
        }
    }
}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        