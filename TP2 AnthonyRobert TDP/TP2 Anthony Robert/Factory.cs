using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tp2_Anthony_Robert
{
    public abstract class Factory
    {
        private List<AliveObject> _picture;
        private List<AliveObject> _available = new List<AliveObject>();
        private List<AliveObject> _isUse = new List<AliveObject>();
        protected Random rand = new Random(DateTime.Now.Millisecond);
        private int _maxObject = 7;
        private Point _location;
        

        private Form _form;

        public delegate void OnEnterForm(object source, EventArgs args);
        public event OnEnterForm onEnterForm;

        public delegate void OnExitForm(object source, EventArgs args);
        public event OnExitForm onExitForm;

        public Factory(Form form)
        {
            _form = form;
            GameLoop.update += update;
        }

        private void createFallingStar()
        {
            Random rnd = new Random();
            int rXc = rnd.Next(-9, 7);
            int rYc = rnd.Next(5);

            _picture = new List<AliveObject>();
            for (int i = 0; i < _maxObject; i++)
            {
                AliveObject alivo;
                if(_available.Count > 0)
                {
                    alivo = _available[0];
                    _available.RemoveAt(0);
                    alivo.init(_location, rXc, -rYc);
                }
                else
                {
                    alivo = create();
                }
                _picture.Add(alivo);
                _form.Controls.Add(alivo.Picture);
                
            }
        }
        public AliveObject spawn(Point cursorPoint)
        {
            AliveObject pic;
            if (_available.Count > 0)
            {
                pic = _available[0];
                _available.RemoveAt(0);
            }
            else
            {
                pic = create();
            }

            init(pic, cursorPoint);
        
            _isUse.Add(pic);

            if (onEnterForm != null)
            {
                onEnterForm(this, EventArgs.Empty);
            }
            _form.Controls.Add(pic.Picture);

            return pic;
        }

        public void update(object source, EventArgs args)
        {
            for (int i = _isUse.Count - 1; i >= 0; i--)
            {
                AliveObject pic = _isUse[i];
                pic.move();
                Point location = pic.Picture.Location;
                if (location.X < 0 || location.X > GameLoop.LimitX || location.Y < 0 || location.Y > GameLoop.LimitY)
                {
                    _isUse.RemoveAt(i);
                    _form.Controls.Remove(pic.Picture);
                    if (onExitForm != null)
                    {
                        onExitForm(this, EventArgs.Empty);
                    }
                }
            }
        }

        protected abstract AliveObject create();

        protected abstract void init(AliveObject pic, Point currentPosition);
    }
}
