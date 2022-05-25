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
    class Plant : Product
    {
        public int kind; //{ 1 = Cow, 2 = Chicken }
        public static int numberOfPlants = 0;
        public Plant()//defult cons
        {
            kind = 0;
        }
        public Plant(int knd) : base(knd)
        {
            kind = knd;
            numberOfPlants++;
        }
        public override bool IsInside(int xP, int yP)
        {
            return true;
        }
        public override Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public override void Draw(Graphics g) { }
        ~Plant()
        {
            numberOfPlants--;
        }

    }
}