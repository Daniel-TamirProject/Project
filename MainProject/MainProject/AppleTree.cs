using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    class AppleTree:Plant
    {
        
        public AppleTree() : base(1) // Kind = 1 = Apple
        {
            img = MainProject.Properties.Resources.tree_removebg_preview;
            img = resizeImage(img, new Size(65, 65));
            generationSpeed = 4;
        }
        public AppleTree(int Cx, int Cy) : base(1) // Kind = 1 = Apple
        {
            x = Cx;
            y = Cy;
            img = MainProject.Properties.Resources.tree_removebg_preview;
            img = resizeImage(img, new Size(65, 65));
            generationSpeed = 4;
            countDown.Location = new Point(x - 12, y - 50);
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
    }




}
