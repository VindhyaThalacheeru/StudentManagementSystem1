using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCourseRegistration
{
    public class Connected
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        public SqlConnection ConnectionEstablish()
        {
            string cs = ConfigurationManager.ConnectionStrings["atmsms"].ConnectionString;
            con = new SqlConnection(cs);
            return con;
        }
        public Boolean ReadData()
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Course1";
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2] + " " + rdr[3] + " " + rdr[4]);
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean CreateData(Course1 c)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into dbo.Course1 values (@courseId ,@courseName,@courseDetail,@duration,@fees)";
            cmd.Parameters.AddWithValue("@courseId", c.CourseId);
            cmd.Parameters.AddWithValue("@courseName", c.CourseName);
            cmd.Parameters.AddWithValue("@courseDetail", c.CourseDetail);
            cmd.Parameters.AddWithValue("@duration", c.Duration);
            cmd.Parameters.AddWithValue("@fees", c.Fees);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean UpdateData(string fees, int courseid)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE dbo.Course1 SET fees=@fees WHERE courseId=@courseId";
            cmd.Parameters.AddWithValue("@fees", fees);
            cmd.Parameters.AddWithValue("@courseId", courseid);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Boolean DeleteData(int courseid)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = " DELETE dbo.Course1 WHERE Course1_courseId=@courseId";
            cmd.Parameters.AddWithValue("@courseId", courseid);
            con.Open();
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                successFlag = true;
            }
            return successFlag;

        }
        public Object RetriveData(int courseid)
        {
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            Console.WriteLine(courseid);
            cmd.CommandText = "DELETE dbo.Course1 WHERE Course1_courseId=@courseId";
            cmd.Parameters.AddWithValue("@courseId", courseid);
            con.Open();
            object walletamount = cmd.ExecuteScalar();
            return walletamount;
        }

        public Boolean Course1Data(int courseid)
        {
            Boolean successFlag = false;
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM dbo.Course1 WHERE Course1_courseId=@courseId";
            cmd.Parameters.AddWithValue("@courseId", courseid);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("CourseId : " + rdr[0] + "CourseName :  " + rdr[1] + " CourseDetail: " + rdr[2] + "Duration : " + rdr[3] + "Fees : " + rdr[4]);
                Console.ResetColor();
                successFlag = true;
            }
            return successFlag;


        }
        public int Count()
        {
            con = ConnectionEstablish();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT count(*)FROM dbo.Course1 ";
            con.Open();
            object count = cmd.ExecuteScalar();
            int cid = Convert.ToInt32(count);
            return cid;

        }
    }

}