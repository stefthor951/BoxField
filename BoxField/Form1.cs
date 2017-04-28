//Created by Stefan Thorburn in early to mid april
//A 2d version of the flash game: "Cubefield"

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoxField.Screens;
using System.Xml;

namespace BoxField
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static List<Highscore> highscoreList = new List<Highscore>();
        public static List<int> scores = new List<int>();
        public static int currentScore;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDB();
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }

        public void LoadDB()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("highscoreDB.xml");

            XmlNode parent;
            parent = doc.DocumentElement;
            foreach (XmlNode child in parent.ChildNodes)
            {
                Highscore hs = new BoxField.Highscore(null, null);
                foreach (XmlNode grandChild in child.ChildNodes)
                {
                    if (grandChild.Name == "name")
                    {
                        hs.name = grandChild.InnerText;
                    }
                    if (grandChild.Name == "score")
                    {
                        hs.score = grandChild.InnerText;
                        scores.Add(Convert.ToInt16(child.InnerText));
                    }
                }
                
                highscoreList.Add(hs);
            }

            //string newScore = "";
            //string newName = "";
            //int items = 1;
            ////Open the xml file
            //XmlTextReader reader = new XmlTextReader("highscoreDB.xml");

            //// Clear output label
            ////outputLabel.Text = "";

            //// Continue to read each element and text until the file is done
            //while (reader.Read())
            //{
            //    // If the currently read item is text then print it to screen,
            //    // otherwise the loop repeats getting the next piece of information
            //    if (reader.NodeType == XmlNodeType.Text)
            //    {
            //        switch (items)
            //        {
            //            //case 1:
            //            //    newName = reader.Value;
            //            //    break;
            //            case 1:
            //                newScore = reader.Value;
            //                //Highscore hs = new Highscore(newName, newScore);
            //                //highscoreList.Add(hs);
            //                scores.Add(Convert.ToInt16(newScore));
            //                items = 0;
            //                break;
            //        }
            //        items++;
            //    }
            //}
            //reader.Close();

        }
        // Program goes directly to the GameScreen method on start


    }
}
