using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_6
{
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3();
            f.Show();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Image img;
            Form1 f = new Form1();
            Form5 f2 = new Form5();
            Form7 f3 = new Form7();
            img = f2.pictureBox1.Image;
            
            f.Show();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();
        }
    }
}
