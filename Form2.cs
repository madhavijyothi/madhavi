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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txttname_TextChanged(object sender, EventArgs e)
        {

        }
       TeacherEntity entity = new TeacherEntity ();
        TeacherBAL tbal = new TeacherBAL();
             
        private void btnsave_Click(object sender, EventArgs e)
        {
            string Teachername = txttname.Text;
            string subject = txtsubject.Text;
            string qualification = txtqualification .Text;

            MessageBox.Show(Teachername + "\n" +subject  + "\n" + qualification + "\n");
            entity.teachername =Teachername ;
            entity.subject = subject;
            entity.Qualifications = qualification;
            
            try
            {
                var res = tbal.SelectTeacher_Disconnected();

                    MessageBox.Show("Course is added and inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
