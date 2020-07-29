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
using BAL;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        StudentEntity  entity = new StudentEntity ();
        StudentBAL sbal   = new StudentBAL ();
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            string Surname= txtsur .Text;
            string address = txtaddress.Text;
            string email = txtemail.Text;
            string pincode = txtpincode.Text;
            long    Contact = long .Parse(txtcontact .Text);
           
            //combobox
            string course = cbcourse .SelectedItem.ToString();
            string college = cbcollege .SelectedItem.ToString();
            string fees= txtfees.Text;
            string Detail = txtdetail .Text;
            string teacher = cbteacher .SelectedItem.ToString();
            string year= cbyear .SelectedItem.ToString();
            

            MessageBox.Show(name + "\n" +Surname + "\n" + address + "\n"
                + email + "\n" +pincode +"\n"+ Contact + "\n" +course +"\n"+college +"\n"+
                fees  + "\n" + Detail + "\n" + teacher + "\n" + year + "\n");
            entity.fname  = name;
            entity.sname  = Surname ;
            entity.Email = email;
            entity.contact =((int)Contact) ;
            entity.Address = address;
            entity.pincode  = pincode ;
            entity.Course = course;
            entity.college = college;
           // entity.fees  = fees ;
            entity.detail = Detail;
            entity.teacher = teacher;
            entity.year = year;
            try
            {
                var res = sbal.AddStudent (entity);
                if (res)
                    MessageBox.Show("Student is added and inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
