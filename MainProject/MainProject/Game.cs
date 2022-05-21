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


        int flag = 1, index = -1;
        int id = 0;
        
        //int idtest = 0;

        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            
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

        private void backgroundpanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                futureBorn = getNewProduct(flag, e.X, e.Y);
                products.Add(futureBorn);
                backgroundpanel.Controls.Add(futureBorn.photo);
            }
            else if(e.Button == MouseButtons.Right)
            {
                //backgroundpanel.Controls.Remove(products[1].photo);

            }
            
        }

        private void Picture1_Click(object sender, EventArgs e)
        {
            
            


            /*for (int i = 0; i < cows.Count; i++)
            {
                if (cows[i].isInside(x, y))
                {
                    newcow = cows[i];
                    cows.Remove(newcow);
                    backgroundpanel.Controls.Remove(newcow.photo);
                    id--;
                }
            }*/

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

        private void Game_MouseClick(object sender, MouseEventArgs e)
        {

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
                backgroundpanel.Controls.Remove(products[1].photo);

            }
        }

        private void adamaPic_Click(object sender, EventArgs e)
        {

        }
    }
}





