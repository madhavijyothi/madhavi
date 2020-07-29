using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using EntityLayer;

namespace StudentManagement
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btnfeepay_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4 ();
            f4.Show();
        }

        private void btnaddstu_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1 ();
            f1.Show();
        }

        private void btnaddcour_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3 ();
            f3.Show();
        }

        private void btnaddteach_Click(object sender, EventArgs e)
        {

            Form f2 = new Form2();
            f2.Show();
        }
    }
}
