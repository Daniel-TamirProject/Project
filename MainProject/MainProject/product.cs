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
        }

        public abstract bool isInside(int xP, int yP);
        public abstract void Draw(Graphics g);
    }
}
