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
    [Serializable]
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            
            //this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            //Application.Exit();
            //Game next = new Game();
            //next.ShowDialog();
            this.Hide();
            Game form2 = new Game();
            //form2.Closed += (s, args) => this.Close();
            form2.ShowDialog();
            this.Close();
        }
    }
}
