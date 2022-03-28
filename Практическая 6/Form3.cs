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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.Show();
        }
    }
}
