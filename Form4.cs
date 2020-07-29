using BAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;

namespace StudentManagement
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string Studentname = txtstname1.Text;
            string Studentname1 = txtstname2.Text;
            string Email = txtEmail.Text;
            string Totalfee = txttofee.Text;
            string Paidfee = txtpaidfee.Text;

            string mobileno = txtmobile.Text;

            string Remfees = txtrfee.Text;
            string  Course=  cbcour .SelectedItem.ToString();
            string college = cbcolleg.SelectedItem.ToString();
            string Addfee = txtaddfee.Text;
           
            

            MessageBox.Show(Studentname +Studentname1 +"\n"+Email +"\n"+
                Totalfee +"\n"+Paidfee +"\n"+mobileno +"\n"+Course +"\n"+
                college +"\n"+Remfees +"\n"+Addfee +"\n");

        }
        StudentBAL fbal = new StudentBAL();
        private void btnview_Click(object sender, EventArgs e)
        {
         groupBox1.Visible = true ;
        groupBox2.Visible = true ;

           /* try

            {
                var res = fbal.SelectbySID(int.Parse(txtstudentid.Text));
                if (res != null)
                {
                    txtstname1.Text = res.sname;
                    txtstname2.Text = res.fname;
                    txtEmail.Text = res.Email;
                    txtmobile.Text = res.   contact;
                    txtpaidfee.Text = res.paid;
                    txttofee.Text = res.fees;
                    txtrfee.Text = res.remfee;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true ;
            groupBox2.Visible = false;
        }

        private void txtstudentid_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
