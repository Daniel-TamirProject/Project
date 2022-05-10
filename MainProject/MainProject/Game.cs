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
    public partial class Game : Form
    {
        Random rand = new Random();
        List<PictureBox> items = new List<PictureBox>();
        public Game()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            //panel1.Visible = false;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            
        }

        private void backgroundpanel_MouseClick(object sender, MouseEventArgs e)
        {
            //PictureBox test = new PictureBox();
            //test.Image = MainProject.Properties.Resources.cow2;
            //test.Visible = true;
            //test.Location = new Point(14, 17);


            PictureBox picture1 = new PictureBox();

            picture1.Name = "cow";
            //picture1.Size = new Size(100, 50);
            picture1.Width = 50;
            picture1.Height = 50;
            //picture1.BackColor = Color.Red;

            //int x = rand.Next(10, this.ClientSize.Width - picture1.Width);
            //int y = rand.Next(10, this.ClientSize.Height - picture1.Height);

            int x = e.X;
            int y = e.Y;

            picture1.Location = new Point(x, y);
            picture1.Image = MainProject.Properties.Resources.cow2;
            //picture1.Image = Image.FromFile(@"C:\Users\danie\Documents\GitHub\Project\MainProject\MainProject\Resources\cow2.jpg");
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            picture1.Visible = true;

            picture1.Click += Picture1_Click;
            items.Add(picture1);
            backgroundpanel.Controls.Add(picture1);

            counter.Text = "num:" + items.Count();
        }

        private void Picture1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
