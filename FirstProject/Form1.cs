using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;//!!!!!!
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using FIGURES;

namespace FirstProject
{
    public partial class Form1 : Form
    {
        Graphics g;
        int x;
        int y;
        bool move;
        Pen pen;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            x = -1;
            y = -1;
            move = false;
            pen = new Pen(Color.Black, 10);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        FigureList pts = new FigureList();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (*.mdl)|*.mdl|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //!!!!
                    formatter.Serialize(stream, pts);
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
            x = -1;
            y = -1;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == true && x != -1 && y != -1)
            {
                g.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X;
                y = e.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x = e.X;
            y = e.Y;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = pictureBox3.BackColor;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = pictureBox2.BackColor;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = pictureBox1.BackColor;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            pen.Color = pictureBox4.BackColor;
        }
    }
}
