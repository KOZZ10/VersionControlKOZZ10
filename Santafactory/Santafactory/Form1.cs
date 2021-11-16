
using Santafactory.Abstractions;
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
        List<Toy> _toys = new List<Toy>();
       private Toy _nextToy;
        private IToyFactory _toyFactory;

        public IToyFactory ToyFactory
        {
            get { return _toyFactory; }
            set { 
                _toyFactory = value;
                DisplayNext();
            }
        }

        public mainPanel()
        {
            InitializeComponent();
            ToyFactory = new CarFactory();

            

        }

        private void createtimer_Tick(object sender, EventArgs e)
        {
            var toy = ToyFactory.CreateNew();
            _toys.Add(toy);
            panel1.Controls.Add(toy);
            toy.Left = -toy.Width;
        }

        private void conventorytimer_Tick(object sender, EventArgs e)
        {
            var lastPosition = 0;

            foreach (var item in _toys)
            {
                item.MoveToy();
                if (item.Left > lastPosition)
                {
                    lastPosition = item.Left;
                }
            }

            if (lastPosition>=1000)
            {
                var oldestToy = _toys[0];
                panel1.Controls.Remove(oldestToy);
                _toys.Remove(oldestToy);

            }
        }

        private void btn_car_Click(object sender, EventArgs e)
        {
            ToyFactory = new CarFactory();
        }

        private void btn_ball_Click(object sender, EventArgs e)
        {
            ToyFactory = new BallFactory()
            {
                BallColor = btn_color.BackColor

            };

        }

        private void btn_present_Click(object sender, EventArgs e)
        {
            ToyFactory = new PresentFactory()
            {
                BoxColor = btn_boxcolor.BackColor,
                RibbonColor = btn_ribboncolor.BackColor
            };
        }
        private void DisplayNext()
        {
            if (_nextToy != null)
                this.Controls.Remove(_nextToy);
            _nextToy = ToyFactory.CreateNew();
            _nextToy.Top = lbl_next.Top ;
            _nextToy.Left = lbl_next . Left + lbl_next.Width;
            this.Controls.Add(_nextToy);
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            var cd = new ColorDialog();
            cd.Color = button.BackColor;

            if (cd.ShowDialog() != DialogResult.OK)
                return;
            button.BackColor = cd.Color;
            
        }

        
    }
}
