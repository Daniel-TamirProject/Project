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
        //List<PictureBox> items = new List<PictureBox>();
        //SortedList items = new SortedList();
        List<Cow> cows = new List<Cow>();
        List<Product> products = new List<Product>();
        


        Product futureBorn;


        int flag = 1, index;
        int id = 0;
        
        //int idtest = 0;

        public Game()
        {
            InitializeComponent();
        }

        private void backgroundpanel_MouseDown(object sender, MouseEventArgs e)
        {
            string s = e.Button.ToString();
            if (s == "Right")
            {
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].isInside(e.X, e.Y))
                        index = i;
                }
            }
        }

       /* private void backgroundpanel_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Left)
            {
                for(int i = 0;i<products.Count;i++)
                {
                    if (products[i].isInside(e.X, e.Y))
                        //backgroundpanel.Visible = false;
                }                

                futureBorn = getNewProduct(flag, e.X, e.Y);
                products.Add(futureBorn);
                newPic = futureBorn.photo;
              //  backgroundpanel.Controls.Add(newPic);

                newPic.MouseClick += NewPic_MouseClick;
            }
            else if(e.Button == MouseButtons.Right)
            {
                //backgroundpanel.Controls.Remove(products[1].photo);
                //newPic.Click += NewPic_Click;
            }
            // רשימות מקושרות מטריצות קבצים מחרוזות
        }*/

        private void MakeProduct()
        {

        }

        private void NewPic_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Product tempPro = sender as Product;
                // temPic = sender as PictureBox;

               // backgroundpanel.Controls.Remove(tempPro.photo);
            }
        }

        private void NewPic_Click(object sender, EventArgs e)
        {
            
        }

        private void Picture1_Click(object sender, EventArgs e)
        {

            counter.Text = "num:" + cows.Count();
        }

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

        private void Game_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //backgroundpanel.Controls.Remove(products[1].photo);

            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            index = -1;
            if(e.Button == MouseButtons.Left)
            {
                for(int i=0;i<products.Count;i++)
                {
                    if (products[i].isInside(e.X, e.Y))
                    {
                        index = i;
                        string s = e.Button.ToString();
                        if (s == "Right") //if Right button pressed - Remove
                        {
                            products.Remove(products[i]);
                            index = -1;
                            pictureBox1.Invalidate();
                            counter.Text = "111";

                            return;
                        }
                        break;
                    }
                     
                }


                if (index == -1)
                {
                    futureBorn = getNewProduct(flag, e.X, e.Y);
                    products.Add(futureBorn);
                    //newPic = futureBorn.photo;
                    pictureBox1.Invalidate();
                    //newPic.MouseClick += NewPic_MouseClick;

                }

            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for(int i=0;i<products.Count;i++)
            {
                products[i].Draw(e.Graphics);
            }
        }

        private void counter_Click(object sender, EventArgs e)
        {

        }

        private void adamaPic_Click(object sender, EventArgs e)
        {

        }
    }
}





