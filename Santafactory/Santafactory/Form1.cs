
using Santafactory.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santafactory
{
    public partial class mainPanel : Form
    {
        List<Ball> _balls = new List<Ball>();
        private BallFactory _ballFactory;

        public BallFactory BallFactory
        {
            get { return _ballFactory; }
            set { _ballFactory = value; }
        }

        public mainPanel()
        {
            InitializeComponent();
            BallFactory = new BallFactory();

            

        }

        private void createtimer_Tick(object sender, EventArgs e)
        {
            var ball = BallFactory.Createnew();
            _balls.Add(ball);
            panel1.Controls.Add(ball);
            ball.Left = -ball.Width;
        }

        private void conventorytimer_Tick(object sender, EventArgs e)
        {
            var lastPosition = 0;

            foreach (var item in _balls)
            {
                item.MoveBall();
                if (item.Left > lastPosition)
                {
                    lastPosition = item.Left;
                }
            }

            if (lastPosition>=1000)
            {
                var oldestBall = _balls[0];
                panel1.Controls.Remove(oldestBall);
                _balls.Remove(oldestBall);

            }
        }
    }
}
