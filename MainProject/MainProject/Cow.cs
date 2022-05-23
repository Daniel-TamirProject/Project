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
    class Cow:Animal
    {
        public Cow(int id) : base(1,id)
        {
            img = MainProject.Properties.Resources.cow2_removebg_preview1;
            img = resizeImage(img, new Size(50, 50));
        }
        public Cow(int id,int Cx,int Cy) : base(1, id)
        {          
            x = Cx;
            y = Cy;
            img = MainProject.Properties.Resources.cow2_removebg_preview1;
            img = resizeImage(img, new Size(50, 50));
        }

        public override Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public override bool IsInside(int xP, int yP)
        {
            return Math.Abs(xP - x) <= img.Width / 2 && Math.Abs(yP - y) <= img.Height / 2;
        }
        public override void Draw(Graphics g)
        {
            g.DrawImage(img, x - img.Width / 2, y - img.Height / 2) ;
        }
    }


    
}
