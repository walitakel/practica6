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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            f.Show();
            this.Hide();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            Form2 f1 = new Form2();
            Form3 f2 = new Form3();
            Form5 f3 = new Form5();
            Form6 f4 = new Form6();
            Form7 f5 = new Form7();
            f.Close();
            f1.Close();
            f2.Close();
            f3.Close();
            f4.Close();
            f5.Close();
            

        }
    }
}
