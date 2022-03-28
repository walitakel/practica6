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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1  f = new Form1();
            f.Show();
            
        }
    }
}
