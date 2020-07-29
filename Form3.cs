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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
       CourseEntity  entity = new CourseEntity ();
        CourseBAL cbal = new CourseBAL ();
        private void btnsave_Click(object sender, EventArgs e)
        {
            string Coursename = txtcname .Text;
            string Coursefee = txtCfees .Text;
            string Timeduration= cbtime .SelectedItem.ToString(); 

          
          MessageBox.Show(Coursename + "\n" + Coursefee  + "\n" + Timeduration + "\n");

            entity.Coursename  = Coursename ;
            entity.fee =Coursefee;
            entity.Time = Timeduration;
           // entity.DateOfJoining = txtDate.Text;
            try
            {
                int res = cbal.InsertCourse_SP(entity);

                if (res>0)

                    MessageBox.Show("course is added and Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
