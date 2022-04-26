using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w')
            {
                //label1.Top -= 100;
                pictureBox1.Top -= 10;
            }
            if (e.KeyChar == 's')
            {
                //label1.Top += 100;
                pictureBox1.Top += 10;
            }
            if (e.KeyChar == 'd')
            {
                pictureBox1.Left += 10;
            }
            if (e.KeyChar == 'a')
            {
                pictureBox1.Left -= 10;
            }
        }
    }
}
