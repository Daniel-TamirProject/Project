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
        public Game()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;
            //panel1.Visible = false;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_BackColorChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.Visible = true;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            //PictureBox cow = new PictureBox();
            PictureBox cow = pictureBox1;
            cow.Visible = true;
            //cow.Location = New point(e.Location.X, e.Location.Y);
            //cow.BackgroundImage = "C:\Users\danie\Documents\GitHub\Project\MainProject\MainProject\Resources\cow2.jpg";
            //cow.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal)
            //    + @"C:\Users\danie\Documents\GitHub\Project\MainProject\MainProject\Resources\cow2.jpg");
        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            button5.Visible = true;
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            button7.Visible = true;
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
