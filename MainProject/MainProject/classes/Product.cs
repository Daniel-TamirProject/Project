using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace MainProject.classes
{
    [Serializable]
    public abstract class Product
    {
        public int type;
        public Image img;
        public int x, y;
        public int generationSpeed;
        public string countDown;
        public int count=10;

        public Product()
        {
            type = 0;
        }

        public Product(int typ) // type: Animal = 1, Plant = 2
        {
            x = 0;
            y = 0;
            countDown = count.ToString();
         
            type = typ;
         }

        public abstract Image resizeImage(Image imgToResize, Size size);
        public abstract bool IsInside(int xP, int yP);
        public abstract void Draw(Graphics g);

    }
}
