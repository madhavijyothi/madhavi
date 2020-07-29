using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntityLayer;
using System.Data;


namespace BAL
{
    public class CourseBAL
    {
        CourseDAL cdal = new CourseDAL();
        private void ValidateCourse(CourseEntity entity)
        {
            if (string.IsNullOrEmpty(entity.Coursename ))
                throw new Exception("Course Name cannot be blank");

            if (string.IsNullOrEmpty(entity.Time ))
                throw new Exception("time duration cannot be blank");
            string fee = entity.fee.ToString();

            if (string.IsNullOrEmpty(fee ))
                throw new Exception("fee  cannot be blank");
        }

        public int InsertCourse_SP(CourseEntity entity )
        {
            ValidateCourse(entity);
            return cdal.InsertCourse_SP(entity);
        }
    }
}
