using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Tp2_Anthony_Robert
{
    public class HeartFactory : Factory
    {
        private Bitmap _heartBitmap = Properties.Resources.heart;

        public HeartFactory(Form form) : base(form)
        {
        }

        protected override AliveObject create()
        {
            PictureBox heart = new PictureBox();
            heart.SizeMode = PictureBoxSizeMode.AutoSize;
            heart.Image = _heartBitmap;
            int w = _heartBitmap.Width;
            int h = _heartBitmap.Height;
            heart.Size = new Size(w, h);
            AliveObject ao = new AliveObject(heart);
            return ao;
        }

        protected override void init(AliveObject pic, Point currentPosition)
        {
            pic.init(currentPosition, rand.Next(-9, 7), -5);
        }
    }
}
