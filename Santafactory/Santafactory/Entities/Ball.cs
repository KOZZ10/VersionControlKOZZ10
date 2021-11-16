using Santafactory.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Santafactory.Entities
{
    public class Ball :Toy
    {
       

        protected override void DrawImage(Graphics g)
        {
            Brush ecset = new SolidBrush(Color.Blue);
            g.FillEllipse(
                ecset, 
                0, 
                0, 
                Width, 
                Height);
        }

       
    }
}
