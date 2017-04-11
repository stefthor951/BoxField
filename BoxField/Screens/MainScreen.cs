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
        }

        private void highScoreButton_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            HighScoreScreen hs = new HighScoreScreen();
            f.Controls.Add(hs);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            XmlTextWriter writer = new XmlTextWriter("highscoreDB.xml", null);

            //Write the "CharacterList" element
            writer.WriteStartElement("highscoreList");
            foreach (Highscore hs in Form1.highscoreList)
            {
                //Start "character" element
                writer.WriteStartElement("highscore");

                //Write sub-elements
                writer.WriteElementString("name", hs.name);
                writer.WriteElementString("score", hs.score);

                // end the "character" element
                writer.WriteEndElement();
            }

            // end the "CharacterList" element
            writer.WriteEndElement();

            writer.Close();

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
