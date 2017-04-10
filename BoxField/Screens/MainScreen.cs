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
            Application.Exit();
            XmlTextWriter writer = new XmlTextWriter("highscoreDB.xml", null);

            //Write the "CharacterList" element
            writer.WriteStartElement("CharacterList");


            foreach (Highscore hs in Form1.highscoreList)
            {
                //Start "character" element
                writer.WriteStartElement("character");

                //Write sub-elements
                //writer.WriteElementString("name", c.name);
                //writer.WriteElementString("class", c.charClass);
                //writer.WriteElementString("dexterity", c.dexterity);
                //writer.WriteElementString("strength", c.strength);
                //writer.WriteElementString("vitality", c.vitality);
                //writer.WriteElementString("perk", c.perk);

                // end the "character" element
                writer.WriteEndElement();
            }

            // end the "CharacterList" element
            writer.WriteEndElement();

            writer.Close();
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
