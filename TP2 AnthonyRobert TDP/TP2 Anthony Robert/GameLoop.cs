using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tp2_Anthony_Robert
{
    class GameLoop
    {
        private static Timer timer;
        public delegate void Update(object source, EventArgs args);
        public static event Update update;
        //Factory _heartFactory;
        //Factory _starFactory;
        public static int LimitX;
        public static int LimitY;

        private static Form1 _form;

        public GameLoop(Form1 form)
        {
            _form = form;

            LimitX = _form.Width;
            LimitY = _form.Height;

            timer = new Timer();
            timer.Interval = 1000/60;
            timer.Tick += OnTick;
            timer.Start();
        }

        private static void OnTick(object sender, EventArgs e)
        {
            if (update != null)
            {
                update(sender, e);
            }
        }
    }
}
