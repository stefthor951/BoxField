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
            LoadDB();
        }
        public static List<Highscore> highscoreList = new List<Highscore>();
        public static List<int> scores = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            MainScreen ms = new MainScreen();
            this.Controls.Add(ms);
        }
        public void LoadDB()
        {
            string newScore = "";
            string newName = "";
            int items = 1;
            //Open the xml file
            XmlTextReader reader = new XmlTextReader("highscoreDB.xml");

            // Clear output label
            //outputLabel.Text = "";

            // Continue to read each element and text until the file is done
            while (reader.Read())
            {
                // If the currently read item is text then print it to screen,
                // otherwise the loop repeats getting the next piece of information
                if (reader.NodeType == XmlNodeType.Text)
                {
                    switch (items)
                    {
                        case 1:
                            newName = reader.Value;
                            break;
                        case 2:
                            newScore = reader.Value;
                            Highscore hs = new Highscore(newName, newScore);
                            highscoreList.Add(hs);
                            scores.Add(Convert.ToInt16(hs.score));
                            items = 0;
                            break;
                    }
                    items++;
                }
            }
            reader.Close();
            // below is a for loop that does the exact same thing as
            // the foreach loop above. It is here for reference only
            //
            //for (int i = 0; i < MainForm.characterDB.Count(); i++)
            //{
            //    heroSelect.Items.Add(MainForm.characterDB[i].name);
            //}
        }
        // Program goes directly to the GameScreen method on start
        

    }
}
