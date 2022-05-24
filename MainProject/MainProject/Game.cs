using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProject
{
    public partial class Game : Form
    {
        List<Product> products = new List<Product>();
        Product futureBorn;

        int flag = 1, index=-1;
        int id = 0;

        public Game()
        {
            InitializeComponent();
        }

            // רשימות מקושרות מטריצות קבצים מחרוזות
        Product getNewProduct(int flag,int x,int y)
        {
            Product born;
            switch(flag)
            {
                case 1:
                    {
                        born = new Cow(id,x,y);
                        return born;
                    }
                case 2:
                    {
                        born = new Chicken(id, x, y);
                        return born;
                    }
                case 3:
                    {
                        born = new Ship(id, x, y);
                        return born;
                    }
                default:
                    return null;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void ChickenPic_Click(object sender, EventArgs e)
        {
            flag = 2;
        }

        private void shipPic_Click(object sender, EventArgs e)
        {
            flag = 3;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            index = -1;

            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].IsInside(e.X, e.Y))
                {
                    index = i;

                    if (e.Button == MouseButtons.Right) //if Right button pressed - Remove
                    {
                        products.Remove(products[i]);
                        counter.Text = "Counter:" + products.Count.ToString();
                        index = -1;
                        pictureBox1.Invalidate();

                        return;
                    }
                    break;
                }
            }

            if (e.Button == MouseButtons.Left)
            {
                if (index == -1)
                {
                    futureBorn = getNewProduct(flag, e.X, e.Y);
                    products.Add(futureBorn);
                    //newPic = futureBorn.photo;
                    counter.Text = "Counter:" + products.Count.ToString();

                    pictureBox1.Invalidate();
                    //newPic.MouseClick += NewPic_MouseClick;

                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (index >= 0)
            {
                Product p = (Product)products[index];
                p.x = e.X;
                p.y = e.Y;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            index = -1;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < products.Count; i++)
            {
                products[i].Draw(e.Graphics);
            }
        }
    }
}





