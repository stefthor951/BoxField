using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BoxField
{
    public class Highscore
    {
        public string name, score;

        public Highscore(string _name, string _score)
        {
            name = _name;
            score = _score;
        }

        public void save(Highscore hs)
        {
            bool scoreAdded = false;
            //Highscore hs = new Highscore(null, Convert.ToString(Form1.currentScore)); //TODO when highscore screen is finished change null for nameLabel.text (or something like that)

            for (int i = 0; i < Convert.ToInt16(Form1.highscoreList.Count); i++)
            {
                if (Form1.currentScore > Convert.ToInt16(Form1.highscoreList[i].score))
                {
                    Form1.highscoreList.Insert(i, hs);

                    scoreAdded = true;
                    i = Form1.highscoreList.Count;//this is so that it will exit the for loop if this code executes
                }
            }

            if (scoreAdded == false)
            {

                Form1.highscoreList.Add(hs);
            }

            Form1.recentScoreList.Add(hs);
        }

        public void saveScores(List<Highscore> _scoreList)
        {
            //Only saves the top 10 highscores
            if (_scoreList.Count > 10)
            {
                for (int i = _scoreList.Count; i > 10; i--)
                {
                    _scoreList.RemoveAt(i - 1);
                }
            }
            //Creates the xml file where highscores are saved
            XmlTextWriter writer = new XmlTextWriter("highscoreDB.xml", null);

            writer.WriteStartElement("highscoreList");

            foreach (Highscore hs in _scoreList)
            {
                //Start "highscore" element
                writer.WriteStartElement("highscore");

                //Write sub-elements
                writer.WriteElementString("name", hs.name); //This is the name aspect, not needed unless I reintroduce the name aspect of highscores
                writer.WriteElementString("score", hs.score);

                // end the "highscore" element
                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.Close();
        }

        public void saveRecentscores(List<Highscore> _scoreList)
        {
            //Only saves the top 10 highscores
            if (_scoreList.Count > 10)
            {
                for (int i = _scoreList.Count; i > 10; i--)
                {
                    _scoreList.RemoveAt(i - 1);
                }
            }
            //Creates the xml file where highscores are saved
            XmlTextWriter writer = new XmlTextWriter("recentScoreDB.xml", null);

            writer.WriteStartElement("recentScoreList");

            foreach (Highscore hs in _scoreList)
            {
                //Start "recentScore" element
                writer.WriteStartElement("recentScore");

                //Write sub-elements
                writer.WriteElementString("name", hs.name); //This is the name aspect, not needed unless I reintroduce the name aspect of highscores
                writer.WriteElementString("score", hs.score);

                // end the "highscore" element
                writer.WriteEndElement();
            }

            writer.WriteEndElement();

            writer.Close();
        }
    }
}
