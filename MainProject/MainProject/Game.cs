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

            if (e.Button == MouseButtons.Left)
            {
                //PictureBox picture1 = new PictureBox();

                picture1.Name = "cow";
                picture1.Width = 50;
                picture1.Height = 50;

                int x = e.X - picture1.Width / 2;
                int y = e.Y - picture1.Height / 2;

                picture1.Location = new Point(x, y);
                picture1.Image = MainProject.Properties.Resources.cow2_removebg_preview;
                //picture1.Image = Image.FromFile(@"C:\Users\danie\Documents\GitHub\Project\MainProject\MainProject\Resources\cow2.jpg");
                picture1.SizeMode = PictureBoxSizeMode.StretchImage;
                picture1.Visible = true;

                picture1.Click += Picture1_Click;
                items.Add(picture1);
                backgroundpanel.Controls.Add(picture1);

                counter.Text = "num:" + items.Count();
            }
            else
            {
                backgroundpanel.Controls.Remove(picture1);
            }
            
        }

        private void Picture1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while(i < items.Count())
            {
                if (items[i].Name == this.Name)
                {
                    items[i].Dispose();
                    backgroundpanel.Controls.Remove(this);
                }
            }
            throw new NotImplementedException();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
