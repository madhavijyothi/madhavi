using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;

namespace DAL
{
    public class StudentDAL
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        SqlDataReader r = null;
        public bool AddStudent(StudentEntity entity)
        {
            try
            {
                con = DBConnect.GetConnection();
                con.Open();
                string query = "insert into Student values(@fname,@sname,@add,@email,@pin,@con,@sdate,@edate,@course ,@teach,@cllg,@fee,@year,@paid,@detail)";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fname", entity.fname);
                cmd.Parameters.AddWithValue("@sname", entity.sname);
                cmd.Parameters.AddWithValue("@add", entity.Address);
                cmd.Parameters.AddWithValue("@email", entity.Email);
                cmd.Parameters.AddWithValue("@pin", entity.pincode);
                cmd.Parameters.AddWithValue("@con", entity.contact);

                cmd.Parameters.AddWithValue("@sdate", entity.startdate);
                cmd.Parameters.AddWithValue("@edate", entity.enddate);
                cmd.Parameters.AddWithValue("@course", entity.Course);
                cmd.Parameters.AddWithValue("@teach", entity.teacher);
                cmd.Parameters.AddWithValue("@cllg", entity.college);
                cmd.Parameters.AddWithValue("@fee", entity.fees);
                cmd.Parameters.AddWithValue("@year", entity.year);
                cmd.Parameters.AddWithValue("@detail", entity.detail);
                cmd.Parameters.AddWithValue("@paid", entity.paid);

                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    return true;
            }
            catch (SqlException sql1)
            {
                throw sql1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return false;
        }
        public StudentEntity SelectBySID(int sid)
        {
            StudentEntity entity = new StudentEntity();
            try
            {

                con = DBConnect.GetConnection();
                con.Open();
                string query = "select * from Student where SID=" + sid;
                cmd = new SqlCommand(query, con);
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    entity.fname = r[1].ToString();
                    entity.sname = r[2].ToString();
                    entity.Email = r[4].ToString();
                    //    entity.pincode = r[5].ToString();
                    entity.contact = Convert.ToInt32 (r[6]);
                    entity.Course = r[7].ToString();
                    entity.fees = Convert.ToDouble(r[8]);
                    entity.college = r[9].ToString();
                    entity.paid = Convert.ToDouble(r[15]);
                    entity.remfee = Convert.ToDouble(r[8]) - Convert.ToDouble(r[15]);

                }
                else
                    throw new Exception("nnvalid Student ID");
            }
            catch (SqlException sql1)
            {
                throw sql1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return entity;

        }
    }
}
