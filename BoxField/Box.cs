using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BoxField
{
    class Box
    {
        public int size, colourRed, colourGreen, colourBlue;
        public float x, y, speed;

        /// <summary>
        /// Constructor method for the boxes
        /// </summary>
        /// <param name="_x">sets the initial x coordinate</param>
        /// <param name="_y">sets the initial y coordinate</param>
        /// <param name="_size">sets the initial speed</param>
        /// <param name="_speed">sets the initial speed</param>
        public Box(float _x, float _y, int _size, float _speed, int _colourRed, int _colourGreen, int _colourBlue)
        {
            x = _x;
            y = _y;
            size = _size;
            speed = _speed;
            colourRed = _colourRed;
            colourGreen = _colourGreen;
            colourBlue = _colourBlue;
            
        }

        public void Move()
        {
            y += speed;
        }

        public void Move(string direction)
        {
            if (direction == "left")
            {
                x -= speed;
            }

            if (direction == "right")
            {
                x += speed; // 
            }
        }

        public Boolean Collision (Box b)
        {
            Rectangle boxRec = new Rectangle(Convert.ToInt16(b.x), Convert.ToInt16(b.y), b.size, b.size);
            Rectangle playerRec = new Rectangle(Convert.ToInt16(x), Convert.ToInt16(y), size, size);

            return boxRec.IntersectsWith(playerRec);
        }
    }
}
