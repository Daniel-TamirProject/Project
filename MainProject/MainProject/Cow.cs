﻿using System;
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

        public Cow(int id) : base(1,id)
        {
            photo = new PictureBox();

            photo.Name = "cow";
            photo.Width = 50;
            photo.Height = 50;

            photo.Image = MainProject.Properties.Resources.cow2_removebg_preview;
            photo.SizeMode = PictureBoxSizeMode.StretchImage;
            photo.Image = MainProject.Properties.Resources.cow2_removebg_preview;
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

        //internal void photo_Click(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
        internal int photo_Click(object sender, EventArgs e)
        {
            return this.numOfProduct;
        }
    }


    
}
