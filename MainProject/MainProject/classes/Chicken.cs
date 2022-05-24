using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MainProject.classes
{
    [Serializable]
    public class Chicken : Animal
    {
        public Chicken() : base(2) // Breed = 2 = Chicken
        {

            img = MainProject.Properties.Resources.chicken2_removebg_preview1;
            img = resizeImage(img, new Size(30, 30));
            generationSpeed = 4;
        }

        public Chicken(int Cx, int Cy) : base(2) // Breed = 2 = Chicken
        {
            x = Cx;
            y = Cy;
            img = MainProject.Properties.Resources.chicken2_removebg_preview1;
            img = resizeImage(img, new Size(30, 30));
            generationSpeed = 4;
            //countDown.Location = new Point(x - 12, y - 35);
            //resizelable(countDown);
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
            g.DrawImage(img, x - img.Width / 2, y - img.Height / 2);
        }
        public override void resizelable(Label countdown)
        {
            countdown.Location = new Point(x - 12, y - 30);
        }
    }
}
