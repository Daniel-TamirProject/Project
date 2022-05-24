using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MainProject.classes
{
    [Serializable]
    public class Animal : Product
    {   
        public int breed; //{ 1 = Cow, 2 = Chicken }
        public static int numberOfAnimals = 0;
        public Animal()//defult cons
        {
            breed = 0;
        }
        public Animal(int bre) : base(1)
        {
            breed = bre;
            numberOfAnimals++;
        }
        public override bool IsInside(int xP, int yP)
        {
            return true;
        }
        public override Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }
        public override void Draw(Graphics g)
        {
           
        }
        public override void resizelable(Label countdown)
        { 
            
        }
        ~Animal()
        {
            numberOfAnimals--;
        }
        
    }
}
















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