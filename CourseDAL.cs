using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EntityLayer;
using System.Data;

namespace DAL
{
   
        public class CourseDAL
        {

            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader r = null;
            public int  InsertCourse_SP(CourseEntity entity)
            {
            int cid = 0;
                try
                {
                    con = DBConnect.GetConnection();
                    con.Open();
                cmd = new SqlCommand("InsertCourse", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cnm", entity.Coursename );
                cmd.Parameters.AddWithValue("@fee", entity.fee );
                cmd.Parameters.AddWithValue("@dur", entity.Time );
                SqlParameter outparam = new SqlParameter();
                outparam.ParameterName = "@cid";
                outparam.SqlDbType = SqlDbType.Int;
                outparam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(outparam);

                var res = cmd.ExecuteNonQuery();
                if (res > 0)

                    cid = Convert.ToInt32(outparam.Value);
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
                return cid;
            

        }
    }
}
