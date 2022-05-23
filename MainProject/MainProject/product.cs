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
    class Product
    {
        public int type;
        public int numOfProduct;
        Timer lifeTime;


        public Product()
        {
            numOfProduct = 0;
            type = 0;

            lifeTime = new Timer();
            lifeTime.Start();
        }

        public Product(int typ,int id)
        {
            numOfProduct = id;
            type = typ;

            lifeTime = new Timer();
            lifeTime.Start();
        }
        public int Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public int NumOfProduct
        {
            get
            {
                return numOfProduct;
            }
            set
            {
                numOfProduct = value;
            }
        }

        public Timer LifeTime
        {
            get
            {
                return lifeTime;
            }
            set
            {
                lifeTime = value;
            }
        }


       // public abstract bool IsInside(int xP, int yP);
    }
}
