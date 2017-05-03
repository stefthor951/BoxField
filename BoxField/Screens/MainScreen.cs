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
        public MainScreen()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameScreen gs = new GameScreen();
            f.Controls.Add(gs);
            gs.Focus();
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            HighScoreScreen hs = new HighScoreScreen();
            f.Controls.Add(hs);
            hs.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Highscore hs = new Highscore(null, null);
            hs.saveScores(Form1.highscoreList);
            hs.saveRecentscores(Form1.recentScoreList);

            ////this code gets rid of any score that is not in the top 10
            //if (Form1.scores.Count > 10)
            //{
            //    for (int i = Form1.scores.Count; i > 10; i--)
            //    {
            //        Form1.scores.Remove(i - 1);
            //    }
            //}
            //XmlTextWriter writer = new XmlTextWriter("highscoreDB.xml", null);

            ////Write the "CharacterList" element
            //writer.WriteStartElement("highscoreList");
            ////foreach (Highscore hs in Form1.highscoreList)
            ////{
            ////    //Start "character" element
            ////    writer.WriteStartElement("highscore");

            ////    //Write sub-elements
            ////    writer.WriteElementString("name", hs.name);
            ////    writer.WriteElementString("score", hs.score);

            ////    // end the "character" element
            ////    writer.WriteEndElement();
            ////}
            //for (int i = 0; i < Form1.scores.Count; i++)
            //{
            //    //Start "character" element
            //    writer.WriteStartElement("highscore");

            //    //Write sub-elements
            //    //writer.WriteElementString("name", ""); //This is the name aspect, not needed unless I reintroduce the name aspect of highscores
            //    writer.WriteElementString("score", Convert.ToString(Form1.scores[i]));

            //    // end the "character" element
            //    writer.WriteEndElement();
            //}

            //// end the "CharacterList" element
            //writer.WriteEndElement();

            //writer.Close();

            Application.Exit();
        }

        private void MainScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Q:
                    Application.Exit();
                        break;
                default:
                    break;
            }
        }

        private void MainScreen_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Q:
                    Application.Exit();
                    break;
                default:
                    break;
            }   
        }
    }
}
