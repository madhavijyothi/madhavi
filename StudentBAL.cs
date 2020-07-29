using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntityLayer;
using System.Data;
using System.Text.RegularExpressions;

namespace BAL
{
    public class StudentBAL
    {
        StudentDAL sdal = new StudentDAL();
        public bool AddStudent(StudentEntity entity)
        {
            if (string.IsNullOrEmpty(entity.fname))
                throw new Exception("first Name cannot be blank");

            if (string.IsNullOrEmpty(entity.sname))
                throw new Exception("sur name cannot be blank");

            string expr = @"^\S+@\S+$";
            Regex email = new Regex(expr);
            if (email.IsMatch(entity.Email))
            { }
            else
                throw new Exception("email format incorrect");

            string expr1 = @"\d{6}";
            Regex pincode = new Regex(expr1);
            if (pincode.IsMatch(entity.pincode.ToString()))
            { }
            else
                throw new Exception("pincode is invalid");

            string expr2 = @"\d{10}";
            Regex contact = new Regex(expr2);
            if (pincode.IsMatch(entity.contact.ToString()))
            { }
            else
                throw new Exception("MobNo is invalid");

            string fee = entity.fees.ToString();

            if (string.IsNullOrEmpty(fee))
                throw new Exception("feee feild cannot be blank");

            if (string.IsNullOrEmpty(entity.college))
                throw new Exception("college Name cannot be blank");

            if (string.IsNullOrEmpty(entity.startdate))
                throw new Exception("start date cannot be blank");

            if (string.IsNullOrEmpty(entity.enddate))
                throw new Exception("end date cannot be blank");

            return sdal.AddStudent(entity);

        }
        public StudentEntity SelectbySID(int sid)
        {
            if (sid <= 0)
                throw new Exception("student Id cant be zero or negative");

            if (string.IsNullOrEmpty(sid.ToString()))

                throw new Exception("student id cant be blank");

            return sdal.SelectBySID(sid);

        }
    }
    }

