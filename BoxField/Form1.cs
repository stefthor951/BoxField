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
        public static List<Highscore> recentScoreList = new List<Highscore>();
        public static List<int> scores = new List<int>();
        public static int currentScore;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDB();
            //Form1.
            MainScreen ms = new MainScreen();

            ms.Location = new Point((this.Width - ms.Width) / 2, (this.Height - ms.Height) / 2);
            this.Controls.Add(ms);
        }

        public void LoadDB()
        {
            #region loading highscores
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
                    }
                }

                highscoreList.Add(hs);
            }
            #endregion

            

        }
        // Program goes directly to the GameScreen method on start


    }
}
