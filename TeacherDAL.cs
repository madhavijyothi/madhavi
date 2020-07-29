using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.ComponentModel.Design;
using System.Data;

namespace DAL
{
   public  class TeacherDAL
    { 
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader r = null;
            public int InsertCourse_SP(TeacherEntity entity)
            {
            int tid = 0;
                try
                {
                    con = DBConnect.GetConnection();
                    con.Open();
                cmd = new SqlCommand("sp_insertTeacher", con);
                cmd.CommandType = CommandType.StoredProcedure;
                   
                    cmd.Parameters.AddWithValue("@tname", entity.teachername );
                    cmd.Parameters.AddWithValue("@sub", entity.subject  );
                    cmd.Parameters.AddWithValue("@qual", entity.Qualifications );
                SqlParameter outparam = new SqlParameter();
                outparam.ParameterName = "@tid";
                outparam.SqlDbType = SqlDbType.Int;
                outparam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outparam);
                var res = cmd.ExecuteNonQuery();

                if (res > 0)

                    tid = Convert.ToInt32(outparam.Value);
                }
                catch (SqlException sql)
                {
                    throw sql;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            return tid;
            }
           
                public DataSet SelectTeacher_Disconnected()
        {
            DataSet ds = null;
            try
            {
                con = DBConnect.GetConnection();
                string query = "select *from Teacher";
                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                ds = new DataSet();
                adp.Fill(ds, "teacher");
            }
            catch (SqlException sql)
            {
                throw sql;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return ds;
        }
           
    }
}
