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
    class product
    {
        public int type;
        public int numOfProduct;
        Timer lifeTime;


        public product()
        {
            numOfProduct = 0;
            type = 0;
            lifeTime.Start();
        }

        public product(int typ,int id)
        {
            numOfProduct = id;
            type = 0;
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


    }
}
