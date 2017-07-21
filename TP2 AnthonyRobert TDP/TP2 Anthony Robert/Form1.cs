using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2_Anthony_Robert
{
    public partial class Form1 : Form
    {
        GameLoop _gameLoop;
        Factory _heartFactory;
        Factory _starFactory;
        bool _spacePressed;
        int _starCount = 0;
        int _heartCount = 0;

        public Form1()
        {
            InitializeComponent();
            _gameLoop = new GameLoop(this);

            _heartFactory = new HeartFactory(this);
            _heartFactory.onEnterForm += increaseHeartCount;
            _heartFactory.onExitForm += decreaseHeartCount;

            _starFactory = new StarFactory(this);
            _starFactory.onEnterForm += increaseStarCount;
            _starFactory.onExitForm += decreaseStarCount;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point mousePosition = new Point(e.X, e.Y);
            if(_spacePressed)
            {
                for (int i = 0; i < 7; i++)
                {
                    _heartFactory.spawn(mousePosition);
                }
            }
            else
            {
                for(int i = 0; i < 7; i ++)
                {
                    _starFactory.spawn(mousePosition);
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                _spacePressed = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                _spacePressed = false;
            }
        }

        private void increaseHeartCount(object source, EventArgs args)
        {
            _heartCount++;
            updateHeartTxt();
        }

        private void decreaseHeartCount(object source, EventArgs args)
        {
            _heartCount--;
            if (_heartCount < 0)
            {
                _heartCount = 0;
            }
            updateHeartTxt();
        }

        private void updateHeartTxt()
        {
            _lblHeart.Text = _heartCount.ToString();
        }

        private void increaseStarCount(object source, EventArgs args)
        {
            _starCount++;
            updateStarTxt();
        }

        private void decreaseStarCount(object source, EventArgs args)
        {
            _starCount--;
            if (_starCount < 0)
            {
                _starCount = 0;
            }
            updateStarTxt();
        }

        private void updateStarTxt()
        {
            _lblStar.Text = _starCount.ToString();
        }
    }
}
