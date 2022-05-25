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
using System.Runtime.InteropServices;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Media;
using MainProject.classes;

namespace MainProject
{
    [Serializable]
    public partial class Game : Form
    {
        public List<Product> products = new List<Product>();
        Product futureBorn;
        int coinCounter = 0;
        int flag = 1, index=-1;
        SoundPlayer ding = new SoundPlayer(MainProject.Properties.Resources.Ding);
        

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
            if (new Point(e.X,e.Y) == RightBorder.Location)
            {
                return;
            }
            if (new Point(e.X,e.Y) == LeftBorder.Location)
            {
                return;
            }
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
                if (e.X > 600 || e.X < 0 || e.Y < 0 || e.Y > 400 || (e.X < 90 && e.Y > 240))
                    return;
                p.x = e.X;
                p.y = e.Y;

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

        private void cornPic_Click_1(object sender, EventArgs e)
        {
            flag = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory(); ;
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, products);

                    bin.Serialize(stream, coinCounter);

                    bin.Serialize(stream, milkBar.Value);
                    bin.Serialize(stream, eggsBar.Value);
                    bin.Serialize(stream, cornBar.Value);
                    bin.Serialize(stream, appleBar.Value);

                    bin.Serialize(stream, Animal.numberOfAnimals);
                    bin.Serialize(stream, Plant.numberOfPlants);
                }
            }
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                products = (List<Product>)binaryFormatter.Deserialize(stream);

                coinCounter = (int)binaryFormatter.Deserialize(stream);

                milkBar.Value = (int)binaryFormatter.Deserialize(stream);
                eggsBar.Value = (int)binaryFormatter.Deserialize(stream);
                cornBar.Value = (int)binaryFormatter.Deserialize(stream);
                appleBar.Value = (int)binaryFormatter.Deserialize(stream);

                Animal.numberOfAnimals = (int)binaryFormatter.Deserialize(stream);
                Plant.numberOfPlants = (int)binaryFormatter.Deserialize(stream);

                pictureBox1.Invalidate();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < products.Count; i++)
            {
                products[i].count--;

                if (products[i].count < 0)
                {
                    switch (products[i].type)
                    {
                        case 1:
                            milkBar.PerformStep();
                            break;

                        case 2:
                            eggsBar.PerformStep();
                            break;

                        case 3:
                            appleBar.PerformStep();
                            break;

                        case 4:
                            cornBar.PerformStep();
                            break;

                        default:
                            break;
                    }
                    products[i].count = 10;
                }
                
                products[i].countDown = products[i].count.ToString();
            }

            if(milkBar.Value == milkBar.Maximum)
            {
                coinCounter += 10;
                addCoins();
                milkBar.Value = 0;
            }
            else if (eggsBar.Value == eggsBar.Maximum)
            {
                coinCounter += 10;
                addCoins();
                eggsBar.Value = 0;
            }
            else if (appleBar.Value == appleBar.Maximum)
            {
                coinCounter += 10;
                addCoins();
                appleBar.Value = 0;
            }
            else if (cornBar.Value == cornBar.Maximum)
            {
                coinCounter += 10;
                addCoins();
                cornBar.Value = 0;
            }


            pictureBox1.Invalidate();
        }
        void addCoins()
        {
            coins.Text = coinCounter.ToString();
            ding.Play();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for(int i=0;i<products.Count;i++)
            {
                products[i].Draw(e.Graphics);

                if (products[i].type == 3) //Apple
                    e.Graphics.DrawString(products[i].countDown, this.Font, Brushes.Black, new Point(products[i].x - 5, products[i].y - 45));
                else if (products[i].type == 4) // Corn
                    e.Graphics.DrawString(products[i].countDown, this.Font, Brushes.Black, new Point(products[i].x - 5, products[i].y - 45));
                else //Cow and Chickhen
                    e.Graphics.DrawString(products[i].countDown, this.Font, Brushes.Black, new Point(products[i].x - 5, products[i].y - 40));
            }

            coins.Text = coinCounter.ToString();
            animalCounter.Text = "Animals: " + Animal.numberOfAnimals;
            plantCounter.Text = "Plants: " + Plant.numberOfPlants;
        }
    }
}





