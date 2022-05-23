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
    public abstract class Product
    {
        public int type;
        public int numOfProduct;
        Timer lifeTime;
        public Image img;
        public int x, y;

        public Product()
        {
            numOfProduct = 0;
            type = 0;
            lifeTime = new Timer();
            lifeTime.Start();
        }

        public Product(int typ,int id)
        {
            x = 0;
            y = 0;
            numOfProduct = id;
            type = typ;
            lifeTime = new Timer();
            lifeTime.Start();
            //img = new Bitmap(img, new Size(10,10));
            //img = resizeImage(img, new Size(50, 50));
        }

        public abstract Image resizeImage(Image imgToResize, Size size);
        public abstract bool IsInside(int xP, int yP);
        public abstract void Draw(Graphics g);
    }
}
