
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntityLayer;

namespace BAL
{
  public class TeacherBAL
    {
       TeacherDAL  tdal = new TeacherDAL();
        private int InsertCourse_SP(TeacherEntity entity)
        {
            if (string.IsNullOrEmpty(entity.teachername ))
                throw new Exception("teacher Name cannot be blank");

            if (string.IsNullOrEmpty(entity.subject ))
                throw new Exception("subject cannot be blank");

            if (string.IsNullOrEmpty(entity.Qualifications ))
                throw new Exception("qualifications field cannot be blank");

            return tdal.InsertCourse_SP(entity);
            
        }

        public DataSet SelectTeacher_Disconnected()
        {
            return tdal.SelectTeacher_Disconnected();
        }
        }
}
