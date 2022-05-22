using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MainProject
{
    class Chicken : Animal
    {

        public int x, y;
        public Chicken(int id) : base(1, id)
        {

            img = MainProject.Properties.Resources.chicken2_removebg_preview;
        }

        public Chicken(int id, int Cx, int Cy) : base(1, id)
        {
            x = Cx;
            y = Cy;
            img = MainProject.Properties.Resources.chicken2_removebg_preview;
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public override bool isInside(int xP, int yP)
        {
            return Math.Abs(xP - x) <= img.Width / 2 && Math.Abs(yP - y) <= img.Height / 2;
        }
        public override void Draw(Graphics g)
        {
            g.DrawImage(img, x - img.Width / 2, y - img.Height / 2);
        }
    }
}
