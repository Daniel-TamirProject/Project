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
    class Cow:Animal
    {
        //public static int numberOfCow;
        public PictureBox photo;
        public float x, y;

        public Cow(int id) : base(1,id)
        {
            photo = new PictureBox();

            photo.Name = "cow";
            photo.Width = 50;
            photo.Height = 50;

            photo.Image = MainProject.Properties.Resources.cow2_removebg_preview;
            photo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public Cow(int id,float Cx,float Cy) : base(1, id)
        {
            photo = new PictureBox();

            photo.Name = "cow";
            photo.Width = 50;
            photo.Height = 50;

            photo.Image = MainProject.Properties.Resources.cow2_removebg_preview;
            photo.SizeMode = PictureBoxSizeMode.StretchImage;

            x = Cx;
            y = Cy;
            photo.Location = new Point((int)(Cx - photo.Width / 2), (int)(Cy - photo.Height / 2));
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
        public float X
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

        public float Y
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

        public bool IsInside(int xP, int yP)
        {

            return Math.Abs(xP - x) <= photo.Width / 2 && Math.Abs(yP - y) <= photo.Height / 2;
        }
        
        //public void CreatCow(int id,int Cx,int Cy)
        //{
        //    x = Cx;
        //    y = Cy;
        //    photo.Location = new Point(x, y);
        //}


        //internal void photo_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
        //internal int photo_Click(object sender, EventArgs e)
        //{
        //    return this.numOfProduct;
        //}
    }


    
}
