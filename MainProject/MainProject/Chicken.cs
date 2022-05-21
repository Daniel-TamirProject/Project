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
    class Chicken : Animal
    {
        //public static int numberOfCow;
        public PictureBox photo;
        public int x, y;

        public Chicken(int id) : base(1, id)
        {
            photo = new PictureBox();

            photo.Name = "chicken";
            photo.Width = 50;
            photo.Height = 50;

            photo.Image = MainProject.Properties.Resources.chicken2_removebg_preview;
            photo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public Chicken(int id, int Cx, int Cy) : base(1, id)
        {
            photo = new PictureBox();

            photo.Name = "chicken";
            photo.Width = 50;
            photo.Height = 50;

            photo.Image = MainProject.Properties.Resources.chicken2_removebg_preview;
            photo.SizeMode = PictureBoxSizeMode.StretchImage;

            x = Cx - photo.Width / 2;
            y = Cy - photo.Height / 2;
            photo.Location = new Point(x, y);
        }

        public PictureBox Photo
        {
            get
            {
                return photo;
            }
            set
            {
                photo = value;
            }
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public bool isInside(int xP, int yP)
        {
            return Math.Abs(xP - x) <= photo.Width / 2 && Math.Abs(yP - y) <= photo.Height / 2;
        }
    }
}
