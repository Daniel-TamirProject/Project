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
        Timer lifeTime;
        public Image img;
        public int x, y;
        public int generationSpeed;
        public Label countDown;


        public Product()
        {
            type = 0;
            lifeTime = new Timer();
            lifeTime.Start();
        }

        public Product(int typ) // type: Animal = 1, Plant = 2
        {
            x = 0;
            y = 0;
            countDown = new Label();
            countDown.Location = new Point(this.x / 2, (this.y / 2) + 20);
            countDown.Text = "123";
            countDown.Visible = true;
            countDown.BringToFront();
            type = typ;
            lifeTime = new Timer();
            lifeTime.Start();
        }

        public abstract Image resizeImage(Image imgToResize, Size size);
        public abstract bool IsInside(int xP, int yP);
        public abstract void Draw(Graphics g);
    }
}
