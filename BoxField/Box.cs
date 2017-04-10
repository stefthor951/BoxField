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
        public int x, y, size, speed, colourRed, colourGreen, colourBlue;

        /// <summary>
        /// Constructor method for the boxes
        /// </summary>
        /// <param name="_x">sets the initial x coordinate</param>
        /// <param name="_y">sets the initial y coordinate</param>
        /// <param name="_size">sets the initial speed</param>
        /// <param name="_speed">sets the initial speed</param>
        public Box(int _x, int _y, int _size, int _speed, int _colourRed, int _colourGreen, int _colourBlue)
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
            Rectangle boxRec = new Rectangle(b.x, b.y, b.size, b.size);
            Rectangle playerRec = new Rectangle(x, y, size, size);

            return boxRec.IntersectsWith(playerRec);
        }
    }
}
