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
        List<Ship> ships = new List<Ship>();
        List<Chicken> chickens = new List<Chicken>();
        Cow newcow;
        Ship newship;
        Chicken newchicken;


        int flag, x, y, index;
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
            index = -1;
            for (int i = 0; i < cows.Count; i++)
            {
                if (cows[i].isInside(e.X, e.Y))
                {
                    index = i;
                    string s = e.Button.ToString();
                    if (s == "right")
                    {
                        newcow = cows[i];
                        cows.Remove(newcow);
                        backgroundpanel.Controls.Remove(newcow.photo);
                        index = -1;
                    }
                }

                if (index < 0)
                {
                    switch (flag)
                    {
                        case 1:
                            newcow = new Cow(id, e.X, e.Y);
                            cows.Add(newcow);
                            backgroundpanel.Controls.Add(newcow.photo);
                            break;

                        case 2:
                            newchicken = new Chicken(id, e.X, e.Y);
                            chickens.Add(newchicken);
                            backgroundpanel.Controls.Add(newchicken.photo);
                            break;

                        case 3:
                            newship = new Ship(id, e.X, e.Y);
                            ships.Add(newship);
                            backgroundpanel.Controls.Add(newship.photo);
                            break;

                    }
                }
            }
        }

        //private void backgroundpanel_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        switch (flag)
        //        {
        //            case 1:
        //                newcow = new Cow(id, e.X, e.Y);
        //                cows.Add(newcow);
        //                backgroundpanel.Controls.Add(newcow.photo);
        //                break;

        //            case 2:
        //                newchicken = new Chicken(id, e.X, e.Y);
        //                chickens.Add(newchicken);
        //                backgroundpanel.Controls.Add(newchicken.photo);
        //                break;

        //            case 3:
        //                newship = new Ship(id, e.X, e.Y);
        //                ships.Add(newship);
        //                backgroundpanel.Controls.Add(newship.photo);
        //                break;

        //        }
                    
        //    }
        //    else if (e.Button == MouseButtons.Right)
        //    {

        //    }


        //    //    //if (cows.Count > 0)
        //    //    //{
        //    //    //    newcow = cows[0];
        //    //    //    cows.Remove(newcow);
        //    //    //    backgroundpanel.Controls.Remove(newcow.photo);
        //    //    //    id--;
        //    //    //}



        //    //    //counter.Text = "num:" + cows.Count();
        //    //}

        //    //idtest = newcow.photo_Click(sender, e);
        //    //backgroundpanel.Controls.Remove(picture1);
        //}

        private void Picture1_Click(object sender, EventArgs e)
        {
            //if (items.Count > 0)
            //{
            //    //for (int i = 0; i < items.Count; i++)
            //    //{
            //    //    if (items[i].photo.Location == )
            //    //    {

            //    //    }
            //    //}
            //    items.Remove(newcow);
            //    backgroundpanel.Controls.Remove(newcow.photo);
            //}

            for (int i = 0; i < cows.Count; i++)
            {
                if (cows[i].isInside(x, y))
                {
                    newcow = cows[i];
                    cows.Remove(newcow);
                    backgroundpanel.Controls.Remove(newcow.photo);
                    id--;
                }
            }

            counter.Text = "num:" + cows.Count();
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
        private void adamaPic_Click(object sender, EventArgs e)
        {

        }
    }
}
















//PictureBox picture1 = new PictureBox();

//picture1.Name = "cow";
//picture1.Width = 50;
//picture1.Height = 50;

//int x = e.X - picture1.Width / 2;
//int y = e.Y - picture1.Height / 2;

//picture1.Location = new Point(x, y);
//picture1.Image = MainProject.Properties.Resources.cow2_removebg_preview;
////picture1.Image = Image.FromFile(@"C:\Users\danie\Documents\GitHub\Project\MainProject\MainProject\Resources\cow2.jpg");
//picture1.SizeMode = PictureBoxSizeMode.StretchImage;
//picture1.Visible = true;

//picture1.Click += Picture1_Click;
//items.Add(picture1);
//backgroundpanel.Controls.Add(picture1);