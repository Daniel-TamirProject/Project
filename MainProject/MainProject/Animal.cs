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
    class Animal
    {   
        public int breed; //{ 1 = Cow, 2 = Chicken }
        public String name;
        public static int numberOfAnimal;
        public PictureBox photo;

        //public Animal(int bre, string na)
        //{
        //    breed = bre;
        //    name = na;
        //    if (bre == 1)
        //    {
        //        photo.Name = "cow";
        //        photo.Width = 50;
        //        photo.Height = 50;

        //        photo.Image = MainProject.Properties.Resources.cow2_removebg_preview;
        //        //picture1.Image = Image.FromFile(@"C:\Users\danie\Documents\GitHub\Project\MainProject\MainProject\Resources\cow2.jpg");
        //        photo.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //    else if (bre == 2)
        //    {
        //        photo.Name = "duck";
        //        photo.Width = 50;
        //        photo.Height = 50;

        //        photo.Image = MainProject.Properties.Resources.cow2_removebg_preview;
        //        //picture1.Image = Image.FromFile(@"C:\Users\danie\Documents\GitHub\Project\MainProject\MainProject\Resources\cow2.jpg");
        //        photo.SizeMode = PictureBoxSizeMode.StretchImage;
        //    }
        //}


    }
}
