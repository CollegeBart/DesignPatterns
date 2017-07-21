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
    public class StarFactory : Factory
    {
        private Bitmap _heartBitmap = Properties.Resources.star;

        public StarFactory(Form form) : base(form)
        {

        }

        protected override AliveObject create()
        {
            PictureBox star = new PictureBox();
            star.SizeMode = PictureBoxSizeMode.AutoSize;
            star.Image = _heartBitmap;
            int w = _heartBitmap.Width;
            int h = _heartBitmap.Height;
            star.Size = new Size(w, h);
            AliveObject ao = new AliveObject(star);
            return ao;
        }

        protected override void init(AliveObject pic, Point currentPosition)
        {
            pic.init(currentPosition, rand.Next(-8, 8), 5);
        }
    }
}
