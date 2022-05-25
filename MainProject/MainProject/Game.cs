﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;
using MainProject.classes;

namespace MainProject
{
    [Serializable]
    public partial class Game : Form
    {
       public List<Product> products = new List<Product>();
        Product futureBorn;

        int flag = 1, index=-1;

        public Game()
        {
            InitializeComponent();
        }

        Product getNewProduct(int flag,int x,int y)
        {
            Product born;
            switch(flag)
            {
                case 1:
                    {
                        born = new Cow(x,y);
                        return born;
                    }
                case 2:
                    {
                        born = new Chicken(x, y);
                        return born;
                    }
                case 3:
                    {
                        born = new AppleTree(x, y);
                        return born;
                    }
                case 4:
                    {
                        born = new Corn(x, y);
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
                        if (products[i].type == 1)
                            Animal.numberOfAnimals--;

                        if (products[i].type == 2)
                            Plant.numberOfPlants--;

                        pictureBox1.Controls.Remove(products[i].countDown);
                        products.Remove(products[i]);
                        animalCounter.Text = "Animals: " + Animal.numberOfAnimals;
                        plantCounter.Text = "Plants: " + Plant.numberOfPlants;
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
                    pictureBox1.Controls.Add(futureBorn.countDown);
                    animalCounter.Text = "Animals: " + Animal.numberOfAnimals;
                    plantCounter.Text = "Plants: " + Plant.numberOfPlants;
                    pictureBox1.Invalidate();

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
                //p.countDown.Location = new Point(p.x - 12, p.y - 35);
                p.resizelable(p.countDown);
                p.countDown.BringToFront();
                
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            index = -1;
        }

        private void treePic_Click(object sender, EventArgs e)
        {
            flag = 3;
        }

        private void adamaPic_Click(object sender, EventArgs e)
        {
            flag = 4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Stream myStream;
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //saveFileDialog1.FilterIndex = 2;
            //saveFileDialog1.RestoreDirectory = true;

            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    if ((myStream = saveFileDialog1.OpenFile()) != null)
            //    {
            //        // Code to write the stream goes here.
            //        IFormatter formatter = new BinaryFormatter();
            //        using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
            //        {
            //            //!!!!
            //            formatter.Serialize(stream, products);
            //        }
            //        myStream.Close();
            //    }
            //}


            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"Desktop";
            //saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            //saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //!!!!
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, products);
                    //formatter.Serialize(stream, products);
                }
            }
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                //!!!!
                products = (List<Product>)binaryFormatter.Deserialize(stream);
                pictureBox1.Invalidate();
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for(int i=0;i<products.Count;i++)
            {
                products[i].Draw(e.Graphics);
            }
        }
    }
}





