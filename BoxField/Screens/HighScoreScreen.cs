using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoxField.Screens
{
    public partial class HighScoreScreen : UserControl
    {
        public HighScoreScreen()
        {
            InitializeComponent();
            OnLoad();
        }

        private void OnLoad()
        {
            for (int i = 0; i < Form1.highscoreList.Count; i++)
            {
                //top5Output.Text += Form1.highscoreList[i].name + "     " + Form1.highscoreList[i].score + "\n";
                if (i < 5)
                {
                    //top5Output.Text += Form1.scores[i] + "\n";
                    top5Output.Text += (i+1) + ". " + Form1.highscoreList[i].name + "     " + Form1.highscoreList[i].score + "\n";
                }
                else if (i >= 5 && i < 10)
                {
                    //next5Output.Text += Form1.scores[i] + "\n";
                    next5Output.Text += (i+1) + ". " + Form1.highscoreList[i].name + "     " + Form1.highscoreList[i].score + "\n";
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            MainScreen ms = new MainScreen();
            f.Controls.Add(ms);
        }
    }
}
