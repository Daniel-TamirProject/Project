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
        public Cow() : base(1) // Breed = 1 = Cow
        {
            img = MainProject.Properties.Resources.cow2_removebg_preview1;
            img = resizeImage(img, new Size(65, 65));
            generationSpeed = 2;
        }
        public Cow(int Cx,int Cy) : base(1) // Breed = 1 = Cow
        {          
            x = Cx;
            y = Cy;
            img = MainProject.Properties.Resources.cow2_removebg_preview1;
            img = resizeImage(img, new Size(65, 65));
            generationSpeed = 2;
            countDown.Location = new Point(x - 12, y - 50);
            
            //countDown.Text = "123";
            //countDown.Visible = true;
            //countDown.BringToFront();
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
