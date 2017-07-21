using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tp2_Anthony_Robert
{
    public class AliveObject
    {
        PictureBox _pic;
        int _speedx;
        int _speedy;

        public AliveObject(PictureBox pic)
        {
            _pic = pic;
        }

        public void init(Point position, int speedX, int speedY)
        {
            _pic.Location = position;
            _speedx = speedX;
            _speedy = speedY;
        }

        public PictureBox Picture
        {
            get
            {
                return _pic;
            }
        }

        public void move()
        {
            int posX = _pic.Location.X + _speedx;
            int posY = _pic.Location.Y + _speedy;
            _pic.Location = new Point(posX, posY);
        }
    }
}
